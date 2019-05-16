using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cents in which your transaction ends");
            int cents = int.Parse(Console.ReadLine());
            Console.WriteLine("Your transaction is rounded" +Transaction(cents));
        }

        static string Transaction(int input)
        {
            string result = "-1";
            switch (input)
            {

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    result = " Down";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    result =  "Up";
                    break;
            }
            return result;
        }
    }
}
