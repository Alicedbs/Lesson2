using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Age();
            //InformationAboutRectangle();
            //InformationAboutTriangle();
            //InformationAboutSquare();
            //task3();
            //task4();


            //HOMEWORK

            //name();
            //sum();
            //Operations();
            //multiplication();
            //multiplicationtable();
            //average();
            //range();
            //currentDate();
            //yearOfBirth();
            //numbersOutput();

            Console.ReadKey();

        }

        static void Age()
        {
            Console.Write("how old are you ?");
            int age = Convert.ToInt32(Console.ReadLine());
            age = age + 10;
            Console.WriteLine("In 10 years you will be: " + age);
            Console.ReadKey();
        }

        /*private static void Myage()
        {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            try
            {
                int age1 = int.Parse(age);

                int age10 = age1 + 10;
                Console.WriteLine("Your age in 10 years will be " + age10);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private static void MeAfterTen2()
        {
            Console.Write("PLease enter your age:");
            string ageAsString = Console.ReadLine();
            int.TryParse(ageAsString, out int ageAsInt);

            if(parseResult == true)
            {
                int ageAfterTen = ageAsInt + 10;
                Console.WriteLine($"your age after 10 years will be {ageAfterTen} years");
            }
            else
            {
                Console.WriteLine($"Error!!!");
            }
        }*/

        static void InformationAboutRectangle()
        {
            Console.WriteLine("Enter the side A:");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the side B:");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangle = " + sideA * sideB);

            Console.WriteLine("Perimeter of the rectangle = " + ((sideA * 2) + (sideB * 2)));

            Console.WriteLine("Volume of the rectangle = " + sideA * sideB * height);

        }

        static void InformationAboutTriangle()
        {
            Console.WriteLine("Enter the SideA ");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the side B:");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Side C");
            int sideC = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height : ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the triangle = " + ((sideA * height) / 2));

            Console.WriteLine("Perimeter of the rectangle = " + (sideA + sideB + sideC));
        }

        static void InformationAboutSquare()
        {
            Console.WriteLine("Enter the Side ");
            int side = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the square = " + side * 2);

            Console.WriteLine("Perimeter of the square = " + side * 4);

        }

        static void task3()
        {
            DateTime date = DateTime.Now;

            Console.Write("Current date : ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write("Current time");
            Console.WriteLine(date.ToShortTimeString());

            Console.Write("Date after 10 years:");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.Write("Please enter a period:");
            int period = int.Parse(Console.ReadLine());
            Console.Write($"Date after {period} years:");
            Console.WriteLine(date.AddYears(period).ToShortDateString());
            
        }

        static void task4()
        {
            Console.Write("Current age:");
            int currentage = int.Parse(Console.ReadLine());

            Console.Write("Future age:");
            int Futureage = int.Parse(Console.ReadLine());

            Console.Write("Bday month:");
            int bdaymonth = int.Parse(Console.ReadLine());

            Console.Write("Bday day:");
            int bdayday = int.Parse(Console.ReadLine());

            int ageDifference = Futureage - currentage;
            int futureYear = DateTime.Now.Year + ageDifference;
            var futureBday = new DateTime(futureYear, bdayday, bdayday);
            Console.WriteLine($"Your future bday will be : {futureBday}");
        }


            //HOMEWORK

        static void name()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello \n" + name);
        }

        static void sum()
        {
            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of the sum is : " + (number1 + number2));
        }

        static void Operations()
        {
            int a = -1 + 4 * 6;
            int b = (35 + 5) % 7;
            int c = 14 + -4 * 6 / 11;
            int d = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("The result of -1 + 4 * 6 is : " + a);
            Console.WriteLine("The result of (35 + 5) % 7 is : " + b);
            Console.WriteLine("The result of  14 + -4 * 6 / 11 is : " + c);
            Console.WriteLine("The result of 2 + 15 / 6 * 1 - 7 % 2 is : " + d);
        }

        static void multiplication()
        {
            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a thrid number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of the multiplication is : " + (number1 * number2 * number3));
        }

        static void multiplicationtable()
        {
            Console.WriteLine("enter a number between 1 and 10:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i * number);
            }
        }

        static void average()
        {
            Console.WriteLine("Enter a number:");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            double number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a thrid number:");
            double number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a fourth number:");
            double number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The average of the four numbers is : " + ((number1 + number2 + number3 + number4) / 4));
        }

        static void range()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 200 && number >= 100) 
            {
                Console.WriteLine("The number is between 100 and 200");
            }
            else
            {
                Console.WriteLine("The number is not between 100 and 200");
            }
        }

        static void currentDate()
        {
            DateTime date = DateTime.Now;
            Console.Write("Current date : ");
            Console.WriteLine(date.ToShortDateString());
        }

        static void yearOfBirth()
        {
            Console.WriteLine("What's you age?");
            int number = Convert.ToInt32(Console.ReadLine());

            int bdayYear = DateTime.Now.Year - number;
            Console.WriteLine($"Your birthday year is : {bdayYear}");

        }

        static void numbersOutput()
        {
            Console.WriteLine("Enter a number x :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number y :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a thrid number z:");
            int z = Convert.ToInt32(Console.ReadLine());

            int a = (x + y) * z;
            int b = x*y + y*z;
            
            Console.WriteLine("the result of (x + y) * z is :" + a);
            Console.WriteLine("the result of x*y + y*z is :" + b);
        }
    }
}
