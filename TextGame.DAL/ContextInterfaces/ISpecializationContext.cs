using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.DAL.ContextInterfaces
{
    public interface ISpecializationContext
    {
        bool CreateSpecialization();
        bool DeleteSpecialization();
        List<string> GetAllSpecialization();
    }
}
