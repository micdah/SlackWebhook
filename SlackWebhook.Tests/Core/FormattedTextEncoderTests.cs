using SlackWebhook.Core;
using Xunit;

namespace SlackWebhook.Tests.Core
{
    public class FormattedTextEncoderTests
    {
        private readonly FormattedTextEncoder _encoder;

        public FormattedTextEncoderTests()
        {
            _encoder = new FormattedTextEncoder();
        }

        [Fact]
        public void Should_Encode_Amperasand()
        {
            Assert.Equal("foo &amp; bar", _encoder.Encode("foo & bar"));
        }

        [Fact]
        public void Should_Encode_Less_Than()
        {
            Assert.Equal("foo &lt; bar", _encoder.Encode("foo < bar"));
        }

        [Fact]
        public void Should_Encode_Greater_Than()
        {
            Assert.Equal("foo &gt; bar", _encoder.Encode("foo > bar"));
        }
    }
}
