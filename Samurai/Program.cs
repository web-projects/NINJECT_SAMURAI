using Samurai.Helpers;
using System;

namespace Samurai
{
    /// <summary>
    /// reference: https://github.com/ninject/Ninject/wiki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //var warrior = new Samurai();
            //warrior.Attack("the evildoers");

            var warrior1 = new Samurai(new Shuriken());
            var warrior2 = new Samurai(new Sword());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");
        }
    }
}
