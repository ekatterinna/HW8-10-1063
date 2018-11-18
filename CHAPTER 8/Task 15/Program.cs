using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.DifferenceBetweenDecimalAndDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int cicles = 50000000;
            DateTime start = DateTime.Now;
            float num1 = 0.000001f;
            float result = 0;
            for (int i = 0; i < cicles; i++)
            {
                result += num1;
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Float seconds = {0}", end - start);

            start = DateTime.Now;
            double num2 = 0.000001d;
            double resultD = 0;
            for (int i = 0; i < cicles; i++)
            {
                resultD += num2;
            }
            end = DateTime.Now;
            Console.WriteLine("Double seconds = {0}", end - start);

            start = DateTime.Now;
            decimal num3 = 0.000001m;
            decimal resultM = 0;
            for (int i = 0; i < cicles; i++)
            {
                resultM += num3;
            }
            end = DateTime.Now;
            Console.WriteLine("Decimal seconds = {0}", end - start);
        }
    }
}

