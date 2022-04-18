using System;
using static System.Console;

namespace TEST
{
    class MainApp
    {

    }
}

#region Ex6_3
/*
namespace Ex6_3
{
    class MainApp
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
*/
#endregion

#region Ex6_2
/*
namespace Ex6_2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5);

            Console.WriteLine("평균: {0}", mean);

            void Mean(double a, double b, double c, double d, double e)
            {
                mean = (a + b + c + d + e) / 5;

            }

        }
    }
}
*/
#endregion

#region Ex6_1
/*
namespace Ex6_1
{
    class MainApp
    {
        static double Squrea(double arg)
        {
            return arg *= arg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력해주세요: ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과: {0}", Squrea(arg));
        }
    }
}
*/
#endregion

#region LocalFunction
/*
namespace LocalFunction
{
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#"));
        }
    }
}
*/
#endregion

#region NamedPrapeter
/*
namespace NamedPrapeter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "김용준");
            PrintProfile(name: "김성철", phone: "010-9251-7386");
            PrintProfile(name: "김윤희");
            PrintProfile(name: "이재희", phone: "010-9253-7386");
        }
    }
}
*/
#endregion