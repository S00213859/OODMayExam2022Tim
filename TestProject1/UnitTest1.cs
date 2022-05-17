using Microsoft.VisualStudio.TestTools.UnitTesting;
using OODMayExam2022;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Increase_By_Percentage()
        {
            //Arrange
            RentalProperty rp1 = new RentalProperty() { ID = 1, Price = 40 };
            decimal expectedRent = 50;

            //Act
            rp1.IncreaseRentByPercentage(10);

            //Assert
            Assert.AreEqual(expectedRent, rp1.Price);
        }
    }
}
