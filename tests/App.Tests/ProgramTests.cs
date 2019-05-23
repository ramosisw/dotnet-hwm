using System;
using Xunit;

namespace App.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("Hello World!")]
        public void GetMessage(string expected)
        {
            var actual = Program.GetMessage();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        public void RunWithExit0(int expected)
        {
            var actual = Program.Main(null);
            Assert.Equal(expected, actual);
        }
    }
}
