using System;

using NUnit.Framework;

namespace GenericParsers.Specs
{
    [TestFixture]
    public class ParserSpecs
    {
        [Test]
        public void ProvidesDefaultParsersForBasicTypes()
        {
            Assert.That(Parser<int>.Default, Is.InstanceOf(typeof(IParser<int>)));
        }

        [Test]
        public void ProvidesNonGenericInterface()
        {
            IParser parser = Parser.GetParser(typeof(bool));
            Assert.That(parser, Is.InstanceOf(typeof(IParser<bool>)));
        }

        [Test]
        public void AlwaysReturnsTheSameInstanceForEachType()
        {
            IParser<double> first = Parser<double>.Default;
            IParser<double> second = Parser<double>.Default;

            Assert.That(first, Is.EqualTo(second));
        }

        [Test]
        public void ProvidesParsersForEnumTypes()
        {
            Assert.That(Parser<DateTimeKind>.Default, Is.InstanceOf(typeof(EnumParser<DateTimeKind>)));
        }

        [Test]
        public void ProvidesAParserForTypeType()
        {
            Assert.That(Parser<Type>.Default, Is.InstanceOf(typeof(TypeParser)));
        }
    }
}
