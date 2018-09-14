using SlackWebhook.Core;
using SlackWebhook.Enums;
using SlackWebhook.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SlackWebhook.Tests")]

namespace SlackWebhook
{
    /// <inheritdoc />
    public class SlackMessageBuilder : ISlackMessageBuilder
    {
        private static readonly FormattedTextEncoder Encoder = new FormattedTextEncoder();
        private readonly SlackMessage _template;

        /// <summary>
        /// Create new slack message builder
        /// </summary>
        public SlackMessageBuilder()
        {
            _template = new SlackMessage();
        }

        /// <inheritdoc />
        public SlackMessage Build()
        {
            _template.ThrowIfInvalid();
            return _template.Clone();
        }

        /// <inheritdoc />
        public ISlackMessageBuilder WithText(string text, bool enableFormatting = true)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("text cannot be null or empty", nameof(text));

            _template.Text = enableFormatting ? Encoder.Encode(text) : text;
            _template.EnableFormatting = enableFormatting;

            return this;
        }

        /// <inheritdoc />
        public ISlackMessageBuilder WithChannel(string channel)
        {
            if (!string.IsNullOrEmpty(channel))
                _template.Channel = channel;

            return this;
        }

        /// <inheritdoc />
        public ISlackMessageBuilder WithUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Must be non-empty", nameof(username));

            _template.Username = username;

            return this;
        }

        /// <inheritdoc />
        public ISlackMessageBuilder WithIcon(IconType iconType, string urlOrEmoji)
        {
            if (string.IsNullOrEmpty(urlOrEmoji))
                throw new ArgumentException("Must be non-empty", nameof(urlOrEmoji));

            switch (iconType)
            {
                case IconType.Url:
                    _template.IconUrl = urlOrEmoji;
                    break;
                case IconType.Emoji:
                    _template.IconEmoji = urlOrEmoji;
                    break;
            }

            return this;
        }

        /// <inheritdoc />
        public ISlackMessageBuilder WithAttachment(Action<ISlackAttachmentBuilder> configureAttachment)
        {
            if (configureAttachment == null)
                throw new ArgumentNullException("Must configure attachment builder", nameof(configureAttachment));

            var attachmentBuilder = new SlackAttachmentBuilder();
            configureAttachment(attachmentBuilder);
            var attachment = attachmentBuilder.Build();

            if (_template.Attachments == null)
            {
                _template.Attachments = new List<SlackAttachment> {attachment};
            }
            else
            {
                _template.Attachments.Add(attachment);
            }

            return this;
        }
    }
}