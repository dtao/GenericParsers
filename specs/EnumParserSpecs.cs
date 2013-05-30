using System;

using NUnit.Framework;

namespace GenericParsers.Specs
{
    [TestFixture]
    public class EnumParserSpecs
    {
        IParser<DateTimeKind> parser;

        [SetUp]
        public void Before()
        {
            parser = Parser<DateTimeKind>.Default;
        }

        [Test]
        public void ParseParsesValidInput()
        {
            DateTimeKind value = parser.Parse("Local");
            Assert.That(value, Is.EqualTo(DateTimeKind.Local));
        }

        [Test]
        public void ParseThrowsExceptionOnInvalidInput()
        {
            TestDelegate attempt = () =>
            {
                parser.Parse("foo");
            };

            Assert.That(attempt, Throws.Exception);
        }

        [Test]
        public void TryParseWorksForValidInput()
        {
            string input = "Local";
            DateTimeKind result;

            Assert.That(parser.TryParse(input, out result), Is.True);
            Assert.That(result, Is.EqualTo(DateTimeKind.Local));
        }
    }
}
