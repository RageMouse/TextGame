using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TextGame.BLL;
using TextGame.DAL.Context;
using TextGame.DAL.Repositories;
using TextGame.Domain;
using TextGame.Web.Models;

namespace TextGame.Web.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterLogic _characterLogic = new CharacterLogic(new CharacterRepository(new CharacterSqlContext()));

        public IActionResult Index()
        {
            CharacterViewModel model = new CharacterViewModel();
            model.FillCharacterList();
            return View(model);
        }


        public IActionResult Create()
        {
            return View(new Character());
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            bool used = _characterLogic.AddCharacter(character);
            return null;
        }
    }
}
