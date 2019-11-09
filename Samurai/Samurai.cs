using Samurai.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samurai
{
    class Samurai
    {
        readonly IWeapon weapon;

        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Arm(Weapon weapon)
        {
            //this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
