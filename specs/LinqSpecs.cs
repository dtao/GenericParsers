using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace GenericParsers.Specs
{
    [TestFixture]
    public class LinqSpecs
    {
        [Test]
        public void ParseAllParsesAllValidInputs()
        {
            var values = new[] { "1", "2", "3" }.ParseAll<int>();
            Assert.That(values, Is.EquivalentTo(new[] { 1, 2, 3 }));
        }

        [Test]
        public void ParseAllThrowsExceptionOnInvalidInput()
        {
            TestDelegate attempt = () =>
            {
                new List<int>(new[] { "1", "2", "foo" }.ParseAll<int>());
            };

            Assert.That(attempt, Throws.Exception);
        }

        [Test]
        public void TryParseAllParsesAllValidInputs()
        {
            var values = new[] { "1", "2", "foo" }.TryParseAll<int>();
            Assert.That(values, Is.EquivalentTo(new[] { 1, 2 }));
        }
    }
}
