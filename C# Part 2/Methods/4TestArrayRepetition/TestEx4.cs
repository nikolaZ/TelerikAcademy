using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4TestArrayRepetition
{
    [TestClass]
    public class TestEx4
    {
        [TestMethod]
        public void BorderCase()
        {
            decimal[] arr = new decimal[] { 1, 0, 2, 3, 4, 1 };
            decimal number = 1;
            int check=ArrayRepetition.RepetitionCounter(arr, number);
            Assert.AreEqual(check,2);
        }
        [TestMethod]
        public void NoSuchNumber()
        {
            decimal[] arr = new decimal[] { 1, 0, 2, 3, 4, 1 };
            decimal number = 5;
            int check = ArrayRepetition.RepetitionCounter(arr, number);
            Assert.AreEqual(check, 0);
        }
        [TestMethod]
        public void MaxValue()
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            decimal[] arr = new decimal[] { max, 0, min, 3, 4, max };
            decimal number = max;
            int check = ArrayRepetition.RepetitionCounter(arr, number);
            Assert.AreEqual(check, 2);
        }
        [TestMethod]
        public void MinValue()
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            decimal[] arr = new decimal[] { min, 0, min, 3, 4, max };
            decimal number = min;
            int check = ArrayRepetition.RepetitionCounter(arr, number);
            Assert.AreEqual(check, 2);
        }
        [TestMethod]
        public void MinMin()
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            decimal[] arr = new decimal[] { min+max, 0, min, 3, 4, max };
            decimal number = 0;
            int check = ArrayRepetition.RepetitionCounter(arr, number);
            Assert.AreEqual(check, 2);
        }
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void OverFlow()
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            decimal[] arr = new decimal[] { max + 1, 0, min, 3, 4, max };
            decimal number = 0;
            int check = ArrayRepetition.RepetitionCounter(arr, number);
            Assert.AreEqual(check, 2);
            
        }
    }
}
