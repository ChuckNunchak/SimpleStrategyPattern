using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MilliAttack : IAttack
    {
        public void doAttack()
        {
            Console.WriteLine("Milli attack");
        }
    }
}
