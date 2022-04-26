using Xunit;
using zywave_data.Extensions;

namespace zywave_test.ExtensionMethods
{
    public class StringExtensionsTests
    {
        [Fact]
        public void CaseInsensitiveContains_ReturnsTrue_LowerCase()
        {
            var text = "This is a sample string";
            Assert.True(StringExtensions.CaseInsensitiveContains(text, "sample"));
        }

        [Fact]
        public void CaseInsensitiveContains_ReturnsTrue_UpperCase()
        {
            var text = "This is a sample string";
            Assert.True(StringExtensions.CaseInsensitiveContains(text, "Sample"));
        }

        [Fact]
        public void CaseInsensitiveContains_ReturnsFalse_UpperCase()
        {
            var text = "This is a sample string";
            Assert.False(StringExtensions.CaseInsensitiveContains(text, "Testing"));
        }

        [Fact]
        public void CaseInsensitiveContains_ReturnsFalse_LowerCase()
        {
            var text = "This is a sample string";
            Assert.False(StringExtensions.CaseInsensitiveContains(text, "testing"));
        }

        [Fact]
        public void CaseInsensitiveContains_ReturnsFalse_SpecialCharacters()
        {
            var text = "This is a sample string";
            Assert.False(StringExtensions.CaseInsensitiveContains(text, "$%@#^*"));
        }

        [Fact]
        public void RemoveSpecialChars()
        {
            var text = "This is another &* ok sample string with special characters";
            var expected = "This is another  ok sample string with special characters";

            var output = StringExtensions.RemoveSpecialChars(text);

            Assert.Equal(expected, output);
        }
    }
}