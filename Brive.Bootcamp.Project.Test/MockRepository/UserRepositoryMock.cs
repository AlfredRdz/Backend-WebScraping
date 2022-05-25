using Brive.Bootcamp.Project.API.Models;
using Brive.Bootcamp.Project.API.Repositories;
using Brive.Bootcamp.Project.Test.Stubs;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.Test.MockRepository
{
    public class UserRepositoryMock
    {
        public Mock<IUserRepository> _userRepository { get; set; }

        public UserRepositoryMock()
        {
            _userRepository = new Mock<IUserRepository>();
            Setup();
        }

        private void Setup()
        {
            _userRepository.Setup(x => x.GetUser(It.IsAny<User>())).Returns(UserStub.user_prueba);
        }
    }
}
