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
            //PrimeNoLessN(args);
            //Course04();
            //Course05();
            //Course06();
            HomeWorkVolumesAndLibrary();



        }

       
     static void HomeWorkVolumesAndLibrary()
        {
            
            CubeVolume(10, 10, 10);
            CubeVolume(10);
            SphereVolume(5);
            SphereVolume(10,5);
            PyramidVolume(50, 50);
            PyramidVolume(50);
            CylinderVolume(5, 10);
            CylinderVolume(10);
            TorusVolume(5, 5.5);
            TorusVolume(5.5, 5);

            Book book1 = new Book();
            book1.SetbookName("Twenty Thousand Leagues Under the Seas");
            book1.SetYear(1871);
            book1.SetPrice(50);
            book1.PrintBook();
            book1.PrintBook2();
           
            Author Author1 = new Author();
            Author1.SetName("Jules Verne");
            Author1.PrintAuthor();

            Library Lib1 = new Library();
            //Lib1.PrintLibrary();
            //book1.Library();

        }



        public static void SphereVolume(double radius)
        {
            double SphereVol = 4 / 3 * Math.PI *Math .Pow (radius,3);
            Console.WriteLine("Sphere with radius of {0} have volume is: {1}",radius, + SphereVol);
        }
        
        public static void SphereVolume(float diameter, float radius)
        {
            double SphereVol = 4 / 3 * Math.PI * Math.Pow(diameter/2, 3);

            Console.WriteLine("Sphere with diameter of {0} and radius of {1} has volume of: {2}", diameter, radius, SphereVol);

        }
        public static void CubeVolume(int l, int L, int h)
        {
            int  CubeVol = l * L * h; 
            Console.WriteLine("Cube vol is {0}", CubeVol);
        }

        public static void CubeVolume(double  l)
        {
            double  CubeVol = Math.Pow(l, 3);
            Console.WriteLine("Cube vol is {0}", CubeVol);
        }

        public static void TorusVolume(int radius, double Radius)
        {
            double torusvol = 2 * Math.PI * Radius * Math.Pow(radius, 2);
            Console.WriteLine("Torus volume is {0} ", torusvol);
        }

        public static void TorusVolume(double radius, int Radius)
        {
            double torusvol = 2 * Math.PI * Radius * Math.Pow(radius, 2);
            Console.WriteLine("Torus volume is {0} ", torusvol);
        }

        public static void CylinderVolume(double radius, double height)
        {
            double cylvol = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine("Cylinder volume is {0}", cylvol);
        }

        public static void CylinderVolume(float l)
        {
            float cylvol = (float)(Math.PI * Math.Pow(l, 2) * l);
            Console.WriteLine("Cylinder volume is {0}", cylvol);
        }
        public static void PyramidVolume(double basearea, double height)
        {
            double pyramidevol = 0.33 * basearea * height;
            Console.WriteLine("Pyramide volume is {0}", pyramidevol);
        }

        public static void PyramidVolume(int l)
        {
            double pyramidevol = 0.33 * l * (l / 2);
            Console.WriteLine("Pyramide volume is {0} ", pyramidevol);
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
            //Console.WriteLine(c1.GetArea());
            c1.PrintCircle();
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
                s.SetSide(double.Parse(p));
                Rectangle r = new Rectangle();
                r.SetSize(double.Parse(p), double.Parse(p));
                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();

            }

            Person p1 = new Person();
            p1.SetName("Alex");
            p1.SetSex('m');
            p1.eat();
            p1.Run();
            p1.eat();
            p1.PrintPerson();

            //Person p1 = new Person();
            p1.SetName("Alex");
            p1.SetSex('m');
            p1.eat();
            p1.Run();
            p1.eat();
            p1.PrintPerson();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();

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



        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape2(5, 3);
            Console.WriteLine();
            DrawShapeOutline(8, 11);
            DrawShapeOutilne2(13, 22);
            Console.WriteLine();
            DrawShapeCorners(10, 13);
            Console.WriteLine();
            DrawShapeCorners2(10, 13);

            Circle c1 = new Circle(); // instantiate c1 with default(no params) constructor
            Circle c2 = new Circle(10);  // instatiate c2 with constructor having 1 double parameter
            c1.PrintCircle();
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Alex", 'm', new string[] { " Romanian " }, false, new DateTime());

            Rectangle r1 = new Rectangle(2, 7);
            r1.PrintRectangle();

            Square s1 = new Square(6);
            s1.PrintSquare();

            StructExample se = new StructExample();
            StructExample.MyStruct myStruct = new StructExample.MyStruct();
            myStruct.Assign(100, "abc");
            Console.WriteLine(myStruct.ComputeSum());

            StructExample.Rectangle3d r2 = new StructExample.Rectangle3d();
            r2.Assign(2, 5, 8);
            Console.WriteLine(r2.GetVolume());
        }

        public static void DrawFullShape(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line{
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public static void DrawFullShape2(int width, int height)
        {
            string s = "";
            for (int i = 0; i < width; i++) // this print a single line
            {
                s += "*";
            }

            for (int j = 0; j < height; j++)
            {
                Console.WriteLine(s);
            }
        }

        public static void DrawShapeOutline(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line{
                {
                    if (j == 0 || j == height - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DrawShapeOutilne2(int width, int height)
        {
            string s = "";
            string s1 = "";
            for (int i = 0; i < width; i++) // this print a single line
            {
                s += "*";
                if (i == 0 || i == width - 1)
                {
                    s1 += "*";
                }
                else
                {
                    s1 += " ";
                }

            }

            for (int j = 0; j < height; j++)
            {
                if(j==0 || j == height - 1)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine(s1);
                }
                
            }
        }

        public static void DrawShapeCorners(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line{
                {
                    //if ((j == 0 && i == 0) || (j == 0 && i == width - 1) || (j == height - 1 && i == 0) || (j == height - 1 && i == width - 1))
                    if(j==0 || j==height-1)
                    {
                        if(i==0|| i == width - 1)
                            {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                            
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        public static void DrawShapeCorners2(int width, int height)
        {
            string s = "";
            string s1 = "";
            for (int i = 0; i < width; i++) // this print a single line
            {
                s += " ";
                if (i == 0 || i == width - 1)
                {
                    s1 += "*";
                }
                else
                {
                    s1 += " ";
                }

            }

            for (int j = 0; j < height; j++)
            {
                if (j == 0 || j == height - 1)
                {
                    Console.WriteLine(s1);
                }
                else
                {
                    Console.WriteLine(s);
                }

            }
        }

        static void Course05()
        {
            DrawShapeOutline(2, 3);
            DrawShapeOutline(5);
            DrawShapeCorners(6);
            DrawFullShape(7);

            Circle c = new Circle(4);
            Object o = new Object();
            c.Draw();

            Triangle t1 = new Triangle(5, 7, 9);
            t1.Draw();
            Square s1 = new Square(5);
            Rectangle r1= new Rectangle(2,7);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(c.ToString());
            Console.WriteLine(s1.ToString());
            Console.WriteLine(t1.ToString());


            //Teacher teacher1 = new Teacher("Programming", "UPB", 2000, "Gigel Programatoru'", 'm');
            //teacher1.PrintTeacher();

            Student student1 = new Student("An 1", true, true, "Andreea a", 'f');
            //Student1.PrintStudent();

        }
        public static void DrawShapeOutline(int l)
        {
            DrawShapeOutline(l, l);
        }

        public static void DrawShapeCorners(int l)
        {
            DrawShapeCorners(l, l);
        }

        public static void DrawFullShape(int l)
        {
            DrawFullShape(l, l);
        }

        private static void Course06()
        {
            Car c1 = new Car(true, 20, 90);
            Car c2 = new Car(false, 0, -90);
            c1.Start();
            c1.Accelerate();
            c1.TurnLeft();
            c1.TurnRight();

            Console.WriteLine(Car.ConvertHPToKw(150));

            Rectangle r1 = new Rectangle(3, 4);
            Console.WriteLine("Area is {0} Perimeter is {1} Diagonal is {2}", r1.GetArea(), r1.GetPerimeter(), r1.GetDiagonal());
            r1.PrintRectangle();

            r1.SetLenght(10);
            r1.PrintRectangle();

            c2.Start();
            c2.GearUp();
            c2.Accelerate(20);
            c2.Steer(20);
            c2.Accelerate(10);
            c2.TurnLeft();
            c2.GearUp();
            c2.Accelerate();
            c2.PrintCar();

            c2.CarBrand = "Name";
        }


    }

}

