using System;
using System.Collections.Generic;
using System.Text;
using TextGame.DAL.ContextInterfaces;
using TextGame.DAL.Interface;
using TextGame.Domain;

namespace TextGame.DAL.Repositories
{
    public class CharacterRepository : IRepositoryInterface
    {
        private readonly ICharacterContext _characterContext;


        public CharacterRepository(ICharacterContext characterContext)
        {
            _characterContext = characterContext;
        }

        public List<string> GetAllCharacterNames()
        {
            throw new NotImplementedException();
        }

        public bool CreateCharacter(Character character)
        {
            return _characterContext.CreateCharacter(character);
        }

        public List<String> GetAllPlayerNames()
        {
            return _characterContext.GetAllPlayerNames();
        }

        public List<String> GetAllPlayerNamesSpecialization()
        {
            return _characterContext.GetAllPlayerNames();
        }

    }
}
