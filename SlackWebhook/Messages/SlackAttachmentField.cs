using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SlackWebhook.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Optional attachment field added to <see cref="SlackAttachment.Fields"/>
    /// </summary>
    public class SlackAttachmentField
    {
        public SlackAttachmentField()
        {
        }

        public SlackAttachmentField(SlackAttachmentField source)
        {
            Title = source.Title;
            Value = source.Value;
            Short = source.Short;
        }

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

        /// <summary>
        /// Validates the current state of the attachment field
        /// </summary>
        /// <param name="validationErrors"></param>
        /// <returns></returns>
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
