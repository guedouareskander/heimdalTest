using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalTestClassLibrary.EX2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomeAngles()
        {
            //90°
            Assert.AreEqual(90, Clock.GeGetClockAngle(3, 0));
            Assert.AreEqual(90, Clock.GeGetClockAngle(4, 5));
            Assert.AreEqual(90, Clock.GeGetClockAngle(5, 10));
            Assert.AreEqual(90, Clock.GeGetClockAngle(6, 15));
            Assert.AreEqual(90, Clock.GeGetClockAngle(11, 10));
            Assert.AreEqual(90, Clock.GeGetClockAngle(9, 30));
            Assert.AreEqual(90, Clock.GeGetClockAngle(3, 30));
            Assert.AreEqual(90, Clock.GeGetClockAngle(4, 35));
            Assert.AreEqual(90, Clock.GeGetClockAngle(5, 40));

            //30°
            Assert.AreEqual(30, Clock.GeGetClockAngle(3, 10));
            Assert.AreEqual(30, Clock.GeGetClockAngle(4, 25));
            Assert.AreEqual(30, Clock.GeGetClockAngle(4, 15));
            Assert.AreEqual(30, Clock.GeGetClockAngle(3, 20));
            Assert.AreEqual(30, Clock.GeGetClockAngle(11, 0));
            Assert.AreEqual(30, Clock.GeGetClockAngle(11, 50));

        }
    }
}
