using System;
using Rdf.Vocabularies;
using Xunit;

namespace Rdf.Vocabularies.Tests
{
    public class LvontTest
    {
        [Fact]
        public void BaseUri()
        {
            Assert.Equal("http://lexvo.org/ontology#", Lvont.BaseUri);
        }
    }
}