using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1 Lesson
            //Console.WriteLine("Hello World!");





            //3.2 Lesson
            /*string num;
            Console.WriteLine("Write a number: ");
            num = Console.ReadLine();

            if (Int32.Parse(num) % 3 == 0)
            {
                Console.WriteLine("The number divided into three.");
            }
            else if (Int32.Parse(num) % 4 == 0)
            {
                Console.WriteLine("The number divided into four.");
            }
            else if (Int32.Parse(num) % 9 == 0)
            {
                Console.WriteLine("The number divided into nine.");
            }*/





            //3.3 Lesson
            /*string value, into;
            int kelvin = 274;
            double res = 0.0;
            Console.WriteLine("Write a temperature value: ");
            value = Console.ReadLine();

            Console.WriteLine("From Celsius to Fahrenheit(F) or Fahrenheit to Celsius(C)?");
            into = Console.ReadLine();

            if (into == "F")
            {
                res = (Int32.Parse(value) * kelvin) * 1.8;
            }else if (into == "C")
            {
                res = (Double.Parse(value) / 1.8) / 274;
            }
            Console.WriteLine("The result: " + res.ToString());*/





            //3.4 Lesson
            /*string weight, height;
            double bodyMI, heightD = 0.0;
            Console.WriteLine("Your weight: ");
            weight = Console.ReadLine();
            Console.WriteLine("Your height: ");
            height = Console.ReadLine();

            heightD = double.Parse(height) / 100.0;
            bodyMI = int.Parse(weight) / Math.Pow(heightD, 2);

            if (bodyMI < 16)
            {
                Console.Write("Súlyos soványság");
            }else if (bodyMI == 16 || bodyMI <= 16.99)
            {
                Console.WriteLine("Mérsékelt soványság");
            }else if (bodyMI == 17 || bodyMI <= 18.49)
            {
                Console.WriteLine("Enyhe soványság");
            }else if (bodyMI == 18.5 || bodyMI <= 24.99)
            {
                Console.WriteLine("Normális testsúly");
            }else if (bodyMI == 25 || bodyMI <= 29.99)
            {
                Console.WriteLine("Túlsúly");
            }else if (bodyMI == 30 || bodyMI <= 34.99)
            {
                Console.WriteLine("I. fokú elhízás");
            }else if (bodyMI == 35 || bodyMI <= 39.99)
            {
                Console.WriteLine("II. fokú elhízás");
            }else if (bodyMI >= 40)
            {
                Console.WriteLine("III. fokú (súlyos) elhízás");
            }*/





            //3.5 Lesson
            /*int temp;
            Console.WriteLine("The water temperature: ");
            temp = int.Parse(Console.ReadLine());

            if (temp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's ice!");
            }else if (temp > 0 && temp < 100)
            {
                Console.WriteLine("It's water!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It's steam!");
            }*/





            //3.6 Lesson
            /*double x1, x2, y1, y2, res = 0.0;
            Console.WriteLine("First point X coord: ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("First point Y coord: ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Second point X coord: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Second point Y coord: ");
            y2 = double.Parse(Console.ReadLine());

            res = Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("Two point distance: " + res);*/





            //3.7 Lesson
            /*int score;
            Console.WriteLine("Test score: ");
            score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("The score is wrong!");
            }else if (score < 50)
            {
                Console.WriteLine("The result: 1");
            }else if (score >= 50 && score < 65)
            {
                Console.WriteLine("The result: 2");
            }else if (score >= 65 && score < 80)
            {
                Console.WriteLine("The result: 3");
            }else if (score >= 80 && score < 90)
            {
                Console.WriteLine("The result: 4");
            }else if (score >= 90)
            {
                Console.WriteLine("The result: 5");
            }*/





            //3.8 Lesson
            /*Console.WriteLine("Wheat weight[t]: ");
            int t = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int multiplier = rnd.Next(11) + 5;
            int quantity = t * multiplier;
            Console.WriteLine("Expected quantity: " + quantity);

            if (multiplier >= 5 && multiplier <= 8)
            {
                Console.WriteLine("Below average");
            }else if (multiplier >= 9 && multiplier <= 12)
            {
                Console.WriteLine("Average");
            }else if (multiplier >= 13 && multiplier <= 15)
            {
                Console.WriteLine("Above average");
            }*/
        }
    }
}
