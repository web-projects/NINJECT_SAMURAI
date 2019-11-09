using System;
using System.Collections.Generic;
using System.Text;

namespace Samurai
{
    class Weapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Chopped {target} clean in half.");
        }
    }
}
