﻿using SlackWebhook.Core;
using SlackWebhook.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using SlackWebhook.Enums;

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
            return _template.Clone();
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

        public ISlackAttachmentBuilder WithImage(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Must be non-empty", nameof(url));

            _template.ImageUrl = url;

            return this;
        }

        public ISlackAttachmentBuilder WithThumbnail(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Must be non-empty", nameof(url));

            _template.ThumbnailUrl = url;

            return this;
        }

        public ISlackAttachmentBuilder WithFooter(string text, string iconUrl = null)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Must be non-empty", nameof(text));

            if (iconUrl == string.Empty)
                throw new ArgumentException("Must not be empty", nameof(iconUrl));

            _template.Footer = text;
            _template.FooterIcon = iconUrl;

            return this;
        }

        public ISlackAttachmentBuilder WithTimestamp(DateTimeOffset timestamp)
        {
            if (timestamp < SlackAttachment.EpochStart)
                throw new ArgumentException("Must be after epoch start date", nameof(timestamp));

            _template.SetTimestamp(timestamp);

            return this;
        }

        public ISlackAttachmentBuilder WithTimestamp(int epochTime)
        {
            if (epochTime < 0)
                throw new ArgumentException("Must be non-negative", nameof(epochTime));

            _template.Timestamp = epochTime;

            return this;
        }

        public ISlackAttachmentBuilder WithField(string title, string value, bool isShort = false, bool enableFormatting = true)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Must be non-empty", nameof(title));

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Must be non-empty", nameof(value));

            if (_template.Fields != null)
            {
                var fieldsFormattingEnabled = _template.EnableFormatting.Contains(SlackAttachment.FormattingFields);
                if (enableFormatting && !fieldsFormattingEnabled)
                {
                    throw new ArgumentException(
                        "Cannot add field with formatting, after field without formatting has been added",
                        nameof(enableFormatting));
                }
                if (!enableFormatting && fieldsFormattingEnabled)
                {
                    throw new ArgumentException(
                        "Cannot add field without formatting, after field with formatting has been added",
                        nameof(enableFormatting));
                }
            }
            else
            {
                _template.Fields = new List<SlackAttachmentField>();
            }

            _template.Fields.Add(new SlackAttachmentField
            {
                Title = title,
                Value = enableFormatting ? Encoder.Encode(value) : value,
                Short = isShort
            });

            SetEnableFormatting(SlackAttachment.FormattingFields, enableFormatting);

            return this;
        }

        public ISlackAttachmentBuilder WithLinkButtonAction(string text, string url, ActionStyle? style = null)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Must be non-empty", nameof(text));

            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Must be non-empty", nameof(url));
            
            if (style.HasValue && !Enum.IsDefined(typeof(ActionStyle), style.Value))
                throw new ArgumentOutOfRangeException(nameof(style), "Invalid style");

            if (_template.Actions == null)
            {
                _template.Actions = new List<SlackAttachmentAction>();
            }
            
            _template.Actions.Add(new SlackAttachmentLinkButtonAction
            {
                Text = text,
                Url = url,
                Style = style
            });

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