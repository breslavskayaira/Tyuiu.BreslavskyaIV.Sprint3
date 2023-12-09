using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double Mul = 0;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                Mul = Mul + ((Math.Pow(0.5, 2) * Math.Sin(i)));
            }

            return Math.Round(Mul, 3);
        }
    }
}