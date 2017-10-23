using SlackWebhook.Messages;
using Xunit;

namespace SlackWebhook.Tests
{
    public class SlackMessageTests
    {
        [Fact]
        public void Should_Require_Text_To_Be_Set()
        {
            Assert.False(new SlackMessage
            {
                Text = ""
            }.Validate());
        }

        [Fact]
        public void Shoul_Only_Allow_Setting_IconUrl_Or_IconEmoji() 
        {
            Assert.False(new SlackMessage
            {
                IconUrl = "foo",
                IconEmoji = "bar"
            }.Validate());
        }

        [Fact]
        public void Should_Encode_Text_If_Formatting_Enabled()
        {
            var msg = new SlackMessage
            {
                Text = "Foo & Bar"
            };
            Assert.Equal("Foo &amp; Bar", msg.Text);
        }
    }
}
