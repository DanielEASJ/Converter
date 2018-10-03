using System;

namespace TcpClient
{
    class ClientProgram
    {

        //hvis problemer opstår kan det skyldes at class navnet er ændret fra "program" til "ClientProgram"


        static void Main(string[] args)
        {
            Client client = new Client(7);
            client.Start();

        }
    }
}
