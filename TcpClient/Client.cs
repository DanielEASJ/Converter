using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpClient
{
    class Client
    {
        private int _port = 7;

        public Client(int port)
        {
            this._port = port;
        }

        public void Start()
        {
            using (System.Net.Sockets.TcpClient socket = new System.Net.Sockets.TcpClient(IPAddress.Loopback.ToString(), _port))
            {
                NetworkStream ns = socket.GetStream();

                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    string incommingText = Console.ReadLine();

                    sw.WriteLine($"input was: {incommingText}");
                    sw.Flush();

                    string line = sr.ReadLine();
                    sw.WriteLine(line);

                }
            }
        }
    }
}
