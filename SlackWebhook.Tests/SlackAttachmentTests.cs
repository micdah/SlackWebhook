using SlackWebhook.Messages;
using Xunit;
using System.Drawing;
using System;

namespace SlackWebhook.Tests
{
    public class SlackAttachmentTests
    {
        [Fact]
        public void Should_Require_Title()
        {
            Assert.False(new SlackAttachment
            {
                Title = ""
            }.Validate());
        }

        [Fact]
        public void Should_Set_Color_String_From_Drawing_Color()
        {
            var attachment = new SlackAttachment();

            attachment.SetColor(Color.Red);
            Assert.Equal("#FF0000", attachment.Color);

            attachment.SetColor(Color.Green);
            Assert.Equal("#008000", attachment.Color);

            attachment.SetColor(Color.Blue);
            Assert.Equal("#0000FF", attachment.Color);

            attachment.SetColor(Color.White);
            Assert.Equal("#FFFFFF", attachment.Color);
        }

        [Fact]
        public void Should_Set_Epoch_Timestamp_Based_On_DateTimeOffset()
        {
            var attachment = new SlackAttachment();

            attachment.SetTimestamp(new DateTimeOffset(1970, 1, 1, 5, 0, 0, TimeSpan.FromHours(2)));
            Assert.Equal(60 * 60 * 3, attachment.Timestamp);
        }
    }
}
