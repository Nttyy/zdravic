using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Zdravic zdravic = new Zdravic();
            zdravic.Pozdrav();
            Console.ReadKey();
        }
    }
}
