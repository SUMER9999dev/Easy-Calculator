using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Calculator
{
    class Program
    {

        public static int calc1(int arg1, int arg2) //plus
        {
            return arg1 + arg2;
        }

        public static int calc2(int arg1, int arg2) //multiply
        {
            return arg1 * arg2;
        }

        public static int calc3(int arg1, int arg2) //divide
        {
            return arg1 / arg2; 
        }

        public static int calc4(int arg1, int arg2) //minus
        {
            return arg1 - arg2;
        }



        static void Main(string[] args)
        {
            Console.Title = "Easy Calculator"; //set title
            Console.WriteLine("Write first int");
            string value = Console.ReadLine(); //read line for calc it
            Console.WriteLine("Write second int");
            string value2 = Console.ReadLine(); //read line for calc it
            int ToInt = Convert.ToInt32(value); //Convert string to int
            int ToInt2 = Convert.ToInt32(value2); //Convert string to int
            Console.WriteLine($"{value} + {value2} = {calc1(ToInt, ToInt2)}"); //plus
            Console.WriteLine($"{value} - {value2} = {calc4(ToInt, ToInt2)}"); //minus
            Console.WriteLine($"{value} * {value2} = {calc2(ToInt, ToInt2)}"); //multiply
            if(ToInt2 != 0) //check if ToInt2 dont equals 0
            {
                Console.WriteLine($"{value} / {value2} = {calc3(ToInt, ToInt2)}"); //divide
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed divide to on 0!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); //Read key
        }
    }
}
