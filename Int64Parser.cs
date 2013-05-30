using System;

namespace GenericParsers
{
    sealed class Int64Parser : Parser<long>
    {
        public override long Parse(string input)
        {
            return long.Parse(input);
        }

        public override bool TryParse(string input, out long result)
        {
            return long.TryParse(input, out result);
        }
    }
}
