﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint3.Task1.V11.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1, stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(0.005, res);
        }
    }
}
