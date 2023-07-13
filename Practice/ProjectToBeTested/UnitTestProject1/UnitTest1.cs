using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectToBeTested;
using System;
using System.Net;

namespace UnitTestProject1
{
    //[TestInitialize]

    //public void Setup()
    //{
    //    continue;
    //}

    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Given_DoubleInput_When_AddedTwice_Then_OutputDouble()
        //{
        //    Calculation.Addition(2);
        //    Assert.AreEqual(2, 2);
        //}

        [TestMethod]
        public void Given_DoubleInput_When_Divided_Then_OutputDouble()
        {
            Assert.AreEqual(2, Calculation.Division(6, 3));
        }

        [TestMethod]
        public void Given_ZeroAsDivident_When_DividedWithDoubleDivosor_Then_OutputZero()
        { 
            Assert.AreEqual(0, Calculation.Division(0, 3));
        }

        [TestMethod]
        public void Given_DoubleAsDivident_When_DividedWithZeroDivosor_Then_OutputDivident()
        {
            Assert.AreEqual(3, Calculation.Division(3, 0));
        }


    }
}
