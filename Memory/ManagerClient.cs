using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory {
    class ManagerClient {
        private static readonly int PacketSize = 1024 * 1024;

        /// <summary>
        /// Verbindt met de server op het gegeven ip en poort
        /// </summary>
        /// <param name="ip">Het ip</param>
        /// <param name="port">De poort</param>
        /// <returns>Of er succesvol verbonden is</returns>
        public static bool Client(string ip, int port) {
            try {
                NetClient.Start(ServerDisconnect, ip, port, PacketSize);
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Deze method wordt gecalled als een client disconnect
        /// </summary>
        /// <param name="error">De error, or null als die niet bekend is</param>
        public static void ServerDisconnect(string error) {
            if (error != null) {
                Console.WriteLine("> DISCONNECT (ERROR)");
                Console.WriteLine(error);
            } else {
                Console.WriteLine("> DISCONNECT (NORMAL)");
            }
            BaseGame.Exitgame();
        }
    }
}