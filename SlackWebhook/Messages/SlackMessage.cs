using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Basis for a Slack message which can be sent to the webhook URL
    /// </summary>
    public class SlackMessage
    {
        /// <summary>
        /// Message text which may contain formatting (unless 
        /// <see cref="EnableFormatting"/>  is deactivated) and can span 
        /// multiple lines.<para/>
        /// </summary>
        /// <remarks>
        /// You can use the regular Slack formatting<para/>
        /// <code>
        ///     *bold* `code` _italic_ ~strike~
        /// </code><para/>
        /// and also include links<para/>
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
        public bool Validate()
        {
            // Text is required
            if (string.IsNullOrEmpty(Text))
            {
                return false;
            }

            // May only set IconUrl OR IconEmoji
            if (IconUrl != null && IconEmoji != null)
            {
                return false;
            }

            // All attachments (if present) must be valid
            if (Attachments != null) 
            {
                if (Attachments.Any(a => !a.Validate()))
                    return false;
            }

            return true;
        }
    }
}
