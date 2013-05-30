using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericParsers.Linq
{
    public static class Enumerable
    {
        public static IEnumerable<T> ParseAll<T>(this IEnumerable<string> values)
        {
            IParser<T> parser = Parser<T>.Default;
            return values.Select(str => parser.Parse(str));
        }

        public static IEnumerable<T> TryParseAll<T>(this IEnumerable<string> values)
        {
            IParser<T> parser = Parser<T>.Default;

            foreach (string value in values)
            {
                T result;
                if (parser.TryParse(value, out result))
                {
                    yield return result;
                }
            }
        }
    }
}
