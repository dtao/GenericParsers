using System;

namespace GenericParsers
{
    public abstract class Parser<T> : IParser, IParser<T>
    {
        private static IParser<T> instance;

        public static IParser<T> Default
        {
            get
            {
                if (instance == null)
                {
                    instance = Parser.GetParser<T>();
                }
                return instance;
            }
        }

        public abstract T Parse(string input);
        public abstract bool TryParse(string input, out T result);

        object IParser.Parse(string input)
        {
            return (object)Parse(input);
        }

        bool IParser.TryParse(string input, out object result)
        {
            T typedResult;
            if (TryParse(input, out typedResult))
            {
                result = typedResult;
                return true;
            }

            result = null;
            return false;
        }
    }
}
