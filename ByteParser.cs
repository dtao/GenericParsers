using System;

namespace GenericParsers
{
    sealed class ByteParser : Parser<byte>
    {
        public override byte Parse(string input)
        {
            return byte.Parse(input);
        }

        public override bool TryParse(string input, out byte result)
        {
            return byte.TryParse(input, out result);
        }
    }
}
