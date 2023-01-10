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

                Console.WriteLine("What action do you want to perform? \n" +
                    " options: \n" +
                    " 'CTF': Celsius To Fahrenheit. \n" +
                    " 'AAM': Add And Multiply. \n" +
                    "'EO' Elementary Operations. \n" +
                    "'IRTS' Is Result The Same? \n" +
                    "'MO' Modulo Operations. \n" +
                    "'TCO' The Cupe Of. \n" +
                    "'STN' Swap Two Numbers.");
            mode = Console.ReadLine();
            mode = mode.ToUpper();
                if (mode == "CTF" || mode == "AAM" || mode == "EO" || mode == "IRTS" || mode == "MO" || mode == "TCO" || mode == "STN")
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Error: Command didn't mach anything.");
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
        private static void EO() {
            double a = GetInputAndConvertToDouble("You chose Elementary Operations. \n Type first number: ");
            double b = GetInputAndConvertToDouble("Type second number: ");

            Console.WriteLine("+:{0} -:{1} *:{2} /:{3}", a+b, a-b, a*b, a/b);
        }
        private static void IRTS()
        {
           
        }
        private static void MO()
        {

        }
        private static void TCO()
        {

        }
        private static void STN()
        {

        }

        static double GetInputAndConvertToDouble(string message)
        {
            bool valid = false;
            double output_value = 0;
            while (!valid)
            {
                Console.WriteLine(message);
                string input_value = Console.ReadLine();

                bool result = Double.TryParse(input_value, out output_value);
                if (result)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", input_value, output_value);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Error: could not convert '{0}' to a double", output_value);
                }
            }
            return output_value;
        }
        private static double ChooseAction(string action)
        {
            switch (action)
            {
                
                case "AAM":
                     AAM();

                    break;
                case "CTF":
                     CTF();

                    break;
                case "EO":
                     EO();

                    break;
                case "IRTS":
                     IRTS();

                    break;
                case "MO":
                     MO();

                    break;
                case "TCO":
                     TCO();

                    break;
                case "STN":
                     STN();

                    break;
               
                default:
                    return 0;
                    break;
            }
        }

    }
}
