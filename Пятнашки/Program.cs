using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameof15.Data;

namespace Gameof15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 9, 2, 5, 7, 33, 61, 74, 82, 0 };
            Game n2 = new Game(mass);
            Console.ReadKey();

        }
    }
}
