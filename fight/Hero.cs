using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    internal class Hero
    {
        protected string name;
        protected int hp;
        protected int damage;

        public Hero(string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
        }
    }
}
