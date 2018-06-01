using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Domain
{
    class Food : Item
    {
        public Food(int id, string name, string description, int healthBonus) : base(id, name, description, "Food",
            healthBonus)
        {

        }
    }
}
