using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.DAL.ContextInterfaces
{
    public interface ICharacterContext
    {
        bool CreateCharacter();
        List<String> GetAllPlayerNames();

    }
}
