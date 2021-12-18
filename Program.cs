using System;

namespace BT_AUTO_2021_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Course01(args);
            //Course02(args);
            //Course03(args);
            //ExOneSwitchCase(args);
            //ExOneIfElse(args);
            //ExTwo(args);
            //ExThreePalindrome(args);
            PrimeNoLessN(args);
        }




        static void Course01(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;
            const int MAX_NUMBER = 5;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere");
            Console.WriteLine(2 + 6);
            Console.WriteLine("6 + 2");

            int numberOfStudents = 5;
            int count;
            int a, b;
            a = numberOfStudents + 1;
            //a = a + b;
            a = a + numberOfStudents;
            short s = 5;
            ulong ul = 65;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudents;

            Console.WriteLine(typeof(int).IsPrimitive);


            bool myBoolean = false;

            char ch = 'd'; // '1' != 1

            string myString = "Ana are mere si pere";
            string result = a + " si struguri";

            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberDouble * a);
            Console.WriteLine(numberFloat * a);
            Console.WriteLine(numberFloat / a);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);


            int x = 2;
            x += 5; // x = x + 5;
                    // x++ <=> x = x +1;
                    // ++x <=> x = x +1;
            Console.WriteLine(x++);
            Console.WriteLine((x < a) || (x == a));

            int number = 100;
            Console.WriteLine("Number tested is" + number);

            if (number >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Odd number!");
            }

            if (number <= 40 && number >= 0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failed!");
                }
                else
                {
                    Console.WriteLine("Student passed!");
                }
            }
            else
            {
                Console.WriteLine("Grade is invalid!");
            }

            // One line if / else
            String message = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(message);
            //Console.WriteLine((number % 2 == 0) ? "Even" : "Odd"));

            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            if (number == 3)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wendnesday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number <= 1 || number > 7)
            {
                Console.WriteLine("Sorry not a valid day!");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturnday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                    //default:
                    {
                        Console.WriteLine("Not a valid day!");
                    }
            }

            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is:" + counter);
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }
            while (counter <= MAX_NUMBER);

            for (counter = 0; counter <= MAX_NUMBER; counter++)
            {
                Console.WriteLine("Current number is: {0}", counter);
            }

            foreach (string argumnet in args)
            {
                Console.WriteLine("The argument is: {0}", argumnet);
            }

            int year1 = 2015;
            int febDays = 28;

            if (year1 % 4 == 0)
            {
                if (year1 % 100 == 0 && year1 % 400 != 0)
                {
                    febDays = 29;
                }
                if (year1 % 100 == 0 && year1 % 400 == 0)
                {
                    febDays = 28;
                }
                if (year1 % 100 != 0)
                {
                    febDays = 29;
                }
            }
            else
            {
                febDays = 28;
            }
            Console.WriteLine("February has {0} days", febDays);

            if ((year1 % 4 == 0 && year1 % 100 == 0 && year1 % 400 != 0) || (year1 % 4 == 0 && year1 % 100 != 0))
            {
                febDays = 29;
            }

            //int year = 1900;
            foreach (string yr in args)
            {
                //int febDays = 28;
                int year = int.Parse(yr);
                if (year < 1900 || year > 2016)
                {
                    Console.WriteLine("Year is out of valid bound (1900 - 2016)");
                }

                if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    febDays = 29;
                }

                Console.WriteLine("February has {0} days for year {1}", febDays, year);
            }
        }

        static void Course02(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2; // c2 will be null!!!
            c1.SetRadius(10);
            double area = c1.GetArea();
            // double area = c1.GetArea():
            Console.WriteLine(c1.GetArea());
            Circle c3 = new Circle();
            c3.SetRadius(5);
            Console.WriteLine(c3.GetArea());
            c3.PrintCircle();

            foreach (string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(p));
                c.PrintCircle();
                Square s = new Square();
                s.PrintSquare();
            }

            Person p1 = new Person();
            p1.SetName("Alex");
            p1.SetSex('m');
            p1.eat();
            p1.Run();
            p1.eat();
            p1.PrintPerson();

        }
        
        static void Course03(string[] args)
        {
            ComputerConversion(args);

            CurrencyCalculator(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, '1', "17d");
            string s2 = ConcatenateStrings(args);
            Console.WriteLine(s2);
            //  Random rnd = new Random();
            //  GuessNumber(rnd.Next(1, 1000));
        }

        static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }
        static Shape GetShape(int x, int y, double a, char t, String s)
        {
            Console.WriteLine(x);
            return new Shape();
        }

        static string ConcatenateStrings(string[] args)
        {
            string returnString = "";

            foreach (string s in args)
            {
                returnString += s; // returnString = returnString + 2;
            }
            return returnString;
        }
        static public void ComputerConversion(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("The application receives only 3 parameters: amount, currenci, exchange rate");
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                // double amount = double.Parse(args[0]);
                //string currency = args[1];
                // double conversionRate = double.Parse(args[2]);
                //Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate);

                CurrencyCalculator(Double.Parse(args[0]), args[1], double.Parse(args[2]));
            }
        }
        static void CurrencyCalculator(double amount, string currency, double conversionRate)
        {
            Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate);
        }

        static int TestValue(int testVal, int target)
        {
            if (testVal < target)
            {
                Console.WriteLine("Number to be guessed is higher!");
                return -1;
            }
            if (testVal > target)
            {
                Console.WriteLine("Number to be guessed is lower!");
                return 1;
            }
            Console.WriteLine("Bazinga! This is the number!");
            return 0;
        }

        static void GuessNumber(int n)
        {
            int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Number chose is {0}", currentNumber);
            }
            while (TestValue(currentNumber, n) != 0);

        }


        public static void ExOneSwitchCase(string[] args)
        {

            if (args.Length == 3)
            {

                float a = float.Parse(args[0]);

                float b = float.Parse(args[2]);

                string op = args[1];

                // implement calculator logic here


                switch (op)
                {
                    case "+":
                        float result = a + b;
                        Console.WriteLine("Result is: {0} ", result);
                        break;
                }

                switch (op)
                {
                    case "-":
                        float result = a - b;
                        Console.WriteLine("Result is: {0}", result);
                        break;
                }

                switch (op)
                {
                    case "*":
                        float result = a * b;
                        Console.WriteLine("Result is: {0}", result);
                        break;
                }

                switch (op)
                {
                    case "/":

                        float result = a / b;
                        Console.WriteLine("Result is: {0}", result);
                        break;
                }
                /*default:
                        {
                            Console.WriteLine("Please introduce one of followin operators: +, -, / or *");
                            break;
                        }
                */
            }
            else
            {

                Console.WriteLine("3 args are needed!");

            }
        }

        public static void ExOneIfElse(string[] args)
            {

                if (args.Length == 3)
                {

                    float a = float.Parse(args[0]);

                    float b = float.Parse(args[2]);

                    string op = args[1];

                    float result = 0;
                // implement calculator logic here
                    if (op == "+")
                    {
                        result = a + b;
                    Console.WriteLine("Result is: {0}", result);
                    }
                    if (op == "-")
                        {
                        result = a - b;
                        Console.WriteLine("Result is: {0}", result);
                        }
                    if (op == "*")
                    {
                    result = a * b;
                    Console.WriteLine("Result is: {0}", result);
                    }
                    if (op == "/")
                    {
                    result = a / b;
                    Console.WriteLine("Result is: {0}", result);
                    }
                    if (op != "+" || op !="-" || op !="*" || op != "/")
                    {
                    Console.WriteLine("Please introduce one of followin operators: +, -, / or *");
                    }

                    
                }
                else
                {

                    Console.WriteLine("3 args are needed!");

                }
            }

        public static void ExTwo(string[] args)
        {
            int j = 100;
            int i = 0, result = 0;
            //int sum = 0;

            for (i = 0; i <= j; i++)
            {
                //i = i++;
                result = result + i;
            }
            Console.WriteLine("The sum of first {0} numbers is: {1}", j, result);
        }

        static bool CheckPalindrome(string number)
        {
            int len = number.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (number[i] != number[len - i - 1])
                    return false;
            }
            return true;
        }
        public static void ExThreePalindrome(string[] no)
        {
            string nr = "9911231321199";

            if (CheckPalindrome(nr) == true)
                Console.Write("The text {0} is a palindrome", nr);
            else
                Console.Write("The text {0} is not a palindrome", nr);
        }


        static bool PrimeNo(int n)
        {
            if (n < 1)
                return false;

            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        static void ShowPrime(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (PrimeNo(i))
                    Console.Write(i + " ");
            }
        }
        public static void PrimeNoLessN(string[] args)
        {
            int n = 23;
            Console.WriteLine("The prime numbers lower than [0] are: ", n); ShowPrime(n);
        }
    }
}
