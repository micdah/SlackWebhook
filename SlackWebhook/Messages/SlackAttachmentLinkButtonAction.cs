using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SlackWebhook.Core;
using SlackWebhook.Enums;
using SlackWebhook.Exceptions;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Button action which will open a <see cref="Url"/>, if clicked
    /// </summary>
    public class SlackAttachmentLinkButtonAction : SlackAttachmentAction
    {
        /// <summary>
        /// Create new empty link button action
        /// </summary>
        public SlackAttachmentLinkButtonAction() : base("button")
        {
        }

        /// <summary>
        /// URL to open if link button is clicked
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Optional style
        /// </summary>
        [JsonProperty("style"), JsonConverter(typeof(ActionStyleJsonConverter))]
        public ActionStyle? Style { get; set; }
        
        /// <inheritdoc />
        public override SlackAttachmentAction Clone()
        {
            return new SlackAttachmentLinkButtonAction
            {
                Text = Text,
                Url = Url,
                Style = Style
            };
        }

        /// <inheritdoc />
        public override bool Validate(ref ICollection<ValidationError> validationErrors)
        {
            base.Validate(ref validationErrors);

            // Url is required
            if (string.IsNullOrEmpty(Url))
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachmentLinkButtonAction), nameof(Url),
                    "Url is a required field"));
            }

            // Style must be one of pre-set values
            if (Style != null)
            {
                if (!Enum.IsDefined(typeof(ActionStyle), Style))
                {
                    validationErrors.Add(new ValidationError(nameof(SlackAttachmentLinkButtonAction), nameof(Style),
                        "Unknown style"));
                }
            }

            return !validationErrors.Any();
        }
    }
}