using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitdemo
{
    class Program
    {
        static void Main(string[] args)
        {
           //q1();
           //q2();
           //q3();
           //q4();
           //q5();
           // q6();
           // q7();
           // q8();
            //q9();
            //q10();
           // q11();
            //q12();
            //q13();
           // q14();
            //q15();
           // q16();
            //q17();
           // q18();
            q20();
        }
        public static void q1()
        {
            Console.Write("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            int add = num1 - num2;
            Console.WriteLine("Addition: " +add );
            int diff = num1 - num2;
            Console.WriteLine("Difference: "+ diff);
            int product = num1 * num2;
            Console.WriteLine("Product: " + product);
        }
        public static void q2()
        {
            Console.Write("Enter a Number:");
            int num1 = int.Parse(Console.ReadLine());
            double power = Math.Pow(num1, 2);
            Console.WriteLine("Power value is:"+power);
        }
        public static void q3()
        {
            Console.WriteLine("Enter Length:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            int height = int.Parse(Console.ReadLine());
            int rec_volume = length * width * height;
            Console.WriteLine("Volume of Rectangular:"+rec_volume);
        }
        public static void q4()
        {
            Console.WriteLine("Enter Radius Value:");
            int radius = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter of a circle:"+perimeter);
        }
        public static void q5()
        {
            Console.Write("Enter Numerator Value:");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter Denominator Value:");
            int denominator = int.Parse(Console.ReadLine());
            int quotient = numerator / denominator;
            Console.WriteLine("Quotient value is:"+quotient);
            int remainder = numerator % denominator;
            Console.WriteLine("Remainder value is:"+remainder);
        }
        public static void q6()
        {
            Console.WriteLine("Enter the number to find Square Value:");
            int number = int.Parse(Console.ReadLine());
            double square = Math.Pow(number, 2);
            Console.WriteLine("Square of given number is:"+square);
        }
        public static void q7()
        {
            Console.WriteLine("Enter number to find Square Root Value:");
            int number = int.Parse(Console.ReadLine());
            double square_root = Math.Sqrt(number);
            Console.WriteLine("Square Root of given number is:" + square_root);
        }
        public static void q8()
        {
            Console.WriteLine("Calculate the Area of Traingle");
            Console.WriteLine("Enter Width value:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height value:");
            int height= int.Parse(Console.ReadLine());
            double area = 1.0 / 2 * (width * height);
            Console.WriteLine("Area of Traingle is:"+area);
        }
        public static void q9()
        {
            Console.WriteLine("Convert Kilometers to Miles");
            Console.WriteLine("Enter Kilometers:");
            int km = int.Parse(Console.ReadLine());
            double mile = km * 0.621371;
            Console.WriteLine("Mile Value is:"+mile);
        }
        public static void q10()
        {
            Console.WriteLine("Convert Celsius to Fahrenheit");
            Console.WriteLine("Enter Celsius Value:");
            int celsius=int.Parse (Console .ReadLine ());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit value is:"+fahrenheit);
        }
        public static void q11()
        {
            //Using temp Variable
            Console.WriteLine("Enter A value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value:");
            int b= int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping A value is :"+a);
            Console.WriteLine("After Swapping B value is :" + b);
        }
        public static void q12()
        {
            //Without temp variable
            Console.WriteLine("Enter A value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value:");
            int b = int.Parse(Console.ReadLine());
            a = a^b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("After Swapping A value is :" + a);
            Console.WriteLine("After Swapping B value is :" + b);
        }
        public static void q13()
        {
            Console.WriteLine("Enter A value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value:");
            int b = int.Parse(Console.ReadLine());
            a = a +b;
            b = a - b;
            a = a -b;
            Console.WriteLine("After Swapping A value is :" + a);
            Console.WriteLine("After Swapping B value is :" + b);
        }
        public static void q14()
        {
            Console.WriteLine("To Generate a Random Number");
            Random r = new Random();
            int result = r.Next(1, 101);
            Console.WriteLine("Random Number is:"+result);
        }
        public static void q15()
        {
            Console.WriteLine("Enter length:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width:");
            int width = int.Parse(Console.ReadLine());
            int arces = length * width;
            Console.WriteLine("arces is:" + arces);
            int sq = 43560 / arces;
            Console.WriteLine("sq feet is:" + sq);
        }
        public static void q16()
        {
            Console.WriteLine("Enter N number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Natural Number is {0}",n*(n+1)/2);
        }
        public static void q17()
        {
            Console.WriteLine("Enter Number1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3:");
            int num3 = int.Parse(Console.ReadLine());
            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average is:"+average);
        }
        public static void q18()
        {
            Console.WriteLine("Enter Bill Amount:");
            int amt = int.Parse(Console.ReadLine());
            double tips = amt*(5.0/100);
            Console.WriteLine("Tips Amount is:"+tips);
        }
        public static void q20()
        {
            Console.WriteLine("Enter Basic Pay:");
            int bp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DA:");
            int da = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ta Pay:");
            int ta = int.Parse(Console.ReadLine());
            Console.WriteLine("Gross pay is:" + (bp + (bp * da / 100) + (bp * ta / 100) - (8.0 / 100)));
        }

    }
}
