using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_WhenNumberNotDivisible()
        {
            var number = 1; 
            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Determine_FooWhenNumberDividedby3()
        {
            var foo = 3;
            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(foo);
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void Determine_FooWhenNumberDividedby5()
        {
            var bar = 5;
            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(bar);
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void Determine_FooWhenNumberDividedby7()
        {
            var qix = 7;
            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(qix);
            Assert.Equal("Qix", result);
        }
    }
}