using System;

using NUnit.Framework;

namespace GenericParsers.Specs
{
    // Let this fixture be a representative for all of the so-called "basic" types.

    [TestFixture]
    public class Int32ParserSpecs
    {
        IParser<int> parser;

        [SetUp]
        public void Before()
        {
            parser = Parser<int>.Default;
        }

        [Test]
        public void ParseParsesValidInputSuccessfully()
        {
            int value = parser.Parse("123");
            Assert.That(value, Is.EqualTo(123));
        }

        [Test]
        public void ParseThrowsOnInvalidInput()
        {
            TestDelegate attempt = () =>
            {
                parser.Parse("foo");
            };

            Assert.That(attempt, Throws.Exception);
        }

        [Test]
        public void TryParseReturnsTrueForValidInput()
        {
            string input = "123";
            int result;
            Assert.That(parser.TryParse(input, out result), Is.True);
            Assert.That(result, Is.EqualTo(123));
        }

        [Test]
        public void TryParseReturnsFalseForInvalidInput()
        {
            string input = "foo";
            int result;
            Assert.That(parser.TryParse(input, out result), Is.False);
        }
    }
}
