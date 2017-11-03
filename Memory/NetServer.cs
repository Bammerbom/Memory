using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Memory {
	class NetServer {
        private static int Port;
        private static int ByteSize;
        private static bool Open = false;
        private static TcpListener Listener;
        private static TcpClient Client;

        private static Action<string> cJoin;
        private static Action<string> cDisconnect;

        /// <summary>
        /// Start een server waar nog niet naar verbonden kan worden (zie: NextClient())
        /// </summary>
        /// <param name="clJoin">Deze method wordt gecalled als een client joint</param>
        /// <param name="clDisconnect">Deze method wordt gecalled als een client disconnect</param>
        /// <param name="port">De poort waar de client naar toe moet connecten</param>
        /// <param name="bytesize">Het aantal bytes dat per packet gestuurd wordt. (moet constant zijn tussen client en server)</param>
        public static void Start(Action<string> clJoin, Action<string> clDisconnect, int port, int bytesize) {
            cJoin = clJoin;
            cDisconnect = clDisconnect;
            Port = port;
            ByteSize = bytesize;
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, Port);
			Listener = new TcpListener(ep);
			Listener.Start();
		}

        /// <summary>
        /// Returned true als er momenteel een verbinding is
        /// </summary>
        /// <returns>Of er een verbinding is</returns>
        public static bool IsOpen() {
            return Open;
        }

        /// <summary>
        /// Sluit de huidige verbinding
        /// </summary>
        public static void Disconnect() {
            Client.Close();
            Open = false;
        }

        /// <summary>
        /// Freezed de huidige thread tot een client verbonden is
        /// </summary>
        /// <returns></returns>
        public static bool NextClient() {
            Client = Listener.AcceptTcpClient();
            cJoin(Client.Client.RemoteEndPoint.ToString());
            Open = true;
            return true;
        }

        /// <summary>
        /// Stuurt een bericht naar de client
        /// </summary>
        /// <param name="message">Het bericht</param>
        /// <returns>Of het succesvol afgeleverd is</returns>
        public static bool SendMessage(string message) {
            try {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                Client.GetStream().Write(bytes, 0, bytes.Length); // Send the response
                return true;
            } catch (Exception e) {
                cDisconnect(e.Message);
                Client.Close();
                Open = false;
                return false;
            }
        }

        /// <summary>
        /// Wacht tot er een bericht binnenkomt van de client
        /// </summary>
        /// <returns></returns>
        public static string ReceiveMessage() {
            try {
                byte[] buffer = new byte[ByteSize];
                Client.GetStream().Read(buffer, 0, ByteSize);
                string message = cleanMessage(buffer);
                if (message == null) {
                    cDisconnect(null);
                    Client.Close();
                    Open = false;
                    return null;
                }
                return message;
            } catch (Exception e) {
                cDisconnect(e.Message);
                Client.Close();
                Open = false;
                return null;
            }
        }

        /// <summary>
        /// Zet bytes om in een string
        /// </summary>
        /// <param name="bytes">De bytes die omgezet moeten worden</param>
        /// <returns>Het bericht</returns>
		private static string cleanMessage(byte[] bytes) {
			string message = Encoding.UTF8.GetString(bytes);

			string messageToPrint = null;
			foreach (var nullChar in message) {
				if (nullChar != '\0') {
					messageToPrint += nullChar;
				}
			}
			return messageToPrint;
		}
	}
}