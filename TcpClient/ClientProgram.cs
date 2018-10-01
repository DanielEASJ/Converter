using System;

namespace TcpClient
{
    class ClientProgram
    {

        //hvis problemer opstår kan det skyldes at class navnet er ændret fra "program" til "ClientProgram"


        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            client.Start();

        }
    }
}
