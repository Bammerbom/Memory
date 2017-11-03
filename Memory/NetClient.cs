using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Memory {
	class NetClient {
		private static TcpClient Client;
        private static string Ip;
        private static int Port;
        private static int ByteSize;
        private static Action<string> cDisconnect;

        /// <summary>
        /// Deze method start een client, en laat hem connecten naar het gegeven ip
        /// </summary>
        /// <param name="clDisconnect">Deze method wordt gecalled als de client gedisconnect wordt.</param>
        /// <param name="ip">Het ip waar de client naar moet connecten</param>
        /// <param name="port">De poort waar de client naar moet connecten</param>
        /// <param name="bytesize">Het aantal bytes dat per packet gestuurd wordt. (moet constant zijn tussen client en server)</param>
        public static void Start(Action<string> clDisconnect, string ip, int port, int bytesize) {
            Ip = ip;
            Port = port;
            ByteSize = bytesize;
			Client = new TcpClient(ip, port);
            cDisconnect = clDisconnect;
		}

        /// <summary>
        /// Verstuurt een message naar de client
        /// </summary>
        /// <param name="message">Het bericht</param>
		public static void SendMessage(string message) {
            try {
                //Send message
                byte[] bytes = Encoding.UTF8.GetBytes(message);
			    NetworkStream stream = Client.GetStream();  
		    	stream.Write(bytes, 0, bytes.Length);
            } catch (Exception e) {
                cDisconnect(e.Message);
                Client.Close();
            }
        }

        /// <summary>
        /// Locked de huidige thread totdat er een bericht binnenkomt, en returned die.
        /// </summary>
        /// <returns>Het bericht, of null als er gedisconnect wordt.</returns>
        public static string ReceiveMessage() {
            try {
                byte[] bytes = new byte[ByteSize];
                NetworkStream stream = Client.GetStream();
                stream.Read(bytes, 0, ByteSize);
                return cleanMessage(bytes);
            }catch(Exception e) {
                cDisconnect(e.Message);
                Client.Close();
                return null;
            }
        }

        /// <summary>
        /// Dwingt de client om te disconnecten
        /// </summary>
		public static void Disconnect() {
			Client.Close();
            cDisconnect("");
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