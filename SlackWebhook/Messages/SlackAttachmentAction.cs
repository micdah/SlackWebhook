using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SlackWebhook.Core;
using SlackWebhook.Exceptions;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Optional action to se <see cref="SlackAttachment"/>.
    /// </summary>
    public abstract class SlackAttachmentAction : ICloneable<SlackAttachmentAction>, IValidateable
    {
        /// <summary>
        /// Initialize attachment action
        /// </summary>
        /// <param name="type">Type of action</param>
        protected SlackAttachmentAction(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Type of action
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; }

        /// <summary>
        /// Text displayed for the action
        /// </summary>
        /// <remarks>
        /// How this is presented depends on the type of action
        /// </remarks>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <inheritdoc />
        public abstract SlackAttachmentAction Clone();

        /// <inheritdoc />
        public virtual bool Validate(ref ICollection<ValidationError> validationErrors)
        {
            if (validationErrors == null)
            {
                validationErrors = new List<ValidationError>();
            }

            // Type is required
            if (string.IsNullOrEmpty(Type))
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachmentAction), nameof(Type),
                    "Type is a required field"));
            }

            // Text is required
            if (string.IsNullOrEmpty(Text))
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachmentAction), nameof(Text),
                    "Text is a required field"));
            }

            return !validationErrors.Any();
        }
    }
}