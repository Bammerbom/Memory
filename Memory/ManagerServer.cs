using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory {
    class ManagerServer {
        private static readonly int PacketSize = 1024 * 1024;

        public static bool Server(int port) {
            BackgroundWorker b = new BackgroundWorker();

            //Deze code wordt in een nieuwe Thread gerunned maar kan interacten met de main thread
            b.DoWork += delegate(object o, DoWorkEventArgs args) {
                BackgroundWorker bw = o as BackgroundWorker;
                Server_internal(port);
            };

            //Als iemand geconnect is
            Console.WriteLine("A");
            b.RunWorkerCompleted += delegate {
                Console.WriteLine("B");

            };
            
            b.RunWorkerAsync();

            //Popup
            //MessageBox.Show("Wachten op verbinding...\nKlik op OK om te annuleren", "Memory");
            Console.WriteLine("C");
            return true;
        }

        private static void Server_internal(int port) {
            NetServer.Start(ServerConnect, ServerMessage, ServerDisconnect, port, PacketSize);
            NetServer.NextClient();
            while (NetServer.IsOpen()) {
                NetServer.NextMessage();
            }
            
        }

        public static void ServerConnect(string ip) {
            Console.WriteLine("> CONNECT " + ip);
        }

        public static string ServerMessage(string message) {
            Console.WriteLine("> MESSAGE RECEIVED");
            Console.WriteLine(message);
            return "Ook " + message;
        }

        public static void ServerDisconnect(string error) {
            if (error != null) {
                Console.WriteLine("> DISCONNECT (ERROR)");
                Console.WriteLine(error);
            }
            else {
                Console.WriteLine("> DISCONNECT (NORMAL)");
            }
        }
    }
}