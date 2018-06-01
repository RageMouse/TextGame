using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TextGame.DAL.Context;
using TextGame.DAL.Repositories;
using TextGame.Domain;

namespace TextGame.Web.Models
{
    public class CharacterViewModel
    {
        private CharacterRepository characterRepository = new CharacterRepository(new CharacterSqlContext());

        public CharacterViewModel()
        {
            Characters = characterRepository.GetAllPlayerNames();
            FillCharacterList();
        }

        public  List<SelectListItem> AllCharacters = new List<SelectListItem>();
        public string character { get; set; }

        public List<string> Characters { get; private set; }

        public string Name { get; set; }
        public DateTime PlayedOn { get; private set; }
        public int Score { get; set; }

        public void FillCharacterList()
        {
            if (Characters != null)
            {
                foreach (string character in Characters)
                {
                    AllCharacters.Add(new SelectListItem()
                    {
                        Text =  character,
                        Value =  character

                    });
                }
            }
        }
    }
}
