using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debt
{
    [TestClass]
    public class DebtTest
    {
        [TestMethod]
        public void TestCalculatePayment_10Days()
        {
            Assert.AreEqual(120, calculatePayment(100,10));
        }
        [TestMethod]
        public void TestCalculatePayment_1Days()
        {
            Assert.AreEqual(102, calculatePayment(100, 1));
        }
        [TestMethod]
        public void TestCalculatePayment_11Days()
        {
            Assert.AreEqual(155, calculatePayment(100, 11));
        }
        [TestMethod]
        public void TestCalculatePayment_30Days()
        {
            Assert.AreEqual(250, calculatePayment(100, 30));
        }
        [TestMethod]
        public void TestCalculatePayment_31Days()
        {
            Assert.AreEqual(410, calculatePayment(100, 31));
        }
        [TestMethod]
        public void TestCalculatePayment_40Days()
        {
            Assert.AreEqual(500, calculatePayment(100, 40));
        }


        public double calculatePayment(double rentValue, int delayDays)
        {
            //set coefficient
            double coeff = 1;
            if (delayDays >= 1 && delayDays <= 10)
            {
                coeff = 0.02;
            }
            if (delayDays > 10 && delayDays <= 30)
            {
                coeff = 0.05;
            }
            if (delayDays > 30 && delayDays <= 40)
            {
                coeff = 0.1;
            }

            return Math.Round((rentValue + delayDays * rentValue * coeff),2);

        }
    }
}
