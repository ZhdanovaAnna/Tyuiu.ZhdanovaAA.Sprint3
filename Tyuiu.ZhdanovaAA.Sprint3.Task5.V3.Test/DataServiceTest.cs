using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint3.Task5.V3.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 11;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(33.247, res);
        }
    }
}
