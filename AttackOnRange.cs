using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AttackOnRange : IAttack
    {
        public void doAttack()
        {
            Console.WriteLine("Range attack");
        }
    }
}
