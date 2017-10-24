using System.Collections.Generic;
using SlackWebhook.Exceptions;
using SlackWebhook.Messages;
using Xunit;

namespace SlackWebhook.Tests.Messages
{
    public class SlackMessageTests
    {
        private ICollection<ValidationError> _errors;

        [Fact]
        public void Should_Require_Text_To_Be_Set()
        {
            Assert.False(new SlackMessage
            {
                Text = ""
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackMessage) &&
                                          x.PropertyName == nameof(SlackMessage.Text));
        }

        [Fact]
        public void Shoul_Only_Allow_Setting_IconUrl_Or_IconEmoji() 
        {
            Assert.False(new SlackMessage
            {
                Text = "foo",
                IconUrl = "foo",
                IconEmoji = "bar"
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackMessage) &&
                                          x.PropertyName == nameof(SlackMessage.IconUrl));
            Assert.Contains(_errors, x => x.TypeName == nameof(SlackMessage) &&
                                          x.PropertyName == nameof(SlackMessage.IconEmoji));
        }

        [Fact]
        public void Should_Validate_Attachments_If_Present()
        {
            Assert.False(new SlackMessage
            {
                Text = "foo",
                Attachments = new List<SlackAttachment>
                {
                    new SlackAttachment
                    {
                        Title = ""
                    }
                }
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackMessage) &&
                                          x.PropertyName == nameof(SlackMessage.Attachments));
        }
        
        [Fact]
        public void Should_Validate()
        {
            Assert.True(new SlackMessage
            {
                Text = "foo"
            }.Validate(ref _errors));

            Assert.Empty(_errors);
        }
    }
}
