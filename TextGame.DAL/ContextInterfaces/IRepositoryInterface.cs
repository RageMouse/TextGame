using System;
using System.Collections.Generic;
using System.Text;
using TextGame.Domain;

namespace TextGame.DAL.Repositories
{
    public interface IRepositoryInterface
    {
        List<String> GetAllCharacterNames();


    }
}
