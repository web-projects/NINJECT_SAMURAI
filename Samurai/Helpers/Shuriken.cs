using Samurai.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samurai.Helpers
{
    class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }
}
