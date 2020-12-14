using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProject;

namespace UserRegistrationTest
{
    [TestClass]
    class TestClass
    {
        /// <summary>
        /// Given Valid First Name should return true
        /// </summary>
        [TestMethod]
        public void GivenFirstNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistrationProject.UserRegistration.validateFirstName("Prati");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistrationProject.UserRegistration.validateLastName("Mastud");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Email should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistrationProject.UserRegistration.validateEmail("abc.xyz@gmail.com");
            Assert.AreEqual(expected, output);
        }


        /// <summary>
        /// Given Valid Mobile No should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistrationProject.UserRegistration.validateMobileNo("91 9987936482");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistrationProject.UserRegistration.validatePassword("Prati@123");
            Assert.AreEqual(expected, output);
        }
    }
}
