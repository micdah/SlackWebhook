using SlackWebhook.Core;
using SlackWebhook.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SlackWebhook
{
    internal class SlackAttachmentBuilder : ISlackAttachmentBuilder
    {
        private static readonly FormattedTextEncoder Encoder = new FormattedTextEncoder();
        private readonly SlackAttachment _template;
        private static readonly Regex ColorValidRegex = new Regex(@"(good|warning|danger|#[0-9aAbBcCdDeEfF]{6})");

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
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Must be non-empty", nameof(url));

            _template.TitleLink = url;

            return this;
        }

        public ISlackAttachmentBuilder WithText(string text, bool enableFormatting = true)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Must be non-empty", nameof(text));

            _template.Text = enableFormatting ? Encoder.Encode(text) : text;
            SetEnableFormatting(SlackAttachment.FormattingText, enableFormatting);

            return this;
        }

        public ISlackAttachmentBuilder WithPreText(string text, bool enableFormatting = true)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Must be non-empty", nameof(text));

            _template.PreText = enableFormatting ? Encoder.Encode(text) : text;
            SetEnableFormatting(SlackAttachment.FormattingPretext, enableFormatting);

            return this;
        }

        public ISlackAttachmentBuilder WithFallback(string fallback)
        {
            if (string.IsNullOrEmpty(fallback))
                throw new ArgumentException("Must be non-empty", nameof(fallback));

            _template.Fallback = fallback;

            return this;
        }

        public ISlackAttachmentBuilder WithColor(string hexColor)
        {
            if (!ColorValidRegex.IsMatch(hexColor))
                throw new ArgumentException("Must be either a hex-color or known color name", nameof(hexColor));

            _template.Color = hexColor;

            return this;
        }

        public ISlackAttachmentBuilder WithColor(Color color)
        {
            if (color == Color.Empty)
                throw new ArgumentException("Must not be empty color", nameof(color));

            _template.SetColor(color);

            return this;
        }

        public ISlackAttachmentBuilder WithAuthor(string name, string linkUrl = null, string iconUrl = null)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Must be non-empty", nameof(name));

            if (linkUrl == string.Empty)
                throw new ArgumentException("Must not be empty", nameof(linkUrl));

            if (iconUrl == string.Empty)
                throw new ArgumentException("Must not be empty", nameof(iconUrl));

            _template.AuthorName = name;
            _template.AuthorLink = linkUrl;
            _template.AuthorIcon = iconUrl;

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