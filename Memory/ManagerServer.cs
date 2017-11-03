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

        /// <summary>
        /// Locked de thread tot er een verbinding is
        /// </summary>
        /// <param name="port">De poort waar de server naar moet verbinden</param>
        /// <returns>Of er een verbinding is</returns>
        public static bool Server(int port) {
            Server_internal(port);

            //Popup
            //DialogResult result = MessageBox.Show("Wachten op verbinding...\nKlik op OK om te annuleren", "Memory");
            return true;
        }

        /// <summary>
        /// Locked de thread tot er een verbinding is
        /// </summary>
        /// <param name="port">De poort waar de server naar moet verbinden</param>
        /// <returns>Of er een verbinding is</returns>
        private static void Server_internal(int port) {
            NetServer.Start(ServerConnect, ServerDisconnect, port, PacketSize);
            NetServer.NextClient();
        }

        /// <summary>
        /// Wordt gerunned als er een verbinding is
        /// </summary>
        /// <param name="ip">Het ip van degene die verbonden is</param>
        public static void ServerConnect(string ip) {
            Console.WriteLine("> CONNECT " + ip);
        }

        /// <summary>
        /// Wordt gerunned als er iemand disconnect
        /// </summary>
        /// <param name="error">De error, or null als die er niet is</param>
        public static void ServerDisconnect(string error) {
            if (error != null) {
                Console.WriteLine("> DISCONNECT (ERROR)");
                Console.WriteLine(error);
            }
            else {
                Console.WriteLine("> DISCONNECT (NORMAL)");
            }
            BaseGame.Exitgame();
        }
    }
}