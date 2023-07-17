using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectToBeTested;


///<summary>
///Unite Test 
///</summary>
namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test when Division method takes a divident (double input) and a divisor (double input), 
        /// it outputs a double data
        /// </summary>
        [TestMethod]
        public void Given_DoubleInput_When_Divided_Then_OutputDouble()
        {
            //Arrange
            var num1 = 6;
            var num2 = 3;
            //Act
            var result = Calculation.Division(num1, num2);
            //Assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Test when Division method takes a divident (zero) and a divisor (double input) 
        /// then output zero
        /// </summary>
        [TestMethod]
        public void Given_ZeroAsDivident_When_DividedWithDoubleDivosor_Then_OutputZero()
        {
            //Arrange
            var num1 = 0;
            var num2 = 3;
            //Act
            var result = Calculation.Division(num1, num2);
            //Assert
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Test when Division method takes a divident (double input) and a divisor (zero)
        /// then output num1, not ∞ (infinity).
        /// </summary>
        [TestMethod]
        public void Given_DoubleAsDivident_When_DividedWithZeroDivosor_Then_OutputDivident()
        {
            //Arrange
            var num1 = 3;
            var num2 = 0;
            //Act
            var result = Calculation.Division(num1, num2);
            //Assert
            Assert.AreEqual(3, result);
        }


    }
}
