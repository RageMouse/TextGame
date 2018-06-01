using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Domain
{
    public abstract class Item
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }
        private int Bonus { get; set; }

        public Item(int id, string name, string category, string description, int bonus)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Bonus = bonus;
        }
    }
}
