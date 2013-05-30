using System;

namespace GenericParsers
{
    sealed class Int16Parser : Parser<short>
    {
        public override short Parse(string input)
        {
            return short.Parse(input);
        }

        public override bool TryParse(string input, out short result)
        {
            return short.TryParse(input, out result);
        }
    }
}
