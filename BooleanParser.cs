using System;

namespace GenericParsers
{
    sealed class BooleanParser : Parser<bool>
    {
        public override bool Parse(string input)
        {
            return bool.Parse(input);
        }

        public override bool TryParse(string input, out bool result)
        {
            return bool.TryParse(input, out result);
        }
    }
}
