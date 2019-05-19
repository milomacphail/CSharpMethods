﻿using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            bool result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }


            static void UseParams()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }

        static void UsePoints()
            {
                try
                {
                    var point = new Point(10, 20);
                    point.Move(null);
                    Console.WriteLine("Point is at ({0},{1}", point.X, point.Y);


                    point.Move(100, 200);
                    Console.WriteLine("Point is at ({0},{1}", point.X, point.Y);

                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occured.");
                }
            }
    }
}
