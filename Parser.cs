using System;
using System.Collections.Generic;

namespace GenericParsers
{
    public static class Parser
    {
        static readonly Dictionary<Type, IParser> parsers;

        static Parser()
        {
            parsers = new Dictionary<Type, IParser>
            {
                { typeof(Boolean), new BooleanParser() },
                { typeof(Byte), new ByteParser() },
                { typeof(Int16), new Int16Parser() },
                { typeof(UInt16), new UInt16Parser() },
                { typeof(Int32), new Int32Parser() },
                { typeof(UInt32), new UInt32Parser() },
                { typeof(Int64), new Int64Parser() },
                { typeof(UInt64), new UInt64Parser() },
                { typeof(Single), new SingleParser() },
                { typeof(Double), new DoubleParser() },
                { typeof(Decimal), new DecimalParser() },
                { typeof(DateTime), new DateTimeParser() },
                { typeof(TimeSpan), new TimeSpanParser() },
            };
        }

        public static IParser GetParser(Type type)
        {
            IParser parser;
            if (parsers.TryGetValue(typeof(T), out parser))
            {
                return parser;
            }

            string error = string.Format("There is no default parser for the type '#{0}'.", typeof(T));
            throw new ArgumentException(error);
        }

        public static IParser<T> GetParser<T>()
        {
            return (IParser<T>)GetParser(typeof(T));
        }
    }
}
