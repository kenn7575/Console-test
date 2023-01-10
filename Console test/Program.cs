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
            while (true)
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
              void AAM()
            {
                Console.Clear();

                Console.Clear();
                Console.WriteLine("You chose add and multyply \n Type first number: ");
                string a = Console.ReadLine();
                Console.WriteLine("Type second number: ");
                string b = Console.ReadLine();
                Console.WriteLine("Type third number: ");
                string c = Console.ReadLine();
                double ab = double.Parse(a) + double.Parse(b);
                Console.WriteLine( ab * double.Parse(c));
            }

              void CTF()
            {
                Console.Clear();

                Console.WriteLine("You chose add and multyply \n Type first number: ");
                string celsius = Console.ReadLine();
                if (double.Parse(celsius) < -271.15)
                {
                    Console.WriteLine("Error: below absolute zero!");
                }
                else
                {
                    double placeholder = double.Parse(celsius) * 1.8;
                    Console.WriteLine(placeholder + 32);
                }

            }
              void EO()
            {
                Console.Clear();

                double a = GetInputAndConvertToDouble("You chose Elementary Operations. \n Type first number: ");
                double b = GetInputAndConvertToDouble("Type second number: ");

                Console.WriteLine("+:{0} -:{1} *:{2} /:{3}", a + b, a - b, a * b, a / b);
            }
            void IRTS()
            {
                Console.Clear();

                double a = GetInputAndConvertToDouble("You chose Is Result The Same? \n Type first number: ");
                double b = GetInputAndConvertToDouble("Type second number: ");
                if (a + b == a * b)
                {
                    Console.WriteLine("{2}+{3} ({0}) is the same as {2}*{3} ({1})", a + b, a * b, a, b);
                }
                else
                {
                    Console.WriteLine("{2}+{3} ({0}) is not the same as {2}*{3} ({1})", a + b, a * b, a, b);
                }
                if (a - b == a / b)
                {
                    Console.WriteLine("{2}-{3} ({0}) is the same as {2}/{3} ({1})", a - b, a / b, a, b);
                }
                else
                {
                    Console.WriteLine("{2}-{3} ({0}) is not the same as {2}/{3} ({1})", a - b, a / b, a, b);
                }
            }
              void MO()
            {
                Console.Clear();

                int a = GetInputAndConvertToInt("You chose Modulo Operations. \n Type first number: ");
                int b = GetInputAndConvertToInt("Type second number: ");
                Console.WriteLine("The remainder is {0}", a % b);
            }
              void TCO()
            {
                Console.Clear();
                double a = GetInputAndConvertToDouble("You chose The Cupe Of. \n Type a number: ");
               
                Console.WriteLine("The remainder is {0}", a * a * a);
            }
              void STN()
            {
                Console.Clear();

                double a = GetInputAndConvertToDouble("You chose The Cupe Of. \n Type first number: ");
                double b = GetInputAndConvertToDouble("Type second number: ");
                Console.WriteLine("Swap: [{0}, {1}]", b, a);

            }

            double GetInputAndConvertToDouble(string message)
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
                        valid = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error: could not convert {0} to int", input_value );
                    }
                }
                return output_value;
            }
            int GetInputAndConvertToInt(string message)
            {
                bool valid = false;
                int output_value = 0;
                while (!valid)
                {
                    Console.WriteLine(message);
                    string input_value = Console.ReadLine();

                    bool result = Int32.TryParse(input_value, out output_value);
                    if (result)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error: could not convert '{0}' to a double", input_value);
                    }
                }
                return output_value;
            }
            void ChooseAction(string action)
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

                        break;
                }
            }
            
        }

    }
}
