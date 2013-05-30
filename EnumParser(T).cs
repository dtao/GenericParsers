using System;

namespace GenericParsers
{
    public class EnumParser<T> : Parser<T> where T : struct
    {
        public override T Parse(string input)
        {
            return (T)Enum.Parse(typeof(T), input);
        }

        public override bool TryParse(string input, out T result)
        {
            return Enum.TryParse(input, out result);
        }
    }
}
