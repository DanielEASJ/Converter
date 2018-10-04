using System;

namespace ConverterDLL
{
    public class Converter
    {
        public double printValue;

        // read only reSharper propperty
        public double PrintValue => printValue;

        public const double factor = 28.34952;

        public void ToGram(double inputValue)
        {
            printValue = inputValue * factor;
        }

        public void ToOunces(double inputValue)
        {
            printValue = inputValue / factor;
        }
    }
}
