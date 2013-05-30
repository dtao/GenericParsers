using System;

namespace GenericParsers
{
    sealed class DateTimeParser : Parser<DateTime>
    {
        public override DateTime Parse(string input)
        {
            return DateTime.Parse(input);
        }

        public override bool TryParse(string input, out DateTime result)
        {
            return DateTime.TryParse(input, out result);
        }
    }
}
