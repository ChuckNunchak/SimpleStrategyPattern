using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
     public void Attak(IAttack attack)
        {
            attack.doAttack();
        }
       
    }
}
