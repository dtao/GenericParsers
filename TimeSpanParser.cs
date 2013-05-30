using System;

namespace GenericParsers
{
    sealed class TimeSpanParser : Parser<TimeSpan>
    {
        public override TimeSpan Parse(string input)
        {
            return TimeSpan.Parse(input);
        }

        public override bool TryParse(string input, out TimeSpan result)
        {
            return TimeSpan.TryParse(input, out result);
        }
    }
}
