using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    class Program
    {

        public static void Main()
        {
            Console.Title = "Game Server";

            Server.Start(50, 26950);

            Console.ReadKey();

        }


    }
}
