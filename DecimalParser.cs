using System;

namespace GenericParsers
{
    sealed class DecimalParser : Parser<decimal>
    {
        public override decimal Parse(string input)
        {
            return decimal.Parse(input);
        }

        public override bool TryParse(string input, out decimal result)
        {
            return decimal.TryParse(input, out result);
        }
    }
}
