using SplitAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitAppAPI.Services
{
    public interface IPersonsService
    {
        IEnumerable<Persons> GetAllPersons();
        void AddPerson(Persons person);
    }
}
