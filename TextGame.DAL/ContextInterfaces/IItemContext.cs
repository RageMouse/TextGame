using System;
using System.Collections.Generic;
using System.Text;
using TextGame.Domain;

    namespace TextGame.DAL.ContextInterfaces
    {
        public interface IItemContext
        {

            bool CreateItem(Item item);
            bool DeleteItem(int id);
            List<Item> GetAllItems();
            List<string> GetAllCategories();
        }
    }
