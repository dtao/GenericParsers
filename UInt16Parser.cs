using System;

namespace GenericParsers
{
    sealed class UInt16Parser : Parser<ushort>
    {
        public override ushort Parse(string input)
        {
            return ushort.Parse(input);
        }

        public override bool TryParse(string input, out ushort result)
        {
            return ushort.TryParse(input, out result);
        }
    }
}
