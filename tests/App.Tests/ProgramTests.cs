using System;
using System.Runtime.InteropServices;
using Xunit;

namespace App.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("Hello World")]
        public void GetMessage(string expected)
        {
            var actual = Program.GetMessage();
            Assert.Contains(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        public void RunWithExit0(int expected)
        {
            var actual = Program.Main(null);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetArchitecture()
        {
            var expected = RuntimeInformation.ProcessArchitecture.ToString();
            var actual = Program.GetArchitecture();
            Assert.Contains(expected, actual);
        }
    }
}
