using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using TextGame.Domain;

namespace TextGame.DAL.Interface
{
    public interface IRepositoryInterface
    {
        List<String> GetAllCharacterNames();

        bool CreateCharacter(Character character);

    }
}
