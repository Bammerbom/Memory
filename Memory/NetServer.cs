using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;

namespace MemoryInternetTest {
	class NetServer {
        private static int Port;
        private static int ByteSize;

        public static void Start(Action<string> cJoin, Func<string, string> cMessage, Action<string> cDisconnect, int port, int bytesize) {
            Port = port;
            ByteSize = bytesize;
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, Port);
			TcpListener listener = new TcpListener(ep);
			listener.Start();
			Console.WriteLine("> SERVER START");

			// Run the loop continously; this is the server.  
			while (true) {
				//Prepare client
				byte[] buffer;
				var sender = listener.AcceptTcpClient();
				cJoin(sender.Client.RemoteEndPoint.ToString());
				
				//Read data
				while (true) {
					try {
						buffer = new byte[bytesize];
						sender.GetStream().Read(buffer, 0, bytesize);
						string message = cleanMessage(buffer);
						if (message == null) {
							cDisconnect(null);
							break;
						}
						
						string rtrn = cMessage(message);

						//Reply
						byte[] bytes = Encoding.UTF8.GetBytes(rtrn);
						sender.GetStream().Write(bytes, 0, bytes.Length); // Send the response
					}
					catch (Exception e) {
						cDisconnect(e.Message);
						break;
					}
				}
				
				sender.Close();
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