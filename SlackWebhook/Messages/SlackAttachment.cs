using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SlackWebhook.Exceptions;

namespace SlackWebhook.Messages
{
    /// <summary>
    /// Optional attachment to a <see cref="SlackMessage"/>.<para/>
    /// See https://api.slack.com/docs/message-attachments for more details
    /// </summary>
    public class SlackAttachment
    {
        private static readonly DateTimeOffset EpochStart = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.FromHours(0));

        /// <summary>
        /// Used to enable formatting of the <see cref="Text"/> field
        /// </summary>
        public const string FormattingText = "text";

        /// <summary>
        /// Used to enable formatting of the <see cref="PreText"/> field
        /// </summary>
        public const string FormattingPretext = "pretext";

        /// <summary>
        /// Used to enable formatting of the <see cref="Fields"/> value fields
        /// </summary>
        public const string FormattingFields = "fields";

        public SlackAttachment()
        {
        }

        internal SlackAttachment(SlackAttachment source)
        {
            Title = source.Title;
            TitleLink = source.TitleLink;
            Text = source.Text;
            PreText = source.PreText;
            Fallback = source.Fallback;
            Color = source.Color;
            AuthorName = source.AuthorName;
            AuthorLink = source.AuthorLink;
            AuthorIcon = source.AuthorIcon;
            ImageUrl = source.ImageUrl;
            ThumbnailUrl = source.ThumbnailUrl;
            Footer = source.Footer;
            FooterIcon = source.FooterIcon;
            Timestamp = source.Timestamp;
            Fields = source.Fields?
                .Select(f => new SlackAttachmentField(f))
                .ToList();
            EnableFormatting = source.EnableFormatting?.ToList();
        }

        /// <summary>
        /// Title of attachment (required)
        /// </summary>
        /// <remarks>
        /// The title is displayed as larger, bold text near the top of a
        /// message attachment. By passing a valid URL in the
        /// <see cref="TitleLink"/> parameter (optional), the title text will be
        /// hyperlinked.
        /// </remarks>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Link of title (optional)
        /// </summary>
        [JsonProperty("title_link")]
        public string TitleLink { get; set; }

        /// <summary>
        /// Optional text that appears within the attachment
        /// </summary>
        /// <remarks>
        /// This is the main text in a message attachment, and can contain
        /// standard message markup. The content will automatically collapse if
        /// it contains 700+ characters or 5+ linebreaks, and will display a
        /// "Show more..." link to expand the content. Links posted in the text
        /// field will not unfurl.
        /// </remarks>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Optional text that appears above the attachment block
        /// </summary>
        /// <remarks>
        /// This is optional text that appears above the message attachment
        /// block.
        /// </remarks>
        [JsonProperty("pretext")]
        public string PreText { get; set; }

        /// <summary>
        /// Required plain-text summary of the attachment
        /// </summary>
        /// <remarks>
        /// A plain-text summary of the attachment. This text will be used in 
        /// clients that don't show formatted text (eg. IRC, mobile 
        /// notifications) and should not contain any markup.
        /// </remarks>
        [JsonProperty("fallback")]
        public string Fallback { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <remarks>
        /// Like traffic signals, color-coding messages can quickly communicate
        /// intent and help separate them from the flow of other messages in the
        /// timeline.<para/>
        /// <para/>
        /// An optional value that can either be one of good, warning, danger,
        /// or any hex color code(eg. #439FE0). This value is used to color the
        /// border along the left side of the message attachment.
        /// </remarks>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// Author name (optional)
        /// </summary>
        /// <remarks>
        /// The author parameters will display a small section at the top of a
        /// message attachment
        /// </remarks>
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Author link (optional)
        /// </summary>
        /// <remarks>
        /// A valid URL that will hyperlink the <see cref="AuthorName"/> text
        /// mentioned above. Will only work if <see cref="AuthorName"/> is
        /// present.
        /// </remarks>
        [JsonProperty("author_link")]
        public string AuthorLink { get; set; }

        /// <summary>
        /// Author icon URL (optional)
        /// </summary>
        /// <remarks>
        /// A valid URL that displays a small 16x16px image to the left of the
        /// <see cref="AuthorName"/> text. Will only work if
        /// <see cref="AuthorName"/> is present.
        /// </remarks>
        [JsonProperty("author_icon")]
        public string AuthorIcon { get; set; }

        /// <summary>
        /// Image url (optional)
        /// </summary>
        /// <remarks>
        /// A valid URL to an image file that will be displayed inside a message
        /// attachment. We currently support the following formats: GIF, JPEG,
        /// PNG, and BMP.<para/>
        /// <para/>
        /// Large images will be resized to a maximum width of 400px or a
        /// maximum height of 500px, while still maintaining the original aspect
        /// ratio.
        /// </remarks>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Thumbnail url (optional)
        /// </summary>
        /// <remarks>
        /// A valid URL to an image file that will be displayed as a thumbnail
        /// on the right side of a message attachment. We currently support the
        /// following formats: GIF, JPEG, PNG, and BMP.<para/>
        /// <para/>
        /// The thumbnail's longest dimension will be scaled down to 75px while
        /// maintaining the aspect ratio of the image. The filesize of the image
        /// must also be less than 500 KB.<para/>
        /// <para/>
        /// For best results, please use images that are already 75px by 75px.
        /// </remarks>
        [JsonProperty("thumb_url")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Footer text shown at the bottom of attachment (optional)
        /// </summary>
        /// <remarks>
        /// Add some brief text to help contextualize and identify an
        /// attachment. Limited to 300 characters, and may be truncated further
        /// when displayed to users in environments with limited screen real
        /// estate.
        /// </remarks>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Icon shown left of footer text (optional)
        /// </summary>
        /// <remarks>
        /// To render a small icon beside your footer text, provide a publicly
        /// accessible URL string in the footer_icon field. You must also
        /// provide a footer for the field to be recognized.<para/>
        /// <para/>
        /// We'll render what you provide at 16px by 16px. It's best to use an
        /// image that is similarly sized.
        /// </remarks>
        [JsonProperty("footer_icon")]
        public string FooterIcon { get; set; }

        /// <summary>
        /// Timestamp (epoch time) shown below attachment (optional)
        /// </summary>
        /// <remarks>
        /// Does your attachment relate to something happening at a specific 
        /// time?<para/>
        /// <para/>
        /// By providing the ts field with an integer value in "epoch time",
        /// the attachment will display an additional timestamp value as part of
        /// the attachment's footer.<para/>
        /// <para/>
        /// Use ts when referencing articles or happenings.Your message will 
        /// have its own timestamp when published.<para/>
        /// <para/>
        /// Example: Providing 123456789 would result in a rendered timestamp 
        /// of Nov 29th, 1973.
        /// </remarks>
        [JsonProperty("ts")]
        public int? Timestamp { get; set; }

        /// <summary>
        /// Fields shown as a table inside the message attachment (optional)
        /// </summary>
        [JsonProperty("fields")]
        public List<SlackAttachmentField> Fields { get; set; }

        /// <summary>
        /// Enable formatting for various fields of the attachment, use 
        /// <see cref="FormattingText"/>, <see cref="FormattingPretext"/> and
        /// <see cref="FormattingFields"/> to contorl which fields have 
        /// formatting enabled.
        /// </summary>
        [JsonProperty("mrkdwn_in")]
        public List<string> EnableFormatting { get; set; }

        /// <summary>
        /// Set color hex code from <see cref="System.Drawing.Color"/>
        /// </summary>
        /// <param name="color">Color to set color hex from</param>
        public void SetColor(Color color)
        {
            Color = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        /// <summary>
        /// Set <see cref="Timestamp"/> epoch value based on provided date time
        /// </summary>
        /// <param name="timestamp">Timestamp to set epohc time from</param>
        public void SetTimestamp(DateTimeOffset timestamp) 
        {
            Timestamp = (int)(timestamp - EpochStart).TotalSeconds;
        }

        /// <summary>
        /// Validates the current state of the attachment (including any nested
        /// elements, such as <see cref="Fields"/>)
        /// </summary>
        /// <param name="validationErrors"></param>
        /// <returns>True if the attachment is valid, false otherwise</returns>
        public bool Validate(ref ICollection<ValidationError> validationErrors) 
        {
            if (validationErrors == null)
            {
                validationErrors = new List<ValidationError>();
            }

            // Title is required
            if (string.IsNullOrEmpty(Title))
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachment), nameof(Title), 
                    "Title is a required field"));
            }

            // Timestamp must be positive
            if (Timestamp.HasValue && Timestamp.Value < 0)
            {
                validationErrors.Add(new ValidationError(nameof(SlackAttachment), nameof(Timestamp), 
                    "Must be non-negative value"));
            }

            // Validate any fields (if present)
            if (Fields != null)
            {
                foreach (var field in Fields)
                {
                    if (!field.Validate(ref validationErrors))
                    {
                        validationErrors.Add(new ValidationError(nameof(SlackAttachment), nameof(Fields),
                            "Field validation failed"));
                    }
                }
            }

            return !validationErrors.Any();
        }
    }
}
