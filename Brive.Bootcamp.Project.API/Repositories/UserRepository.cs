using Brive.Bootcamp.Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BPContext context;

        public UserRepository(BPContext _context)
        {
            context = _context;
        }
        public User GetUser(User user)
        {
            User searchedUser = context.User.Where(y =>
                                y.Email == user.Email).FirstOrDefault();
            return searchedUser;
        }
    }
}
