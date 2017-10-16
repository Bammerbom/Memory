using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class ManagerMultiplayer
    {
        private static readonly int PacketSize = 1024 * 1024;
        public static bool Server(FormStartgame form, int port) {
            new Thread(() => {
                Server_internal(port);
            }).Start();
            MessageBox.Show("Connecting...");
            return true;
        }
        private static void Server_internal(int port) {
            NetServer.Start(ServerConnect, ServerMessage, ServerDisconnect, port, PacketSize);
            NetServer.NextClient();
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
            } else {
                Console.WriteLine("> DISCONNECT (NORMAL)");
            }
        }
    }
}
