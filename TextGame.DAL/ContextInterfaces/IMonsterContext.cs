using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.DAL.ContextInterfaces
{
    public interface IMonsterContext
    {
        bool GetAllNames();
        bool GetHealthPoints(int id);

    }
}
