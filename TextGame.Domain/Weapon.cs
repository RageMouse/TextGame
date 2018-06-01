using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Domain
{
    public class Weapon : Item
    {
        public Weapon(int id, string name, string description, int attackBonus) : base(id, name, description, "Weapon",
            attackBonus)
        {

        }
    }
}
