using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sum = 1.0;

            do
            {
                sum = sum * Math.Cos(1.8) * Math.Pow(2, startValue) / (startValue + 1);
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}