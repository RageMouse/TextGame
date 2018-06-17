using System;
using System.Collections.Generic;
using System.Text;
using TextGame.Domain;

namespace TextGame.DAL.ContextInterfaces
{
    public interface ICharacterContext
    {
        bool CreateCharacter(Character character);

        List<String> GetAllPlayerNames();

        List<String> GetAllPlayerNamesSpecializations();
    }
}
