using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter any operator you want to use");
            string operate = Console.ReadLine();
            Console.WriteLine("Your calculation is as follows:{0} {1} {2} = {3}", num1, operate, num2, Calculate(num1,num2,operate));
            Console.ReadLine();
        }
        static double Calculate(double num1, double num2, string operate)
        {
            double result = 0;
            if (operate == "+")
            { result = num1 + num2; }
            else if (operate == "-")
            { result = num1 - num2; }
            else if (operate == "*")
            { result = num1 * num2; }
            else if (operate == "/")
            { result = num1 / num2; }
            else if (operate == "%")
            { result = num1 % num2; }
            
      
            return result;
        }
    }
}
