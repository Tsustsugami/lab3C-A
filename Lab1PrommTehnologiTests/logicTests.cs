using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1PrommTehnologi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1PrommTehnologi.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FirstDigitLargestTest()
        {
            var number = 988;
            var message = Logic.Decision(number);
            Assert.AreEqual("Максимальная цифра в числе 9",message);
        }
        [TestMethod()]
        public void SecondDigitLargestTest()
        {
            var number = 262;
            var message = Logic.Decision(number);
            Assert.AreEqual("Максимальная цифра в числе 6", message);
        }
        [TestMethod()]
        public void ThirdDigitLargestTest()
        {
            var number = 118;
            var message = Logic.Decision(number);
            Assert.AreEqual("Максимальная цифра в числе 8", message);
        }
    }
}