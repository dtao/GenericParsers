using System;

namespace GenericParsers
{
    public class EnumParser<T> : IParser<T> where T : struct
    {
        public T Parse(string input)
        {
            return (T)Enum.Parse(typeof(T), input);
        }

        public bool TryParse(string input, out T result)
        {
            return Enum.TryParse(input, out result);
        }
    }
}
