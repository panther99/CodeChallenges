using System;
using Xunit;
using Library;

namespace Tests
{
    public class StringPeelerServiceTests
    {
        private readonly StringPeelerService _stringPeelerService;

        public StringPeelerServiceTests()
        {
            _stringPeelerService = new StringPeelerService();
        }

        [Fact]
        public void RemoveFirstAndLastLetter_InputIsOur_ShouldReturnU()
        {
            var result = _stringPeelerService.RemoveFirstAndLastLetter("our");

            Assert.Equal("u", result);
        }

        [Fact]
        public void RemoveFirstAndLastLetter_InputIsBanana_ShouldReturnAnan()
        {
            var result = _stringPeelerService.RemoveFirstAndLastLetter("banana");

            Assert.Equal("anan", result);
        }

        [Fact]
        public void RemoveFirstAndLastLetter_InputIsTree_ShouldReturnRe()
        {
            var result = _stringPeelerService.RemoveFirstAndLastLetter("   tree  ");

            Assert.Equal("re", result);
        }

        [Fact]
        public void RemoveFirstAndLastLetter_InputIsYo_ShouldReturnNull()
        {
            var result = _stringPeelerService.RemoveFirstAndLastLetter("yo");

            Assert.Equal(null, result);
        }
    }
}
