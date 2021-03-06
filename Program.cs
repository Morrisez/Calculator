﻿using System;

namespace Calculator
{
    public class Program
    {
        static InputConverter inputConverter;
        static Calculator calculator;
        
        public static void Main(string[] args)
        {
            inputConverter = new InputConverter();
            calculator = new Calculator();

            GUI();
        }

        public static void GUI()
        {
            try
            {
                ConsoleKeyInfo quitKey;
                Console.WriteLine("Welcome to the calculator! Press [ESC] to quit the program at any time! \n");
                
                do
                {
                    Console.Write("Enter first number: ");
                    double firstNum = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double secondNum = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.Write("Enter desired operation (+, -, *, /): ");
                    string operand = Console.ReadLine();

                    double result = calculator.Calculate(operand, firstNum, secondNum);

                    Console.WriteLine(result);

                    quitKey = Console.ReadKey();
                } while (quitKey.Key != ConsoleKey.Escape);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
