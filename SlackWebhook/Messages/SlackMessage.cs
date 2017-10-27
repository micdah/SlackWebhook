using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using SlackWebhook.Exceptions;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Basis for a Slack message which can be sent to the webhook URL
    /// </summary>
    public class SlackMessage
    {
        public SlackMessage()
        {
        }

        internal SlackMessage(SlackMessage source)
        {
            Text = source.Text;
            Username = source.Username;
            IconUrl = source.IconUrl;
            IconEmoji = source.IconEmoji;
            EnableFormatting = source.EnableFormatting;
            Attachments = source.Attachments?
                .Select(a => new SlackAttachment(a))
                .ToList();
        }

        /// <summary>
        /// Message text which may contain formatting (unless 
        /// <see cref="EnableFormatting"/>  is deactivated) and can span 
        /// multiple lines.<para/>
        /// </summary>
        /// <remarks>
        /// You can use the regular Slack formatting
        /// <code>
        ///     *bold* `code` _italic_ ~strike~
        /// </code><para/>
        /// and also include links
        /// <code>
        ///     &lt;URL|title&gt;
        /// </code>
        /// </remarks>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Username shown (optional)
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Icon URL to show before username (optional)
        /// </summary>
        /// <remarks>
        /// Either provide this OR <see cref="IconEmoji"/>, but not both
        /// </remarks>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Icon emoji name (<em>using slack emoji name</em>) (optional)
        /// </summary>
        /// <remarks>
        /// Either provide this OR <see cref="IconUrl"/>, but not both
        /// </remarks>
        [JsonProperty("icon_emoji")]
        public string IconEmoji { get; set; }

        /// <summary>
        /// Whether or not to enable formatting for this message
        /// </summary>
        /// <remarks>Default true</remarks>
        [JsonProperty("mrkdwn")]
        public bool EnableFormatting { get; set; } = true;

        /// <summary>
        /// Attachments to show below message (optional)
        /// </summary>
        [JsonProperty("attachments")]
        public List<SlackAttachment> Attachments { get; set; }

        /// <summary>
        /// Validates the current state of the message (including any nested 
        /// elements, such as <see cref="Attachments"/>)
        /// </summary>
        /// <returns>True if message is valid, false otherwise</returns>
        public bool Validate(ref ICollection<ValidationError> validationErrors)
        {
            if (validationErrors == null)
            {
                validationErrors = new List<ValidationError>();
            }

            // Text is required
            if (string.IsNullOrEmpty(Text))
            {
                validationErrors.Add(new ValidationError(nameof(SlackMessage), nameof(Text), 
                    "Text is a required field"));
            }

            // May only set IconUrl OR IconEmoji
            if (IconUrl != null && IconEmoji != null)
            {
                validationErrors.Add(new ValidationError(nameof(SlackMessage), nameof(IconUrl),
                    $"Must not set both {nameof(IconUrl)} and {nameof(IconEmoji)}"));

                validationErrors.Add(new ValidationError(nameof(SlackMessage), nameof(IconEmoji),
                    $"Must not set both {nameof(IconUrl)} and {nameof(IconEmoji)}"));
            }

            // All attachments (if present) must be valid
            if (Attachments != null) 
            {
                foreach (var attachment in Attachments)
                {
                    if (!attachment.Validate(ref validationErrors))
                    {
                        validationErrors.Add(new ValidationError(nameof(SlackMessage), nameof(Attachments),
                            "Attachment validation failed"));
                    }
                }
            }

            return !validationErrors.Any();
        }

        /// <summary>
        /// Checks the current state using <see cref="Validate"/> and throws a 
        /// <see cref="SlackMessageValidationException"/> with all validations erros, if any 
        /// are found.
        /// </summary>
        internal void ThrowIfInvalid()
        {
            ICollection<ValidationError> errors = new List<ValidationError>();
            if (!Validate(ref errors))
            {
                throw new SlackMessageValidationException("Validation failed", errors);
            }
        }
    }
}
