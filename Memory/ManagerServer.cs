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
        private static BackgroundWorker b;

        public static bool Server(int port) {
            /*b = new BackgroundWorker();

            //Deze code wordt in een nieuwe Thread gerunned maar kan interacten met de main thread
            b.DoWork += delegate(object o, DoWorkEventArgs args) {
                BackgroundWorker bw = o as BackgroundWorker;
                
            };

            //Als iemand geconnect is
            Console.WriteLine("A");
            b.RunWorkerCompleted += delegate {
                Console.WriteLine("B");
                
            };
            
            //Start achtergrond taak
            b.RunWorkerAsync();*/
            Server_internal(port);

            //Popup
            //DialogResult result = MessageBox.Show("Wachten op verbinding...\nKlik op OK om te annuleren", "Memory");
            return true;
        }

        private static void Server_internal(int port) {
            NetServer.Start(ServerConnect, ServerDisconnect, port, PacketSize);
            NetServer.NextClient();
        }

        public static void ServerConnect(string ip) {
            Console.WriteLine("> CONNECT " + ip);
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