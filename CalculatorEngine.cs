using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorEngine
    {
        public double Add(double firstNum, double secondNum) => firstNum + secondNum;
        public double Subtract(double firstNum, double secondNum) => firstNum - secondNum;
        public double Multiply(double firstNum, double secondNum) => firstNum * secondNum;
        public double Divide(double firstNum, double secondNum) => firstNum / secondNum;

        public double Calculate(string operand, double firstNum, double secondNum)
        {
            return operand.ToLower() switch
            {
                "+" => Add(firstNum, secondNum),
                "-" => Subtract(firstNum, secondNum),
                "*" => Multiply(firstNum, secondNum),
                "/" => Divide(firstNum, secondNum),
                _ => throw new ArgumentException("Unknown Operand", $"{operand}")
            };
        }
    }
}
