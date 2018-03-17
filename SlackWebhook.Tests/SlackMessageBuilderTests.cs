using System;
using System.Linq;
using SlackWebhook.Enums;
using SlackWebhook.Exceptions;
using SlackWebhook.Messages;
using Xunit;

namespace SlackWebhook.Tests
{
    public class SlackMessageBuilderTests
    {
        private readonly ISlackMessageBuilder _builder;

        public SlackMessageBuilderTests()
        {
            _builder = new SlackMessageBuilder().WithText("Default Text");
        }

        [Fact]
        public void Should_Validate_Before_Building()
        {
            var exception = Assert.Throws<SlackMessageValidationException>(
                () => new SlackMessageBuilder().Build());

            Assert.Contains(exception.ValidationErrors, x => x.PropertyName == nameof(SlackMessage.Text));
        }

        [Fact]
        public void Should_Create_New_Messages_On_Each_Build()
        {
            var msg1 = _builder.Build();
            var msg2 = _builder.Build();

            msg1.Text = "foo";
            msg2.Text = "bar";

            Assert.NotEqual(msg1.Text, msg2.Text);
        }

        [Fact]
        public void Should_Set_Text_Without_Formatting()
        {
            var msg = _builder.WithText("*foo* & bar", false).Build();
            Assert.Equal("*foo* & bar", msg.Text);
            Assert.False(msg.EnableFormatting);
        }

        [Fact]
        public void Should_Set_Text_With_Formatting()
        {
            var msg = _builder.WithText("*foo* & bar").Build();
            Assert.Equal("*foo* &amp; bar", msg.Text);
            Assert.True(msg.EnableFormatting);
        }

        [Fact]
        public void Should_Require_Text_To_Be_Non_Empty()
        {
            Assert.Throws<ArgumentException>(() => _builder.WithText(""));
        }

        [Fact]
        public void Should_Set_Channel()
        {
            var msg = _builder.WithChannel("channel").Build();
            Assert.Equal("channel", msg.Channel);
        }

        [Fact]
        public void Should_Set_Username()
        {
            var msg = _builder.WithUsername("username").Build();
            Assert.Equal("username", msg.Username);
        }

        [Fact]
        public void Should_Require_Username_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => _builder.WithUsername(""));
        }

        [Fact]
        public void Should_Set_IconUrl()
        {
            var msg = _builder.WithIcon(IconType.Url, "url").Build();
            Assert.Equal("url", msg.IconUrl);
        }

        [Fact]
        public void Should_Set_IconEmoji()
        {
            var msg = _builder.WithIcon(IconType.Emoji, "smile").Build();
            Assert.Equal("smile", msg.IconEmoji);
        }

        [Fact]
        public void Should_Require_UrlOrEmoji_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => _builder.WithIcon(default, ""));
        }

        [Fact]
        public void Should_Add_Attachment()
        {
            var msg = _builder.WithAttachment(a => a.WithTitle("attachment title")).Build();
            Assert.NotEmpty(msg.Attachments);

            var attachment = msg.Attachments.SingleOrDefault();
            Assert.NotNull(attachment);
            Assert.Equal("attachment title", attachment.Title);
        }

        [Fact]
        public void Should_Require_ConfigureAttachment_Not_Null()
        {
            Assert.Throws<ArgumentNullException>(() => _builder.WithAttachment(null));
        }
    }
}
