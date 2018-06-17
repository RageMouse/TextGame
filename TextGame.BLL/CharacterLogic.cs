using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using TextGame.BLL;
using TextGame.DAL.ContextInterfaces;
using TextGame.DAL.Interface;
using TextGame.DAL.Repositories;
using TextGame.Domain;

namespace TextGame.BLL
{
    public class CharacterLogic:ICharacterLogic
    {
        private IRepositoryInterface characterRepo;

        public CharacterLogic(IRepositoryInterface repositoryInterface)
        {
            characterRepo = repositoryInterface;
        }

        public List<String> GetAllCharacterNames()
        {
            return characterRepo.GetAllCharacterNames();
        }

        public bool AddCharacter(Character character)
        {
            return characterRepo.CreateCharacter(character);
        }
    }
}   
