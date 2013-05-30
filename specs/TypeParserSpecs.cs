using System;

using NUnit.Framework;

namespace GenericParsers.Specs
{
    [TestFixture]
    public class TypeParserSpecs
    {
        IParser<Type> parser;

        [SetUp]
        public void Before()
        {
            parser = Parser<Type>.Default;
        }

        [Test]
        public void ParseThrowsExceptionOnBadInput()
        {
            TestDelegate attempt = () =>
            {
                Parser<Type>.Default.Parse("System.Ninja");
            };

            Assert.That(attempt, Throws.Exception);
        }

        [Test]
        public void ParseParsesValidTypeNames()
        {
            Type type = parser.Parse("System.Random");
            Assert.That(type, Is.EqualTo(typeof(Random)));
        }

        [Test]
        public void TryParseWorksForValidInput()
        {
            string input = "System.Random";
            Type result;

            Assert.That(parser.TryParse(input, out result), Is.True);
            Assert.That(result, Is.EqualTo(typeof(Random)));
        }

        [Test]
        public void TryParseReturnsFalseForInvalidInput()
        {
            string input = "System.Ninja";
            Type result;

            Assert.That(parser.TryParse(input, out result), Is.False);
        }
    }
}
