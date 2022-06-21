using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardLibrary;
namespace CreditCardTestType
{
    [TestClass]
    public class CreditCardTest
    {
        [TestMethod]
        public void TypeAMEX()
        {
            long card = 375687654321001;
            string type = "AMEX";
            CreditCard credit = new CreditCard(card);
            Assert.AreEqual(type, credit.GetTypeCard(card));
        }
        [TestMethod]
        public void TypeMASTERCARD()
        {
            long card = 5367755632456260;
            string type = "MASTERCARD";
            CreditCard credit = new CreditCard(card);
            Assert.AreEqual(type, credit.GetTypeCard(card));
        }
        [TestMethod]
        public void TypeVISA()
        {
            long card = 4249175005737427;
            string type = "VISA";
            CreditCard credit = new CreditCard(card);
            Assert.AreEqual(type, credit.GetTypeCard(card));
        }
    }
}