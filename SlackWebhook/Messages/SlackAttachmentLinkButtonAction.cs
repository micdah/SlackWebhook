using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SlackWebhook.Exceptions;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Button action which will open a <see cref="Url"/>, if clicked
    /// </summary>
    public class SlackAttachmentLinkButtonAction : SlackAttachmentAction
    {
        /// <summary>
        /// Turns the button green and indicates the best forward action to take
        /// </summary>
        public const string StylePrimary = "primary";

        /// <summary>
        /// Turns the button red and indicates it some kind of destructive action
        /// </summary>
        public const string StyleDanger = "danger";

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
        /// Optional style, may be one of <see cref="StylePrimary"/> or <see cref="StyleDanger"/>
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }

        /// <inheritdoc />
        public override SlackAttachmentAction Clone()
        {
            return new SlackAttachmentLinkButtonAction
            {
                Text = Text,
                Url = Url
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
                if (Style != StylePrimary && Style != StyleDanger)
                {
                    validationErrors.Add(new ValidationError(nameof(SlackAttachmentLinkButtonAction), nameof(Style),
                        $"Style must be one of '{StylePrimary}' or '{StyleDanger}'"));
                }
            }

            return !validationErrors.Any();
        }
    }
}