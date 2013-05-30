using System;

namespace GenericParsers
{
    sealed class DoubleParser : Parser<double>
    {
        public override double Parse(string input)
        {
            return double.Parse(input);
        }

        public override bool TryParse(string input, out double result)
        {
            return double.TryParse(input, out result);
        }
    }
}
