using SplitAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRegistration.EntityFramework;

namespace SplitAppAPI.Services
{
    public class PersonsService : IPersonsService
    {
        private ApplicationDbContext _applicationDbContext;
        public PersonsService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void AddPerson(Persons person)
        {
            _applicationDbContext.Persons.Add(person);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<Persons> GetAllPersons()
        {
            return _applicationDbContext.Persons;
        }
    }
}
