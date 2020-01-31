using System;
using Xunit;
using Xunit.Abstractions;

namespace AppTests
{
    public class Class1
    {
        private readonly ITestOutputHelper _output;

        public Class1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TheTest()
        {
            _output.WriteLine(typeof(App21.App21).FullName);
            _output.WriteLine(typeof(App22.App22).FullName);
            _output.WriteLine(typeof(App31.App31).FullName);
            Assert.True(true);
        }
    }
}
