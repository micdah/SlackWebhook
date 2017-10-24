using System.Collections.Generic;
using SlackWebhook.Exceptions;
using SlackWebhook.Messages;
using Xunit;

namespace SlackWebhook.Tests.Messages
{
    public class SlackAttachmentFieldTests
    {
        private ICollection<ValidationError> _errors;

        [Fact]
        public void Should_Require_Title()
        {
            Assert.False(new SlackAttachmentField
            {
                Title = ""
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackAttachmentField) &&
                                          x.PropertyName == nameof(SlackAttachmentField.Title));
        }

        [Fact]
        public void Should_Require_Value()
        {
            Assert.False(new SlackAttachmentField
            {
                Title = "foo"
            }.Validate(ref _errors));

            Assert.Contains(_errors, x => x.TypeName == nameof(SlackAttachmentField) &&
                                          x.PropertyName == nameof(SlackAttachmentField.Value));
        }

        [Fact]
        public void Should_Validate()
        {
            Assert.True(new SlackAttachmentField
            {
                Title = "foo",
                Value = "bar"
            }.Validate(ref _errors));

            Assert.Empty(_errors);
        }
    }
}
