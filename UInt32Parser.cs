using System;

namespace GenericParsers
{
    sealed class UInt32Parser : Parser<uint>
    {
        public override uint Parse(string input)
        {
            return uint.Parse(input);
        }

        public override bool TryParse(string input, out uint result)
        {
            return uint.TryParse(input, out result);
        }
    }
}
