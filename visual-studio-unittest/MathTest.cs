using System;
using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace visual_studio_unittest
{
    [TestClass]
    public class MathTest
    {
         [TestMethod]
        public void TestSumResultAreEqual()
        {
            MathClass objMath = new MathClass();
            Assert.AreEqual(24, objMath.Sum(12, 12));
        }

        [TestMethod]
        public void TestSumResultAreNotEqual()
        {
            MathClass objMath = new MathClass();
            Assert.AreNotEqual(25, objMath.Sum(12, 12));
        }

        [TestMethod]
        public void TestSumThrowExceptionWhenZero()
        {
            MathLibrary.MathClass objMath = new MathClass();

            try
            {
                objMath.Sum(0, 0);
            }
            catch (ArgumentException ex)
            {
                // logging code will go here  
                Assert.AreSame("No Zero or Negative are allowed", ex.Message);
            }
        }

        [TestMethod]
        public void TestSumThrowExceptionWhenNegative()
        {
            MathLibrary.MathClass objMath = new MathClass();

            try
            {
                objMath.Sum(-123, -456);
            }
            catch (ArgumentException ex)
            {
                // logging code will go here  
                Assert.AreSame("No Zero or Negative are allowed", ex.Message);
            }
        }
    }
}
