using System;

namespace GenericParsers
{
    sealed class SingleParser : Parser<float>
    {
        public override float Parse(string input)
        {
            return float.Parse(input);
        }

        public override bool TryParse(string input, out float result)
        {
            return float.TryParse(input, out result);
        }
    }
}
