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
		
		public static void Start(string ip, int port, int bytesize) {
            Ip = ip;
            Port = port;
            ByteSize = bytesize;
			Client = new TcpClient(ip, port);
		}

		public static void SendMessage(string message) {
			//Send message
			byte[] bytes = Encoding.UTF8.GetBytes(message);
			NetworkStream stream = Client.GetStream();  
			stream.Write(bytes, 0, bytes.Length);
		}

        public static string ReceiveMessage() {
            byte[] bytes = new byte[ByteSize];
            NetworkStream stream = Client.GetStream();
            stream.Read(bytes, 0, ByteSize);
            return cleanMessage(bytes);
        }

		public static void Disconnect() {
			Client.Close();
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