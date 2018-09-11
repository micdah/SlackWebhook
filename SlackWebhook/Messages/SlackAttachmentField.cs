using Newtonsoft.Json;
using SlackWebhook.Exceptions;
using System.Collections.Generic;
using System.Linq;
using SlackWebhook.Core;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Optional attachment field added to <see cref="SlackAttachment.Fields"/>
    /// </summary>
    public class SlackAttachmentField : ICloneable<SlackAttachmentField>, IValidateable
    {
        /// <summary>
        /// Title of field
        /// </summary>
        /// <remarks>
        /// Shown as a bold heading above the value text. It cannot contain
        /// markup and will be escaped for you.
        /// </remarks>
        /// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Value of field (may contain formatting if enabled)
        /// </summary>
        /// <remarks>
        /// The text value of the field. It may contain standard message markup
        /// and must be escaped as normal. May be multi-line.
        /// </remarks>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Whether field can be shown side-by-side with other fields (optional)
        /// </summary>
        [JsonProperty("short")]
        public bool Short { get; set; }

        /// <inheritdoc />
        public SlackAttachmentField Clone()
        {
            return new SlackAttachmentField
            {
                Title = Title,
                Value = Value,
                Short = Short
            };
        }

        /// <inheritdoc />
        public bool Validate(ref ICollection<ValidationError> validationErrors)
        {
            if (validationErrors == null)
            {
                validationErrors = new List<ValidationError>();
            }

            if (string.IsNullOrEmpty(Title))
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachmentField), nameof(Title),
                    "Title is a required field"));
            }

            if (string.IsNullOrEmpty(Value))
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachmentField), nameof(Value),
                    "Value is a required field"));
            }

            return !validationErrors.Any();
        }
    }
}