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
                // generated parsers
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

                // hand-written parser(s)
                { typeof(Type), new TypeParser() }
            };
        }

        public static IParser GetParser(Type type)
        {
            IParser parser;
            if (parsers.TryGetValue(type, out parser))
            {
                return parser;
            }

            if (type.IsEnum)
            {
                return parsers[type] = CreateEnumParser(type);
            }

            string error = string.Format("There is no default parser for the type '#{0}'.", type);
            throw new ArgumentException(error);
        }

        public static IParser<T> GetParser<T>()
        {
            return (IParser<T>)GetParser(typeof(T));
        }

        static IParser CreateEnumParser(Type type)
        {
            Type blankType = typeof(EnumParser<>);
            Type genericType = blankType.MakeGenericType(type);
            return (IParser)Activator.CreateInstance(genericType);
        }
    }
}
