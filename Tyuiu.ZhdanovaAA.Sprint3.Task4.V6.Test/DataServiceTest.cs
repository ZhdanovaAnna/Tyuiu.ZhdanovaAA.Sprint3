using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint3.Task4.V6.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5, stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(8.995, res);
        }
    }
}
