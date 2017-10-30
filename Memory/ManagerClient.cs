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

        public static bool Client(string ip, int port) {
            try {
                NetClient.Start(ServerDisconnect, ip, port, PacketSize);
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

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