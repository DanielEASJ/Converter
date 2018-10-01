using System;

namespace TcpServer
{
    class ServerProgram
    {

        //hvis problemer opstår kan det skyldes at class navnet er ændret fra "program" til "ServerProgram"

        static void Main(string[] args)
        {
            TcpServer server = new TcpServer();
            server.Start();
        }
    }
}
