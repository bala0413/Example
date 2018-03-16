using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Arith
    {
        int a, b, c;

        public void Addition()
        {
            Console.WriteLine("Enter the 1st value");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            b = Convert.ToInt16(Console.ReadLine());
            c = a+b;
            Console.WriteLine("\nAddition is: "+c);
        }
        public void Subtraction()
        {
            Console.WriteLine("Enter the 1st value");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            b = Convert.ToInt16(Console.ReadLine());
            c = a - b;
            Console.WriteLine("\nSubtraction is: " + c);
        }
        public void Multiplication()
        {
            Console.WriteLine("Enter the 1st value");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            b = Convert.ToInt16(Console.ReadLine());
            c = a * b;
            Console.WriteLine("\nMultiplication is: " + c);
        }
        public void Division()
        {
            Console.WriteLine("Enter the 1st value");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            b = Convert.ToInt16(Console.ReadLine());
            c = a / b;
            Console.WriteLine("\nDivision is: " + c);
        }
    }
    class Program
        { 

        static void Main(string[] args)
        {
            Arith objAr = new Arith();
            objAr.Addition();
            objAr.Subtraction();
            objAr.Multiplication();
            objAr.Division();
            Console.ReadLine();
        }
    }
}
