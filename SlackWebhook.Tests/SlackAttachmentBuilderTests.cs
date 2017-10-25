using System;
using System.Drawing;
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
        public void Should_Set_Link()
        {
            var att = Build(b => b.WithLink("url"));
            Assert.Equal("url", att.TitleLink);
        }

        [Fact]
        public void Should_Require_Link_To_be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithLink("")));
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

        [Fact]
        public void Should_Set_PreText_Without_Formatting()
        {
            var att = Build(b => b.WithPreText("pre & text", false));
            Assert.Equal("pre & text", att.PreText);
            Assert.DoesNotContain(att.EnableFormatting, x => x == SlackAttachment.FormattingPretext);
        }

        [Fact]
        public void Should_Set_PreText_With_Formatting()
        {
            var att = Build(b => b.WithPreText("pre & text"));
            Assert.Equal("pre &amp; text", att.PreText);
            Assert.Contains(att.EnableFormatting, x => x == SlackAttachment.FormattingPretext);
        }

        [Fact]
        public void Should_Require_PreText_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithPreText("")));
        }

        [Fact]
        public void Should_Set_Fallback()
        {
            var att = Build(b => b.WithFallback("fallback text"));
            Assert.Equal("fallback text", att.Fallback);
        }

        [Fact]
        public void Should_Require_Fallback_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithFallback("")));
        }

        [Fact]
        public void Should_Set_Color_From_String_Name()
        {
            var att = Build(b => b.WithColor("good"));
            Assert.Equal("good", att.Color);
        }

        [Fact]
        public void Should_Set_Color_From_String_Hex()
        {
            var att = Build(b => b.WithColor("#FFffBB"));
            Assert.Equal("#FFffBB", att.Color);
        }

        [Fact]
        public void Should_Require_Color_String_To_Be_Either_Known_Name_Or_Hex_Format()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithColor("not-a-color")));
            Assert.Throws<ArgumentException>(() => Build(b => b.WithColor("#blah")));
            Assert.Throws<ArgumentException>(() => Build(b => b.WithColor("")));
            Assert.Throws<ArgumentException>(() => Build(b => b.WithColor("#GGffFF")));
        }

        [Fact]
        public void Should_Set_Color()
        {
            var att = Build(b => b.WithColor(Color.Green));
            Assert.Equal("#008000", att.Color);
        }

        [Fact]
        public void Should_Require_Color_To_Be_Empty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithColor(Color.Empty)));
        }

        [Fact]
        public void Should_Set_Author()
        {
            var att = Build(b => b.WithAuthor("author"));
            Assert.Equal("author", att.AuthorName);
        }

        [Fact]
        public void Should_Set_Author_And_Link()
        {
            var att = Build(b => b.WithAuthor("author", "link"));
            Assert.Equal("author", att.AuthorName);
            Assert.Equal("link", att.AuthorLink);
        }

        [Fact]
        public void Should_Set_Author_And_Icon()
        {
            var att = Build(b => b.WithAuthor("author", iconUrl:"icon"));
            Assert.Equal("author", att.AuthorName);
            Assert.Equal("icon", att.AuthorIcon);
        }

        [Fact]
        public void Should_Set_Author_Link_And_Icon()
        {
            var att = Build(b => b.WithAuthor("author", "link", "icon"));
            Assert.Equal("author", att.AuthorName);
            Assert.Equal("link", att.AuthorLink);
            Assert.Equal("icon", att.AuthorIcon);
        }

        [Fact]
        public void Should_Require_Author_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithAuthor("")));
        }

        [Fact]
        public void Should_Require_Author_Link_To_Not_Be_Empty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithAuthor("author", "")));
        }

        [Fact]
        public void Should_Require_Author_Icon_To_Not_Be_Empty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithAuthor("author", iconUrl:"")));
        }

        [Fact]
        public void Should_Set_Image()
        {
            var att = Build(b => b.WithImage("image-url"));
            Assert.Equal("image-url", att.ImageUrl);
        }

        [Fact]
        public void Should_Require_Image_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithImage("")));
        }

        [Fact]
        public void Should_Set_Thumbnail()
        {
            var att = Build(b => b.WithThumbnail("thumbnail-url"));
            Assert.Equal("thumbnail-url", att.ThumbnailUrl);
        }

        [Fact]
        public void Should_Require_Thumbnail_To_Be_NonEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithThumbnail("")));
        }

        [Fact]
        public void Should_Set_Footer()
        {
            var att = Build(b => b.WithFooter("footer"));
            Assert.Equal("footer", att.Footer);
        }

        [Fact]
        public void Should_Set_Footer_And_Icon()
        {
            var att = Build(b => b.WithFooter("footer", "icon-url"));
            Assert.Equal("footer", att.Footer);
            Assert.Equal("icon-url", att.FooterIcon);
        }

        [Fact]
        public void Should_Require_Footer()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithFooter("")));
        }

        [Fact]
        public void Should_Require_Footer_Icon_NotEmpty()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithFooter("footer", "")));
        }

        [Fact]
        public void Should_Set_Timestamp_From_DateTimeOffset()
        {
            var att = Build(b => b.WithTimestamp(new DateTimeOffset(1970, 1, 1, 5, 0, 0, TimeSpan.FromHours(2))));
            Assert.Equal(60 * 60 * 3, att.Timestamp);
        }

        [Fact]
        public void Should_Set_Timestamp_From_Int()
        {
            var att = Build(b => b.WithTimestamp(100));
            Assert.Equal(100, att.Timestamp);
        }

        [Fact]
        public void Should_Require_Timestamp_To_Be_After_Epoch()
        {
            Assert.Throws<ArgumentException>(() => Build(b => b.WithTimestamp(-1)));
            Assert.Throws<ArgumentException>(() => Build(b => b.WithTimestamp(new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.FromHours(0)).AddSeconds(-1))));
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