using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    internal class Enemy : Hero
    {
        public Enemy() : base("zombie", getHP(), getDamage())
        {

        }
        private static int getHP()
        {
            return new Random().Next(50, 150);
        }
        private static int getDamage()
        {
            return new Random().Next(5, 10);
        }
    }
}
