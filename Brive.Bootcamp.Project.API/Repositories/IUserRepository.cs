using Brive.Bootcamp.Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Repositories
{
    public interface IUserRepository
    {
        User GetUser(User user);
    }
}
