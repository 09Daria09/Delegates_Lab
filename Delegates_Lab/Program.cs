using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Lab
{
    class Program
    {
        struct Text
        {
            public void Text_1(string str)
            {
                Console.WriteLine(str);
            }
            public void Text_2(string str)
            {
                Console.WriteLine(str);
            }
            public void Text_3(string str)
            {
                Console.WriteLine(str);
            }
        }
        public delegate void GetString(string str);

        struct Calculator
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
            public int Subt(int a, int b)
            {
                return a - b;
            }
            public int Mult(int a, int b)
            {
                return a * b;
            }
        }
        delegate int CalculatorDeleg(int a, int b);

        delegate bool ArithmDeleg(int num);
        struct Arithmetic
        {
            public bool Parity(int num)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                return false;
            }
            public bool Odd(int num)
            {
                if (num % 2 == 0)
                {
                    return false;
                }
                return true;
            }
            public bool Simple(int num)
            {
                if (num <= 1)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            public bool Fibanachi(int num)
            {
                if (num == 0 || num == 1)
                    return true;

                int fib1 = 0;
                int fib2 = 1;
                int Sum = 0;

                while (Sum < num)
                {
                    Sum = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = Sum;
                }

                return Sum == num;
            }

            public bool Func(int num, ArithmDeleg ptr)
            {
                return ptr(num);
            }
        }

        static void Main(string[] args)
        {
            //Text text = new Text();

            //GetString get = new GetString(text.Text_1);
            //get("Привет");

            //get = new GetString(text.Text_2);
            //get("Как дела?");

            //get = new GetString(text.Text_3);
            //get("И как давно я тебя не видел");

            //Calculator calculator = new Calculator();

            //CalculatorDeleg deleg = new CalculatorDeleg(calculator.Sum);
            //Console.WriteLine(deleg(5, 7));

            //deleg = new CalculatorDeleg(calculator.Mult);
            //Console.WriteLine(deleg(12, 3));

            //deleg = new CalculatorDeleg(calculator.Subt);
            //Console.WriteLine(deleg(165, 43));

            Arithmetic arithmetic = new Arithmetic();

            Console.WriteLine($"{arithmetic.Func(5, arithmetic.Odd)}");

        }
    }
}
