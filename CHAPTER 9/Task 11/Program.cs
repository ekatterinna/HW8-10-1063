using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.ProgramWithMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to reverse a number                          press 1");
            Console.WriteLine("If you want to calculata the avarege of sequence         press 2");
            Console.WriteLine("If you want to solves a linear equation a * x + b = 0    press 3");
            Console.Write("Choose option - ");
            int option = int.Parse(Console.ReadLine());
            while (option < 1 || option > 3)
            {
                Console.Write("Wrong option! Input again ");
                option = int.Parse(Console.ReadLine());
            }

            if (option == 1)
            {
                Option1();
            }
            else if (option == 2)
            {
                Option2();
            }
            else
            {
                Option3();
            }
        }

        private static void Option3()
        {
            Console.Write("Input number a ");
            int a = int.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.Write("Wrong! Input again ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Input number b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("x= {0}", (-b / (double)a));
        }

        private static void Option2()
        {
            Console.Write("Numbers to sum ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1)
            {
                Console.Write("Wrong! Input again ");
                n = int.Parse(Console.ReadLine());
            }
            int[] array = new int[n];
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input number {0} ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            //Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Avg is " + sum / n);
        }

        private static void Option1()
        {
            Console.Write("Write the number - ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Old Number is " + num);
            Console.WriteLine("New number is " + Reverse(num));
        }
        static int CountDigits(int num)
        {
            int cnt = 0;
            while (num != 0)
            {
                num /= 10;
                cnt++;
            }
            return cnt;
        }

        static int Reverse(int num)
        {
            int cnt = CountDigits(num);
            int tmpNum = 0;
            for (int i = cnt - 1; i >= 0; i--)
            {
                tmpNum += (num % 10) * (int)Math.Pow(10, i);
                num /= 10;
            }
            return tmpNum;
        }
    }
}
