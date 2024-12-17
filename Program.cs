using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_practice1
{
    public delegate int SumDelegate(int a, int b);
    public delegate int StringLengthDelegate(string input);
    public delegate int MaxLengthDelegate(int[] numbers);
    public delegate double SumDoubleDelegate(double a, double b);
    public delegate string UppStringDelegate(string input);
    public delegate int MinusLengthDelegate(int a, int b);
    internal class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int GetStrignLength(string input)
        {
            return input.Length;
        }
        public static int FindMaxValue(int[] numbers)
        {
            return numbers.Max();
        }
        public static double Sum2(double a, double b)
        {
            return a * b;
        }
        public static string UppStringDelegate(string input)
        {
            return input.ToUpper();
        }
        public static int Sum3(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            SumDelegate sumDelegate = new SumDelegate(Sum);
            int result = sumDelegate(5, 10);
            Console.WriteLine("Сумма = " + result);

            StringLengthDelegate stringLengthDelegate = new StringLengthDelegate(GetStrignLength);
            int lenght = stringLengthDelegate("qwe");
            Console.WriteLine("Длина строки: " + lenght);

            MaxLengthDelegate maxLengthDelegate = new MaxLengthDelegate(FindMaxValue);
            int[] array = { 3, 3, 4, 5, 6, 7, 7, 8, 9, 9, 10 };
            int Max = maxLengthDelegate(array);
            Console.WriteLine("Максимальное значение: " + Max);

            SumDoubleDelegate sumDoubleDelegate = new SumDoubleDelegate(Sum2);
            double result2 = sumDoubleDelegate(5.2, 10.5);
            Console.WriteLine("Сумма: " + result2);

            UppStringDelegate uppStringDelegate = new UppStringDelegate(UppStringDelegate);
            string toStringUp = uppStringDelegate("ВЫВЫЫЫЫА");
            Console.WriteLine("Строка в верхнем регистре: " + toStringUp);

            MinusLengthDelegate minusLengthDelegate = new MinusLengthDelegate(Sum3);
            int result3 = minusLengthDelegate(10, 5);
            Console.WriteLine("Разность:" + result3);
        }
    }
}
