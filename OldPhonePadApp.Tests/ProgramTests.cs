using Xunit;
using OldPhonePadApp;   // Nombre del namespace de tu app

namespace OldPhonePadApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("2#", "A")]
        [InlineData("222#", "C")]
        [InlineData("9999#", "Z")]
        [InlineData("234#", "ADG")]
        [InlineData("22 2#", "BA")]
        [InlineData("23*3#", "AD")]
        [InlineData("55555#", "?")]
        [InlineData("*2#", "A")]
        [InlineData("#", "")]
        [InlineData("1#", "")]
        [InlineData("1*2#", "A")]
        [InlineData("9#9#", "W")]
        public void OldPhonePad_VariousInputs_ReturnsExpected(string input, string expected)
        {
            // Act
            string result = Program.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}