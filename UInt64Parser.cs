using System;

namespace GenericParsers
{
    sealed class UInt64Parser : Parser<ulong>
    {
        public override ulong Parse(string input)
        {
            return ulong.Parse(input);
        }

        public override bool TryParse(string input, out ulong result)
        {
            return ulong.TryParse(input, out result);
        }
    }
}
