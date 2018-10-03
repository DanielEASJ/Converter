using System;

namespace ConverterDLL
{
    public class Converter
    {
        public double PrintValue;

        public void ToGram(double inputValue)
        {
            PrintValue = inputValue * 28.34952;
        }

        public void ToOunces(double inputValue)
        {
            PrintValue = inputValue / 28.34952;
        }
    }
}
