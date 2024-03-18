using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp21;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckNumberX_EnterMinus6_AnswerDoNotBelong()
        {
            double x = -6;
            string excpected = "не принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void CheckNumberX_EnterMinus5_AnswerBelong()
        {
            double x = -5;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void CheckNumberX_Enter2_AnswerBelong()
        {
            double x = 2;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        public void CheckNumberX_Enter5_AnswerBelong()
        {
            double x = 5;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void CheckNumberX_Enter7_AnswerDoNotBelong()
        {
            double x = 7;
            string excpected = "не принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void CheckNumberX_Enter12_AnswerBelong()
        {
            double x = 12;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void CheckNumberX_Enter15_AnswerBelong()
        {
            double x = 15;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        public void CheckNumberX_Enter23_AnswerBelong()
        {
            double x = 23;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
        public void CheckNumberX_Enter25_AnswerDoNotBelong()
        {
            double x = 25;
            string excpected = "принадлежит";
            string actual = MainWindow.CheckNumberX(x);
            Assert.AreEqual(excpected, actual);
        }
    }
}
