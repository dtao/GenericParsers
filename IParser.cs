using System;

namespace GenericParsers
{
    public interface IParser
    {
        object Parse(string input);
        bool TryParse(string input, out object result);
    }
}
