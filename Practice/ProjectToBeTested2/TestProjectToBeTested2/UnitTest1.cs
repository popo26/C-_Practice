using ProjectToBeTested2;

namespace TestProjectToBeTested2
{
    [TestClass]
    public class UnitTest1
    {
        IUser _localTestUser;
   

        [TestInitialize]
        public void Setup()
        {
            _localTestUser = new User();
        }

        /// <summary>
        ///  DescribeMyName() method
        /// </summary>
        [TestMethod]
        public void Given_FirstName_LastName_When_DescribeMyFullNameMethod_Is_Used_Then_Returns_FullName()
        {
            //Arrange
            _localTestUser.FirstName = "Tom";
            _localTestUser.LastName = "Dutton";
            //Act
            var result = _localTestUser.DescribeMyFullName();
            //Assert
            Assert.AreEqual("My name is Tom Dutton", result);
        }

        [TestMethod]
        public void Given_FirstName_LastName_When_DescribeMyFirstNameMethod_Is_Used_Then_Returns_FirstName()
        {
            //Arrange
            _localTestUser.FirstName = "Coco";
            //Act
            var result = _localTestUser.DescribeMyFirstName();
            //Assert
            Assert.AreEqual("My name is Coco", result);
        }
    }
}