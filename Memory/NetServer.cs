using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;

namespace Memory {
	class NetServer {
        private static int Port;
        private static int ByteSize;
        private static bool Open = false;
        private static TcpListener Listener;
        private static TcpClient Client;

        private static Action<string> cJoin;
        private static Func<string, string> cMessage;
        private static Action<string> cDisconnect;

        public static async void Start(Action<string> clJoin, Func<string, string> clMessage, Action<string> clDisconnect, int port, int bytesize) {
            cJoin = clJoin;
            cMessage = clMessage;
            cDisconnect = clDisconnect;
            Port = port;
            ByteSize = bytesize;
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, Port);
			Listener = new TcpListener(ep);
			Listener.Start();
		}

        public static bool IsOpen() {
            return Open;
        }

        public static bool NextClient() {
            Client = Listener.AcceptTcpClient();
            cJoin(Client.Client.RemoteEndPoint.ToString());
            Open = true;
            return true;
        }

        public static bool NextMessage() {
            try {
                byte[] buffer = new byte[ByteSize];
                Client.GetStream().Read(buffer, 0, ByteSize);
                string message = cleanMessage(buffer);
                if (message == null) {
                    cDisconnect(null);
                    Client.Close();
                    Open = false;
                    return false;
                }

                string rtrn = cMessage(message);

                //Reply
                byte[] bytes = Encoding.UTF8.GetBytes(rtrn);
                Client.GetStream().Write(bytes, 0, bytes.Length); // Send the response
                return true;
            } catch (Exception e) {
                cDisconnect(e.Message);
                Client.Close();
                Open = false;
                return false;
            }
        }

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