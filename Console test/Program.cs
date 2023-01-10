using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mode = "";
            bool valid = false;
            while (valid == false)
            {
                Console.Clear();

                Console.WriteLine("What action do you want to perform? \n options: \n 'CTF': Celsius To Fahrenheit. \n 'AAM': Add And Multiply.");
            mode = Console.ReadLine();
            mode = mode.ToUpper();
                if (mode == "CTF" || mode == "AAM")
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Error: Command didn't mach anything. ");
                }
            }
            
            
            ChooseAction(mode);
           
            Console.ReadKey();
        }
        //methods
        private static double AAM()
        {
            Console.Clear();
            Console.WriteLine("You chose add and multyply \n Type first number: ");
            string a = Console.ReadLine();
            Console.WriteLine("Type second number: ");
            string b = Console.ReadLine();
            Console.WriteLine("Type third number: ");
            string c = Console.ReadLine();
            double ab = double.Parse(a) + double.Parse(b);
            return ab * double.Parse(c);
        }
       
        private static double CTF()
        {
            Console.Clear();

            Console.WriteLine("You chose add and multyply \n Type first number: ");
            string celsius = Console.ReadLine();
            if (double.Parse(celsius) < -271.15)
            {
                return 0;
            }
            else
            {
            double placeholder = double.Parse(celsius) * 1.8;
            return placeholder+32;
            }
           
        }
        private static double ChooseAction(string action)
        {
            switch (action)
            {
                
                case "AAM":
                    return AAM();

                    break;
                case "CTF":
                    return CTF();

                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
