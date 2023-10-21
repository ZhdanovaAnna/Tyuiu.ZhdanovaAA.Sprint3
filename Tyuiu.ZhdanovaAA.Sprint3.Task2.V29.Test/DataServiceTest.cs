using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint3.Task2.V29.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint3.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1, stopValue = 18;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(-0.186, res);
        }
    }
}
