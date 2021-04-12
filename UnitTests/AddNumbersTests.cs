using System;
using Sample;
using Xunit;

namespace UnitTests
{
    public class AddNumbersTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 2, 7)]
        public void ShouldAddNumbers(int first, int second, int result)
        {
            SampleAddNumbers sampleAddNumbers = new SampleAddNumbers();
            Assert.Equal(result, sampleAddNumbers.AddNumbers(first, second));
        }
    }
}
