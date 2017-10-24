using System;
using System.Collections.Generic;
using SlackWebhook.Core;
using SlackWebhook.Messages;

namespace SlackWebhook
{
    internal class SlackAttachmentBuilder : ISlackAttachmentBuilder
    {
        private static readonly FormattedTextEncoder Encoder = new FormattedTextEncoder();
        private readonly SlackAttachment _template;

        public SlackAttachmentBuilder()
        {
            _template = new SlackAttachment();
        }

        public SlackAttachment Build()
        {
            return new SlackAttachment(_template);
        }

        public ISlackAttachmentBuilder WithTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Must be non-empty", nameof(title));

            _template.Title = title;

            return this;
        }

        public ISlackAttachmentBuilder WithLink(string url)
        {
            throw new NotImplementedException();
        }

        public ISlackAttachmentBuilder WithText(string text, bool enableFormatting = true)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Must be non-empty", nameof(text));

            _template.Text = enableFormatting ? Encoder.Encode(text) : text;
            SetEnableFormatting(SlackAttachment.FormattingText, enableFormatting);

            return this;
        }

        /// <summary>
        /// Enables or disables formatting by adding/removing <paramref name="formattingType"/> from
        /// <see cref="SlackAttachment.EnableFormatting"/>
        /// </summary>
        /// <param name="formattingType">Formatting type</param>
        /// <param name="enable">Whether to enable (add) or disable (remove)</param>
        private void SetEnableFormatting(string formattingType, bool enable)
        {
            if (_template.EnableFormatting == null)
            {
                _template.EnableFormatting = new List<string>();
            }

            if (enable)
            {
                if (!_template.EnableFormatting.Contains(formattingType))
                {
                    _template.EnableFormatting.Add(formattingType);
                }
            }
            else
            {
                _template.EnableFormatting.Remove(formattingType);
            }
        }
    }
}