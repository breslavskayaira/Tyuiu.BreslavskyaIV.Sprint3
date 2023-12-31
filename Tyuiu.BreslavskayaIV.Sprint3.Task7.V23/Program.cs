﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayaIV.Sprint3.Task7.V23.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вывести таблицу значений функции на диапазоне [-5,5]                     *");

            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* y = 4-2x+(2+cos(x))/(2x-2)                                               *");
            Console.WriteLine("****************************************************************************");


            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);



            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("+---------------------+---------------------+");
            Console.WriteLine("+          X          +         f(x)        +");
            Console.WriteLine("+---------------------+---------------------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|        {0,5:d}        |        {1, 5:f2}        |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+---------------------+---------------------+");
            Console.ReadKey();
        }
    }
}