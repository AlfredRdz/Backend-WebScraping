using Brive.Bootcamp.Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.Test.Stubs
{
    public static class UserStub
    {
        public static User user_prueba = new User()
        {
            Id = 1,
            Email = "correoprueba@gmail.com",
            Password = "2224512ef44a62e580bb1c0dcb33aff688f4e7da8a488aeb4e7ca402c5cacf45"
        };
    }
}
