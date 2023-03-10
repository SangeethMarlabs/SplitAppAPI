using SplitAppAPI.Models;
using System.Collections.Generic;

namespace SplitAppAPI.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Register(User user);
        void Update(User user);
        void Delete(int id);
        User CheckLogin(User user);
    }
}
