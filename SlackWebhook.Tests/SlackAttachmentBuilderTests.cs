using System;
using SlackWebhook.Messages;
using Xunit;

namespace SlackWebhook.Tests
{
    public class SlackAttachmentBuilderTests
    {
        [Fact]
        public void Should_Not_Validate_Before_Building()
        {
            new SlackAttachmentBuilder().Build();
        }

        [Fact]
        public void Should_Create_New_Attachment_On_Each_Build()
        {
            var att1 = Build();
            var att2 = Build();

            att1.Title = "foo";
            att2.Title = "bar";

            Assert.NotEqual(att1.Title, att2.Title);
        }

        [Fact]
        public void Should_Set_Title()
        {
            var att = Build(b => b.WithTitle("title"));
            Assert.Equal("title", att.Title);
        }

        [Fact]
        public void Should_Require_Title_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithTitle("")));
        }

        [Fact]
        public void Should_Set_Text_Without_Formatting()
        {
            var att = Build(b => b.WithText("foo & bar", false));
            Assert.Equal("foo & bar", att.Text);
            Assert.DoesNotContain(att.EnableFormatting, x => x == SlackAttachment.FormattingText);
        }

        [Fact]
        public void Should_Set_Text_With_Formatting()
        {
            var att = Build(b => b.WithText("foo & bar"));
            Assert.Equal("foo &amp; bar", att.Text);
            Assert.Contains(att.EnableFormatting, x => x == SlackAttachment.FormattingText);
        }

        [Fact]
        public void Should_Require_Text_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithText("")));
        }

        private SlackAttachment Build(Action<ISlackAttachmentBuilder> configureBuilder = null)
        {
            var builder = new SlackAttachmentBuilder();
            builder.WithTitle("Default Title");
            configureBuilder?.Invoke(builder);
            return builder.Build();
        }
    }
}