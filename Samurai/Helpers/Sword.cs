using Samurai.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samurai.Helpers
{
    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }
}
