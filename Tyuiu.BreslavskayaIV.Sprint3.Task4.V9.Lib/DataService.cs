using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double Mul = 1.0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    Mul = Mul * i / (Math.Cos(i) - i);
                }

            }

            return Math.Round(Mul, 3);
        }
    }
}