using System;
using System.Collections.Generic;
using System.Text;
using TextGame.DAL.ContextInterfaces;

namespace TextGame.DAL.Repositories
{
    public class CharacterRepository
    {
        private readonly ICharacterContext _characterContext;

        public CharacterRepository(ICharacterContext characterContext)
        {
            _characterContext = characterContext;
        }
        public List<String> GetAllPlayerNames()
        {
            return _characterContext.GetAllPlayerNames();
        }
    }
}
