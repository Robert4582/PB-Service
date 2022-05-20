using System;
using System.Text;

namespace Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TCPServer server = new TCPServer();

            server.Listen();
        }
    }
}
