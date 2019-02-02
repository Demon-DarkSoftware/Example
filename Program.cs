using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamMethods
{
    class Program
    {
        static void InvokeWrite(int paramsNum, object paramsType) {
            int i = 0;
            while (i < paramsNum) {
                paramsType = Console.ReadLine();
                i++;
            }
        }
        static void PS() {
            int num = int.Parse(Console.ReadLine());
            if (num == 0) Console.WriteLine($"The number is '{num}' and it cannot be negative or positive!");
            else if (num < 0) Console.WriteLine($"Number '{num}' is negative due to '-' sign, that is placed before it's size!");
            else Console.WriteLine($"Number '{num}' is positive due to '+' sign, that is placed before it's size!");
        }
        static void PrintL(int s, int e) {
            for (int i = s; i <= e; i++) Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void PrintT(int n) {
            for (int l = 1; l <= n; l++) PrintL(1, l);
            for (int c = n-1; c >= 1; c--) PrintL(1, c);
        }
        static string GeneratePassword(int symbols) {
            string valid = "abcdefghijklmopqrstuvwxyz1234567890";
            int c = 0;
            string result = "";
            Random rnd = new Random();
            while (c < symbols) {
                result += valid[rnd.Next(0, valid.Length)];
                c++;
            }
            return result;
        }
        static void PrintHead(int n) {
            Console.Write(new string('-', 2 * n));
            Console.WriteLine();
        }
        static void PrintMiddle(int n) {
            Console.Write("-");
            for (int i = 1; i < n; i++) {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void PrintSq(int n) {
            PrintHead(n);
            for (int i = 1; i < n - 1; i++) PrintMiddle(n);
            PrintHead(n);
        }
        static double ToCelcius(double f)
        {
            return (f - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius {0} from F {1}", ToCelcius(f), f);
        }
    }
    public static class Extensions {
        public static double ToCelciusM(this double param) {
            double final = 0.0;
            final = (param - 32) * (5 / 9);
            return (param - 32) * (5 / 9);
        }
        public static double ToCelcius(double f) {
            double final = 0.0;
            final = (f - 32) * (5 / 9);
            return (f - 32) * (5 / 9);
        }
    }
}
