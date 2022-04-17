using NUnit.Framework;
using System;

namespace TestLabCalcApp.Tests
{
    public class Tests
    {
        [Test]
        public void Sum_tests()
        {
            Assert.AreEqual((double)3, Calculator.Add((double)1, (double)2));
            Assert.AreEqual((double)-1, Calculator.Add((double)1, (double)-2));
            Assert.AreEqual((double)1090000, Calculator.Add((double)90000, (double)1000000));
            Assert.AreEqual((double)-3, Calculator.Add((double)-2, (double)-1));
            Assert.AreEqual((double)0, Calculator.Add((double)0, (double)0));
        }

        [Test]
        public void Sub_tests()
        {
  
            Assert.AreEqual((double)-1, Calculator.Sub((double)1, (double)2));
            Assert.AreEqual((double)3, Calculator.Sub((double)1, (double)-2));
            Assert.AreEqual((double)910000, Calculator.Sub((double)1000000, (double)90000));
            Assert.AreEqual((double)-1, Calculator.Sub((double)-2, (double)-1));
            Assert.AreEqual((double)0, Calculator.Sub((double)0, (double)0));
        }

        [Test]
        public void Mult_tests()
        {

            Assert.AreEqual((double)10, Calculator.Mult((double)2, (double)5));
            Assert.AreEqual((double)-10, Calculator.Mult((double)2, (double)-5));
            Assert.AreEqual((double)995000, Calculator.Mult((double)1000, (double)995));
            Assert.AreEqual((double)10, Calculator.Mult((double)-2, (double)-5));
            Assert.AreEqual((double)0, Calculator.Mult((double)0, (double)2));
            Assert.AreEqual((double)0, Calculator.Mult((double)2, (double)0));
        }

        [Test]
        public void Div_tests()
        {

            Assert.AreEqual((double)0.4, Calculator.Div((double)2, (double)5));
            Assert.AreEqual((double)-0.4, Calculator.Div((double)2, (double)-5));
            Assert.AreEqual((double)0.5, Calculator.Div((double)1994, (double)3988));
            Assert.AreEqual((double)0.4, Calculator.Div((double)-2, (double)-5));
            Assert.AreEqual((double)0, Calculator.Div((double)0, (double)2));
            Assert.Throws<DivideByZeroException>(() => Calculator.Div((double)2, (double)0));
        }
    }
}