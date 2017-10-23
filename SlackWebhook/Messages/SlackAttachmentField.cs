using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Optional attachment field added to <see cref="SlackAttachment.Fields"/>
    /// </summary>
    public class SlackAttachmentField
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

        public bool Validate()
        {
            // TODO
            return true;
        }
    }
}
