using System;
using Xunit;
using Library;

namespace Tests
{
    public class VowelCounterServiceTests
    {
        private readonly VowelCounterService _vowelCounterService;

        public VowelCounterServiceTests()
        {
            _vowelCounterService = new VowelCounterService();
        }

        [Fact]
        public void CountVowels_InputIsMarx_ShouldReturn1()
        {
            var result = _vowelCounterService.CountVowels("Marx");

            Assert.Equal(1, result);
        }

        [Fact]
        public void CountVowels_InputIsPlato_ShouldReturn2()
        {
            var result = _vowelCounterService.CountVowels("Hegel");

            Assert.Equal(2, result);
        }

        [Fact]
        public void CountVowels_InputIsSpinoza_ShouldReturn3()
        {
            var result = _vowelCounterService.CountVowels("Spinoza");

            Assert.Equal(3, result);
        }

        [Fact]
        public void CountVowels_InputIsRousseau_ShouldReturn5()
        {
            var result = _vowelCounterService.CountVowels("Rousseau");

            Assert.Equal(5, result);
        }
    }
}
