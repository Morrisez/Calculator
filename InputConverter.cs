using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string input)
        {
            double convertedNumber = 0;

            if (!double.TryParse(input, out convertedNumber))
                throw new ArgumentException("Expected a number");
            
            return convertedNumber;
        }
    }
}
