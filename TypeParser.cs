using System;

namespace GenericParsers
{
    public class TypeParser : Parser<Type>
    {
        public override Type Parse(string input)
        {
            return Type.GetType(input, true);
        }

        public override bool TryParse(string input, out Type result)
        {
            result = Type.GetType(input, false);
            return result != null;
        }
    }
}
