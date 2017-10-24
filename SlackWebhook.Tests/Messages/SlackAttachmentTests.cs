using System;
using System.Collections.Generic;
using System.Drawing;
using SlackWebhook.Exceptions;
using SlackWebhook.Messages;
using Xunit;

namespace SlackWebhook.Tests.Messages
{
    public class SlackAttachmentTests
    {
        private ICollection<ValidationError> _errors;

        [Fact]
        public void Should_Require_Title()
        {
            Assert.False(new SlackAttachment
            {
                Title = ""
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackAttachment) &&
                                          x.PropertyName == nameof(SlackAttachment.Title));
        }

        [Fact]
        public void Should_Require_Timestamp_To_Be_Positive()
        {
            Assert.False(new SlackAttachment
            {
                Title = "foo",
                Timestamp = -1
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackAttachment) &&
                                          x.PropertyName == nameof(SlackAttachment.Timestamp));
        }

        [Fact]
        public void Should_Validate_Fields_If_Present()
        {
            Assert.False(new SlackAttachment
            {
                Title = "foo",
                Fields = new List<SlackAttachmentField>
                {
                    new SlackAttachmentField()
                }
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackAttachment) &&
                                          x.PropertyName == nameof(SlackAttachment.Fields));
        }

        [Fact]
        public void Should_Validate()
        {
            Assert.True(new SlackAttachment
            {
                Title = "foo"
            }.Validate(ref _errors));

            Assert.Empty(_errors);
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
