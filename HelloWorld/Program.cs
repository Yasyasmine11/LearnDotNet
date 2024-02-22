// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// use CNTRL F5 to exec
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // First step : printing our first sentence
            Console.WriteLine("Hello, World!");
            Console.WriteLine("*************");

            // Second : Using Variables
            byte number = 2;
            int count = 255;
            float note = 15.23f;
            char letter = 'r';
            string name = "Dangeon";
            bool isValable = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(note);
            Console.WriteLine(letter);
            Console.WriteLine(name);
            Console.WriteLine(isValable);
            Console.WriteLine("*************");

            // Third : Formating
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("*************");

            // Fourth : Conversion 
            byte i = 2;
            int j = (int)i;

            string a = "5";
            int b = Convert.ToInt32(a);
            // Or
            int c = int.Parse(a);

            try
            {
                var num = "12525";
                byte bi = Convert.ToByte(num);
                Console.WriteLine(bi);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't convert this number to a byte !!");
            }
            Console.WriteLine("*************");

            // Fifth : Operators


        }
    }
}
