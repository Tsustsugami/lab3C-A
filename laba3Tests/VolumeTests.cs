using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Tests
{
    [TestClass()]
    public class VolumeTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var Volume = new Volume(38, MeasureType.l);
            Assert.AreEqual("38 л.", Volume.Verbose());

            Volume = new Volume(38, MeasureType.M3);
            Assert.AreEqual("38 М3.", Volume.Verbose());

            Volume = new Volume(38, MeasureType.ML);
            Assert.AreEqual("38 м.л.", Volume.Verbose());

            Volume = new Volume(38, MeasureType.bar);
            Assert.AreEqual("38 баррель", Volume.Verbose());
        }
        public void AddNumberTest()
        {
            var Volume = new Volume(1, MeasureType.l);
            Volume = Volume + 4.25;
            Assert.AreEqual("5.25 л.", Volume.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var length = new Volume(3, MeasureType.l);
            length = length - 1.75;
            Assert.AreEqual("1,25 л.", length.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var length = new Volume(3, MeasureType.l);
            length = length * 3;
            Assert.AreEqual("9 л.", length.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var length = new Volume(3, MeasureType.l);
            length = length / 3;
            Assert.AreEqual("1 л.", length.Verbose());
        }
        [TestMethod()]
        public void litrToAnyTest()
        {
            Volume volume;

            volume = new Volume(10, MeasureType.l);
            Assert.AreEqual("10000 м.л.", volume.To(MeasureType.ML).Verbose());

            volume = new Volume(1000, MeasureType.l);
            Assert.AreEqual("1 М3.", volume.To(MeasureType.M3).Verbose());

            volume = new Volume(100 * 158.99, MeasureType.l);
            Assert.AreEqual("100 баррель", volume.To(MeasureType.bar).Verbose());
        }
        [TestMethod()]
        public void AddSubM3MetersTest()
        {
            var l = new Volume(100, MeasureType.l);
            var m3 = new Volume(1, MeasureType.M3);

            Assert.AreEqual("1100 л.", (l + m3).Verbose());
            Assert.AreEqual("1,1 М3.", (m3 + l).Verbose());

            Assert.AreEqual("0,9 М3.", (m3 - l).Verbose());
            Assert.AreEqual("-900 л.", (l - m3).Verbose());
        }
    }
}