using System;
using System.Collections.Generic;

namespace TextGame.Domain
{
    public class Character
    {
        public string Name { get; set; }
        public DateTime PlayedOn { get; private set; }
        public int Score { get; set; }
        public List<Item> Items { get; set; }

    }
}
