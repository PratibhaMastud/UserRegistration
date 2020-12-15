using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenFirstNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistration.UserRegister.validateFirstName("Prati");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistration.UserRegister.validateLastName("Mastud");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Email should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistration.UserRegister.validateEmail("pratimastakki95@gmail.com");
            Assert.AreEqual(expected, output);
        }


        /// <summary>
        /// Given Valid Mobile No should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistration.UserRegister.validateMobileNo("91 9987936482");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>  
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserRegistration.UserRegister.validatePassword("Prati@123");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Test case for all valid and invalid emails
        /// </summary>
        /// <param name="email></param>
        [DataTestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenValidEmailListShouldReturnsTrue(string email)
        {
            bool expected = true;
            var result = UserRegistration.UserRegister.validateEmailList(email);
            Assert.AreEqual(expected, result);
        }
    }
}
