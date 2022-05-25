using Brive.Bootcamp.Project.API.Models;
using Brive.Bootcamp.Project.API.Repositories;
using Brive.Bootcamp.Project.API.Services;
using Brive.Bootcamp.Project.Test.MockRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Brive.Bootcamp.Project.Test
{
    [TestClass]
    public class UnitTest1
    {
        private static IUserService _userService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IUserRepository> _userRepository = new UserRepositoryMock()._userRepository;
            _userService = new UserService(_userRepository.Object);
        }

        [TestMethod]
        public void Authentication_Ok()
        {
            User testUser = new User();
            testUser.Email = "correoprueba@gmail.com";
            testUser.Password = "012345";

            var result = _userService.Authentication(testUser);

            result.CompareTo(true);
        }

        [TestMethod]
        public void Authentication_Wrong_User()
        {
            User testUser = new User();
            testUser.Email = "correo@gmail.com";
            testUser.Password = "012345";

            var result = _userService.Authentication(testUser);

            result.CompareTo(false);
        }
        [TestMethod]
        public void Authentication_Wrong_Password()
        {
            User testUser = new User();
            testUser.Email = "correoprueba@gmail.com";
            testUser.Password = "prueba";

            var result = _userService.Authentication(testUser);

            result.CompareTo(false);
        }
        [TestMethod]
        public void Authentication_Empty_User()
        {
            User testUser = new User();
            testUser.Email = string.Empty;
            testUser.Password = "012345";

            var result = _userService.Authentication(testUser);

            result.CompareTo(false);
        }
        [TestMethod]
        public void Authentication_Empty_Password()
        {
            User testUser = new User();
            testUser.Email = "correoprueba@gmail.com";
            testUser.Password = string.Empty;

            var result = _userService.Authentication(testUser);

            result.CompareTo(false);
        }


    }
}
