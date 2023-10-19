using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhdanovaAA.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                multiplySeries *= Math.Pow((300 / (i + Math.Pow(value, i))), i);
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
