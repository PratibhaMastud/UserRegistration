using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationPro;
using System;

namespace UserTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistration User;
        public UnitTest1()
        {
            User = new UserRegistration();
        }

        [TestMethod]
        public void validateFirstName()
        {
            var Result = User.FirstName("Pratibha");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void validateLastName()
        {
            var Result = User.LastName("Mastud");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Email_Test()
        {
            var Result = User.checkEmail("pratimastakki1995@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Mobile_Test()
        {
            var Result = User.MobileNumber("91 9865432666");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Password_Test()
        {
            var Result = User.Pasword("Prati@12");
            Assert.AreEqual(true, Result);

        }

        /// <summary>
        /// First the name using lambda expression.
        /// </summary>
        [TestMethod]
        public void FirstNameUsingLambdaExpression()
        {
            var Result = User.FirstName("Prati");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void LastNameUsingLambdaExpression()
        {
            var Result = User.LastName("Mast");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void EmailUsingLambdaExpression()
        {
            var Result = User.checkEmail("karandepratibha999@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MobileNumberUsingLabdaExpression()
        {
            var Result = User.MobileNumber("91 9975833272");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void PasswordUingLambdaExpression()
        {
            var Result = User.Pasword("Qwerty@123");
            Assert.AreEqual(true, Result);
        }
    }
}
