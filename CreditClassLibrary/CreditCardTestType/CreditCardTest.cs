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
            long card = 378282246310005;
            string type = "AMEX";
            CreditCard credit = new CreditCard(card);
            Assert.AreEqual(type, credit.GetTypeCard(card));
        }
        [TestMethod]
        public void TypeMASTERCARD()
        {
            long card = 5579175005737625;
            string type = "MASTERCARD";
            CreditCard credit = new CreditCard(card);
            Assert.AreEqual(type, credit.GetTypeCard(card));
        }
        [TestMethod]
        public void TypeVISA()
        {
            long card = 4561261212345437;
            string type = "VISA";
            CreditCard credit = new CreditCard(card);
            Assert.AreEqual(type, credit.GetTypeCard(card));
        }
    }
}