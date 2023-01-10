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
                bool valid_string = false;
                while (valid_string == false)
                {
                    Console.Clear();
                    Console.WriteLine("What action do you want to perform? \n" +
                        "options: \n" +
                        "\n" +
                        "Basics: \n" +
                        "----------------------------------- \n" +
                        "'CTF': Celsius To Fahrenheit. \n" +
                        "'AAM': Add And Multiply. \n" +
                        "'EO' Elementary Operations. \n" +
                        "'IRTS' Is Result The Same? \n" +
                        "'MO' Modulo Operations. \n" +
                        "'TCO' The Cupe Of. \n" +
                        "'STN' Swap Two Numbers.\n" +
                        "\n" +
                        "Conditional Statements: \n" +
                        "----------------------------------- \n" +
                        "'AV' Absolute value. \n" +
                        "'DB' Divisible By 2 or 3. \n" +
                        "'ICOUL' If Consists Cf Uppercase Letters. \n" +
                        "'IGTTO' If Greater Than Third One. \n" +
                        "'INIE' If Number Is Even. \n" +
                        "'ISA' If Sorted Ascending. \n" +
                        "'PNOZ' Positive, Negative Or Zero \n" +
                        "'IYIL' If Year Is Leap");
                    mode = Console.ReadLine();
                    mode = mode.ToUpper();
                    if (new[] { "CTF", "AAM", "EO", "IRTS", "MO", "TCO", "STN", "AV", "DB", "ICOUL" , "IGTTO", "INIE", "ISA", "PNOZ", "IYIL" }.Contains(mode))
                    {
                        valid_string = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Command didn't mach anything.");
                    }
                }
                ChooseAction(mode);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                //basic methods
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
                    Console.WriteLine(ab * double.Parse(c));
                }
                void CTF()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Celsius To Fahrenheit. \n Type first number: ");
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
                //Conditional methods
                void AV()
                {
                    Console.Clear();
                    double a = GetInputAndConvertToDouble("You chose Absolute value. \n Type a number: ");
                    Console.WriteLine("The Absolute value of {1} is {0}", Math.Abs(a), a);
                }
                void DB()
                {
                    Console.Clear();
                    double a = GetInputAndConvertToDouble("You chose Divisible by 2 or 3. \n Type first number: ");
                    double b = GetInputAndConvertToDouble("Type second number: ");
                    if ((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))
                    {
                        Console.WriteLine("Both numbers can be devided by 2 or 3. Result: {0}", a * b);
                    }
                    else
                    {
                        Console.WriteLine("One or both numbers can't be devided by 2 or 3. Result: {0}", a + b);
                    }
                }
                void ICOUL()
                {
                    Console.Clear();
                    bool valid = false;
                    string str = "";
                    while (!valid)
                    {
                        Console.WriteLine("You chose If consists of uppercase letters. \n Type a word thats only 3 character long : ");
                        str = Console.ReadLine();
                        if (str.Length == 3)
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("invalid value. Try again.");
                        }
                        bool isUpper = Char.IsUpper(str, 0) && Char.IsUpper(str, 1) && Char.IsUpper(str, 2);
                        Console.WriteLine("It is {0} that all characters is uppercase", isUpper);
                    }                  
                } 
                void IGTTO() {
                    Console.Clear();
                    double a = GetInputAndConvertToDouble("You chose If greater than third one. \n Type first number: ");
                    double b = GetInputAndConvertToDouble("Type second number: ");
                    double c = GetInputAndConvertToDouble("Type third number: ");
                    if(a+b < c)
                    {
                        Console.WriteLine("{0}+{1} ({2}) is less or same as {3}", a, b, a+b, c );
                    }
                    else if(a+b == c) {
                        Console.WriteLine("{0}+{1} ({2}) is the same as {3}", a, b, a + b, c);
                        }
                    else
                    {
                        Console.WriteLine("{0}+{1} ({2}) is more then {3}", a, b, a + b, c);
                    }
                }
                void INIE() {
                    Console.Clear();
                    double a = GetInputAndConvertToDouble("You chose Is even? \n Type a number: ");
                    if(a % 2 == 0)
                    {
                        Console.WriteLine("{0} is even.",a);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not even.", a);
                    }
                }
                void ISA()
                {
                    Console.Clear();
                    double a = GetInputAndConvertToDouble("You chose If sorted ascending. \n Type first number: ");
                    double b = GetInputAndConvertToDouble("Type second number: ");
                    double c = GetInputAndConvertToDouble("Type third number: ");
                    if (a<=b && b<=c) {
                        Console.WriteLine("The list is sorted after value.{0}, {1}, {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("The list is not sorted after value. {0}, {1}, {2}", a, b, c);
                    }
                }
                void PNOZ() {
                    Console.Clear();
                    double a = GetInputAndConvertToDouble("You chose Positive or negative or zero. \n Type a number: ");
                    if (a > 0)
                    {
                        Console.WriteLine("{a} is positive.");
                    }
                    else if (a<0)
                    {
                        Console.WriteLine("{a} is negative.");
                    }
                    else {
                        Console.WriteLine("{0} is zero.", a);
                    }
                }
                void IYIL() {
                    Console.Clear();
                    int a = GetInputAndConvertToInt("You chose If year is leap. \n Type a Year: ");
                    if (a%4 == 0)
                    {
                        Console.WriteLine("Year {0} is leap.", a);
                    }
                    else
                    {
                        Console.WriteLine("Year {0} is not leap.", a);
                    }
                }
                //error checking
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
                            Console.WriteLine("Error: could not convert {0} to int", input_value);
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
                //Openig menu
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
                        case "AV":
                            AV();
                            break;
                        case "DB":
                            DB();
                            break;
                        case "ICOUL":
                            ICOUL();
                            break;
                        case "IGTTO":
                            IGTTO();
                            break;
                        case "INIE":
                            INIE();
                            break;
                        case "ISA":
                            ISA();
                            break;
                        case "PNOZ":
                            PNOZ();
                            break;
                        case "IYIL":
                            IYIL();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
