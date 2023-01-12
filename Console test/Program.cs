using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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
                        "'IYIL' If Year Is Leap \n" +
                        "\n" +
                        "Loops: \n" +
                        "'MT' Multiplication table \n" +
                        "'TBN' The biggest number \n" +
                        "'TNTEO' Two 7s next to each other \n" +
                        "'TIA' Three increasing adjacent \n"
+                       "'SOE' Sieve of Eratosthenes \n" +
                        "'ESM' Extract string M \n" +
                        "'FSOLM' Full sequence of letters M \n" +
                        "'SA' Sum and average \n" +
                        "'DT' Draw triangle \n" +
                        "'TPO' To the power of \n" +
                         "\n" +
                        "String: \n" +
                        "'AD' Add separator. \n" +
                        "'IP' Is palindrome? \n" +
                        "'LOS' Length of string. \n" +
                        "'SIRO' String in reverse order. \n"+
                        "'NOW' Number of words. \n"+
                        "'RWO' Reverse word order. \n"+
                        "'HMO' How Many Occurrences? \n"+
                        "'SCD' Sort characters adscending. \n" +
                        "'CS' Compress string."
                        );
                    mode = Console.ReadLine();

                    mode = mode.ToUpper();
                    if (new[] { "AD","IP","LOS","SIRO","NOW","RWO","HMO","CSD","CS", "CTF", "AAM", "EO", "IRTS", "MO", "TCO", "STN", "AV", "DB", "ICOUL" , "IGTTO", "INIE", "ISA", "PNOZ", "TIA", "IYIL", "MT", "TBN", "TNTEO", "SOE", "ESM", "FSOLM", "SA", "DT", "TPO" }.Contains(mode))
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

                    double a = GetInputAndConvertToDouble("You chose add and multyply \n Type first number: ");

                    double b = GetInputAndConvertToDouble("Type second number: ");
                    
                    double c = GetInputAndConvertToDouble("Type third number: ");

                    double ab = a + b;
                    Console.WriteLine(ab * c);
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
                //loops

                void MT() {
                    Console.Clear();
                    Console.WriteLine("You chose Multiplication table.");

                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    for(int i = 0; i < 10; i++)
                    {
                        int index = 0;
                        foreach(int j in numbers)
                        {
                            Console.Write(j*(i+1));
                            Console.Write(", ");
                            index++;
                        }
                        Console.Write("\n");
                    }
                }
                void TBN() {
                    Console.Clear();
                    Console.WriteLine("You chose The biggest number.");

                    int[] numbers = { 1, 5, 2, 3, 8, 6, 7, 9, 4, 10 };
                    int biggestNumber = 0;
                    foreach(int i in numbers)
                    {
                        if(i>biggestNumber)
                        {
                            biggestNumber= i;
                        }
                    }
                    Console.WriteLine("Biggest number of [1, 5, 2, 3, 8, 6, 7, 9, 4, 10] is {0}", biggestNumber);
                }
                void TNTEO() {

                    Console.Clear();
                    Console.WriteLine("You chose Two 7s next to each other.");

                    int[] numbers = { 7, 7, 2, 3, 7, 7, 4, 9, 7, 7 };
                    int index = 0;
                    int numberOf7sNextToEachOther = 0;
                    foreach(int i in numbers)
                    {
                       
                        //if at last index, stop
                        if (index == numbers.Length - 1)
                        {
                            break;
                        } 
                        else
                        {
                            if(i == numbers[index + 1])
                            {
                                numberOf7sNextToEachOther++;
                            }
                        }
                        index++;
                    }
                    Console.Write("[");
                    foreach(int i in numbers)
                    {
                        Console.Write(i+", ");
                    }
                    Console.Write("] \n");
                    Console.WriteLine("The number 7 appers next to each another {0} times", numberOf7sNextToEachOther);
                }
                void TIA()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Three increasing adjacent.");
                    
                    int[] numbers = { 7, 7, 2, 3, 7, 8, 2, 9, 7, 7 };
                    int index = 0;
                    Console.Write("[");
                    foreach (int i in numbers)
                    {
                        Console.Write(i + ", ");
                    }
                    Console.Write("] \n");
                    bool isAdjacent = false;
                    foreach (int i in numbers)
                    {
                        //if at last index, stop
                        if (index == numbers.Length - 3)
                        {
                            break;
                        }
                        else
                        {
                            if (numbers[index+1] == numbers[index] + 1 && (numbers[index + 2] == numbers[index] + 1))
                            {
                                isAdjacent = true;
                            }
                        }
                        index++;
                    }
                    if (isAdjacent == true)
                    {
                        Console.WriteLine("True. There are 3 adjacent numbers");
                    }
                    else
                    {
                        Console.WriteLine("False. There are not 3 adjacent numbers");
                    }
                }
                void SOE() {
                    Console.Clear();
                    Console.WriteLine("You chose Sieve of Eratosthenes.");
                    int a = GetInputAndConvertToInt("Type number: ");
                    for(int i = 2; i <= a; i++) {
                        if(i % 3 == 1 && i % 2 == 1)
                        {
                            Console.Write(i+", ");
                            Console.Write("\n");
                        }
                    }
                }
                  
                void ESM() {
                    Console.Clear();
                    Console.WriteLine("You chose Extract string M.");
                    string input = Console.ReadLine();
                    int first = input.IndexOf("##") + 2;
                    int second = input.IndexOf("##", first);

                    if (second - first == 0)
                    {
                        Console.WriteLine("empty string");
                    }

                    else 
                    {
                        Console.WriteLine(input.Substring(first, second - first));
                    }

                }
                void FSOLM() {
                Console.Clear();
                    Console.WriteLine("You chose Full sequence of letters M.");
                    string input = Console.ReadLine();
                    if (!(input[0] >= input[1]))
                    {
                        string alphabet_between = "";

                    for (int i = input[0]; i <= input[1]; i++)
                    {
                        alphabet_between += Convert.ToString(Convert.ToChar(i));
                    }

                    Console.WriteLine( alphabet_between);
                    }

                    

                }
                void SA() { 
                    Console.Clear();
                    int a = GetInputAndConvertToInt("You chose Sum and average. \nType first number: ");
                    int b = GetInputAndConvertToInt("Type second number: ");
                    int[] list= {a,b};
                    double average = list.Average();
                    Console.WriteLine("average: {0}, sum: {1}", average, a + b);
                }
                void DT() {
                    Console.Clear();
                    Console.WriteLine("You chose Draw triangle.");
                    Console.WriteLine("*");

                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 1; j != i + 3; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                }
                void TPO() {
                Console.Clear();
                    int a = GetInputAndConvertToInt("You chose The Power Of. \nType first number: ");
                    int b = GetInputAndConvertToInt("Type second number: ");
                    int i = 1;
                    while (i < b)
                    {
                        a = a * a;
                        i++;
                    }
                    Console.WriteLine(a);
                }
                void AD()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Add separator. \nType something: ");
                    string a = Console.ReadLine();
                    Console.WriteLine("Type seperator: ");
                    string b = Console.ReadLine();
                    string newString = "";
                    if (a.Length > 0)
                    {
                        for(int i = 0; i<a.Length; i++)
                        {
                            if (i != a.Length - 1)
                            {
                                newString += a[i] + b;
                            }
                            else
                            {
                                newString += a[i];
                            }
                        }
                    }
                    Console.WriteLine(newString);
                }
                void IP()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Is palindrome. \nType something: ");
                    string a = Console.ReadLine();
                    bool b = false;
                    if(a.SequenceEqual(a.Reverse()))
                    { b= true; }
                    Console.WriteLine("It is {1} that {0} is palindrome", a, b);
                }
                void LOS()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Length og string. \nType something: ");
                    string a = Console.ReadLine();
                    int counter = 0;
                    foreach(char i in a)
                    {
                        counter++;
                    }
                    Console.WriteLine("Length of {0} is {1}", a, counter);
                }
                void SIRO()
                {
                    Console.Clear();
                    Console.WriteLine("You chose string in reverse order. \nType something: ");
                    string a = Console.ReadLine();

                   string b = String.Empty;
                    for (int i = a.Length - 1; i >= 0; i--)
                    {
                        b += a[i];
                    };

                    Console.WriteLine("Reverse: {0}", b);
                }
                void NOW()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Number of words. \nType something: ");
                    string a = Console.ReadLine();
                    int CountSpaces = 0;
                    foreach(char i in a)
                    {
                        if (i == ' ')
                        {
                            CountSpaces++;
                        }
                    }
                    Console.WriteLine("There are {0} words in {1}", CountSpaces + 1, a);
                }
                void RWO()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Revert words order. \nType something: ");
                    string a = Console.ReadLine();
                    string[] words = a.Split(' ');
                    string reverse = "";
                    for (int i = words.Length -1; i>=0; i--)
                    {
                        reverse += words[i] +" ";
                    }
                    Console.WriteLine(reverse);
                }
                void HMO()
                {
                    Console.Clear();
                    Console.WriteLine("You chose How many accurences? \nType something: ");
                    string a = Console.ReadLine();
                    Console.WriteLine("Type what accurences you want to find in the string: ");
                    string b = Console.ReadLine();

                    int count = Regex.Matches(a, b).Count;
                    Console.WriteLine("{0} appers in {1} {2} times.", b, a, count);
                }
                void CSD()
                {
                    Console.Clear();
                    Console.WriteLine("You chose  Sort characters adscending. \nType something: ");
                    string a = Console.ReadLine();
                    char[] chars = a.ToCharArray();
                    Array.Sort(chars);
                    string output = "";
                    foreach(char c in chars)
                    {
                        output += c;
                    }
                    Console.WriteLine("sorted: {0}", output);
                }
                void CS()
                {
                    Console.Clear();
                    Console.WriteLine("You chose Compress string. \nType something: ");
                    string str = Console.ReadLine();
                    var count = 0;
                    var last = str[0];
                    var newStr = string.Empty;

                    foreach (var s in str)
                    {
                        if (s == last)
                        {
                            count++;
                        }
                        else
                        {
                            newStr += last.ToString() + count;
                            last = s;
                            count = 1;
                        }
                    }
                    newStr += last.ToString() + count;
                    Console.WriteLine( newStr);
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
                        case "MT":
                            MT();
                            break;
                        case "TBN":
                            TBN();
                            break;
                        case "SOE":
                            SOE();
                            break;
                        case "ESM":
                            ESM();
                            break;
                        case "FSOLM":
                            FSOLM();
                            break;
                        case "SA":
                            SA();
                            break;
                        case "TNTEO":
                            TNTEO();
                            break;
                        case "DT":
                            DT();
                            break;
                        case "TPO":
                            TPO();
                            break;
                        case "TIA":
                            TIA();
                            break;
                        case "AD":
                            AD();
                            break;
                        case "IP":
                            IP();
                            break;
                        case "LOS":
                            LOS();
                            break;
                        case "SIRO":
                            SIRO();
                            break;
                        case "NOW":
                            NOW();
                            break;
                        case "RWO":
                            RWO();
                            break;
                        case "HMO":
                            HMO();
                            break;
                        case "CSD":
                            CSD();
                            break;
                        case "CS":
                            CS();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
