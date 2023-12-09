using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayaIV.Sprint3.Task3.V26.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'e';

            int res = ds.GetCharCount(value, item);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}