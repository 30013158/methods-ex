using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_methods
{
    class Program
    {
        static void Main(string[] args)
        {//taking user input
            string[] languages = {"Maori", "Japanese" , "Hindi", "French", "Samoan"};
            Console.WriteLine("enter a number between 1 and 5");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello is said as {0} in {1}", Lang(num), languages[num-1] );
            Console.ReadLine();
        }
        //creating a method 
        static string Lang(int num)
        {
            string[] lang = { "Kia Ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };
              return lang[num - 1]; }
    }
}
