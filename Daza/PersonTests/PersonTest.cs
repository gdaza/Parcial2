using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gustavo;
namespace PersonTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void SaveMoney()
        {
            //Arrange
            double BeginningSavemoney =20;
            double Save = 50;
            double Expected = 70;
            Person money = new Person("River",BeginningSavemoney);
            //Act
            money.Save(Save);
            //Assert
            Assert.AreEqual(Expected,money.SaveMoney);
        }
    }
}
