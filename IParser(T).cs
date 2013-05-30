using System;

namespace GenericParsers
{
    public interface IParser<T>
    {
        T Parse(string input);
        bool TryParse(string input, out T result);
    }
}
