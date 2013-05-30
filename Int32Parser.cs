using System;

namespace GenericParsers
{
    sealed class Int32Parser : Parser<int>
    {
        public override int Parse(string input)
        {
            return int.Parse(input);
        }

        public override bool TryParse(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}
