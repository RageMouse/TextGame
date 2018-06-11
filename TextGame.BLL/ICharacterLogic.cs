using System;
using System.Collections.Generic;
using TextGame.Domain;

namespace TextGame.BLL
{
    public interface ICharacterLogic
    {
        List<String> GetAllCharacterNames();

        bool AddCharacter(Character character);

    }
}
