using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint3.Task0.V10.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint3.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int Value = 5, startValue = 1, stopValue = 5;

            double res = ds.GetMultiplySeries(Value, startValue, stopValue);

            Assert.AreEqual(0.033, ds.GetMultiplySeries(5, 1, 5));
        }
    }
}
