using Brive.Bootcamp.Project.API.Models;
using Brive.Bootcamp.Project.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Authentication(User user)
        {
            User userDb = new User();
            userDb = _userRepository.GetUser(user);
            user.Password = Encrypt.GetSHA256(user.Password);
            if (userDb == null)
                return false;
            else if (userDb.Password != user.Password)
                return false;
            else
                return true;
        }
    }
}
