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
            try
            {
                bool output = UserRegistration.UserRegister.validateFirstName("Prati");
            }
            catch (UserRegistrationException ue)
            {
                Assert.AreEqual("Invalid First Name,Name should be first letter capital", ue.Message);
            }
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            try
            {
                bool output = UserRegistration.UserRegister.validateLastName("Mastud");

            }
            catch (UserRegistrationException ue)
            {
                Assert.AreEqual("Invalid Last Name,Name should be first letter capital", ue.Message);

            }
        }

        /// <summary>
        /// Given Valid Email should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {
            try
            {
                bool output = UserRegistration.UserRegister.validateEmail("pratimastakki95@gmail.com");
            }
            catch (UserRegistrationException ue)
            {
                Assert.AreEqual("Invalid Email", ue.Message);
            }
        }


        /// <summary>
        /// Given Valid Mobile No should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            try
            {
                bool output = UserRegistration.UserRegister.validateMobileNo("91 9987936482");
            } catch (UserRegistrationException ue)
            {
                Assert.AreEqual("Invalid Mobile number,number should be predefined format", ue.Message);

            }
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>  
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            try
            {
                bool output = UserRegistration.UserRegister.validatePassword("Prati@123");
            }
            catch (UserRegistrationException ue)
            {
                Assert.AreEqual("Invalid Password,Password should be in format", ue.Message);
            }
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
            try
            {
                var result = UserRegistration.UserRegister.validateEmailList(email);
            }
            catch (UserRegistrationException ue)
            {
                Assert.AreEqual("Invalid Email.Email should be in format", ue.Message);
            }
        }
    }
}
