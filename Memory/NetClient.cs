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

        public static void Start(Action<string> clDisconnect, string ip, int port, int bytesize) {
            Ip = ip;
            Port = port;
            ByteSize = bytesize;
			Client = new TcpClient(ip, port);
            cDisconnect = clDisconnect;
		}

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

		public static void Disconnect() {
			Client.Close();
            cDisconnect("");
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