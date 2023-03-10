using SplitAppAPI.Models;
using System.Collections.Generic;
using System.Linq;
using UserRegistration.EntityFramework;

namespace SplitAppAPI.Services
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Delete(int id)
        {
            _applicationDbContext.User.Remove(GetById(id));
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _applicationDbContext.User;
        }

        public User GetById(int id)
        {
            return _applicationDbContext.User.Find(id);
        }

        public void Register(User user)
        {
            _applicationDbContext.User.Add(user);
            _applicationDbContext.SaveChanges();
        }

        public void Update(User user)
        {
            _applicationDbContext.User.Update(user);
            _applicationDbContext.SaveChanges();
        }
        public User CheckLogin(User user)
        {
            return _applicationDbContext.User.Where
                (c => c.EmailAddress == user.EmailAddress && c.Password == user.Password).FirstOrDefault();
        }

    }
}
