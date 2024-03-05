using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibrary;

namespace CarLibrary.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Accelerate_Test()
        {
            var car = new Automobile("Type", "Brand", "Color", 2.0);

            car.Accelerate(20);

            Assert.AreEqual(20, car.CurrentSpeed);
        }

        [TestMethod]
        public void Decelerate_Test()
        {
            var car = new Automobile("Type", "Brand", "Color", 2.0);

            car.Accelerate(30);
            car.Decelerate(10);

            Assert.AreEqual(20, car.CurrentSpeed);
        }
    }
}
