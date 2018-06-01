using System;
using System.Collections.Generic;
using System.Text;
using TextGame.BLL;
using TextGame.DAL.ContextInterfaces;
using TextGame.DAL.Repositories;

namespace TextGame.BLL
{
    class CharacterLogic:ICharacterLogic
    {
        private IRepositoryInterface characterRepo;
        public List<String> GetAllCharacterNames()
        {
            return characterRepo.GetAllCharacterNames();
        }
    }
}   
