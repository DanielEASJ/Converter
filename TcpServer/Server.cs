using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpServer
{
    class Server
    {

        private int _port;
        private string myLine;
        private string line;

        public Server(int port)
        {
            this._port = port;
        }

        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, _port);
            serverListener.Start();

            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();

                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        public void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))

                while (myLine.ToLower().Trim() != "" || line.ToLower().Trim() != "stop")
                {

                    {
                        string line = sr.ReadLine();

                        Console.WriteLine($"string is {line}");

                        myLine = Console.ReadLine();

                        sw.WriteLine(myLine);
                        sw.Flush();


                    }
                }

        }
    }
}
