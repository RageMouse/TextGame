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

        public List<String> GetAllPlayerNames()
        {
            return _characterContext.GetAllPlayerNames();
        }

    }
}
