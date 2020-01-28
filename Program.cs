using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Attak(new MilliAttack());
            player.Attak(new AttackOnRange());
            Console.ReadKey();
        }
    }
}
