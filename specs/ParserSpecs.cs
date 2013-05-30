using System;

using GenericParsers;
using NUnit.Framework;

namespace GenericParsers.Specs
{
    [TestFixture]
    public class ParserSpecs
    {
        [Test]
        public void ProvidesDefaultParsersForBasicTypes()
        {
            string input = "123";
            int result;

            Parser<int>.Default.TryParse(input, out result);
            Assert.That(result, Is.EqualTo(123));
        }

        [Test]
        public void AlwaysReturnsTheSameInstanceForEachType()
        {
            IParser<double> first = Parser<double>.Default;
            IParser<double> second = Parser<double>.Default;

            Assert.That(first, Is.EqualTo(second));
        }

        [Test]
        public void ProvidesParserForEnumTypes()
        {
            string input = "Local";
            DateTimeKind result;

            Parser<DateTimeKind>.Default.TryParse(input, out result);
            Assert.That(result, Is.EqualTo(DateTimeKind.Local));
        }
    }
}
