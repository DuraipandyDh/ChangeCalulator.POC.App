using ChangeCalulator.POC.BusinessLogic.Cureency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChangeCalulator.POC.IntegrationTests.CurrencyBalance
{
    [TestClass]
    public class ITCalculateBalance
    {
        [TestMethod]
        [Description("Calculate balance and denomination")]
        public void ITCalculateBalanceSuccess()
        {
            decimal givenAmount = 20.0m;
            decimal price = 5.5m;

            CurrenncyBL currenncybalance = new CurrenncyBL(givenAmount, price);


            Assert.AreEqual(14.5m, currenncybalance.NotesValue, "The sum of total balance is equal");

            Assert.AreEqual(1, currenncybalance.NoteCount[9], "The count of note 10 equal to 1");

            Assert.AreEqual(2, currenncybalance.NoteCount[7], "The count of note 2 equal to 2");
        }
    }
}
