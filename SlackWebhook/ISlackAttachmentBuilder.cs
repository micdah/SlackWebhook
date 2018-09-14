using System;
using System.Drawing;
using SlackWebhook.Enums;
using SlackWebhook.Messages;

namespace SlackWebhook
{
    /// <summary>
    /// Slack attachment builder used to configure an attachment to be added to a <see cref="SlackMessage"/>
    /// </summary>
    public interface ISlackAttachmentBuilder
    {
        /// <summary>
        /// With required title
        /// </summary>
        /// <remarks>
        /// The title is displayed as larger, bold text near the top of a
        /// message attachment. By passing a valid URL in the
        /// <see cref="SlackAttachment.TitleLink"/> parameter (optional), the title text will be
        /// </remarks>
        /// <param name="title">Title</param>
        ISlackAttachmentBuilder WithTitle(string title);

        /// <summary>
        /// With link on attachment title
        /// </summary>
        /// <remarks>
        /// Link of title (optional)
        /// </remarks>
        /// <param name="url"></param>
        ISlackAttachmentBuilder WithLink(string url);

        /// <summary>
        /// With optional text
        /// </summary>
        /// <remarks>
        /// This is the main text in a message attachment, and can contain
        /// standard message markup. The content will automatically collapse if
        /// it contains 700+ characters or 5+ linebreaks, and will display a
        /// "Show more..." link to expand the content. Links posted in the text
        /// field will not unfurl.
        /// <para/>
        /// If <paramref name="enableFormatting"/> is enabled, you can use Slack message formatting in 
        /// <paramref name="text"/> and it will automatically be encoded according to slack encoding rules.
        /// </remarks>
        /// <param name="text">Text</param>
        /// <param name="enableFormatting">Whether or not to enable formatting for text</param>
        ISlackAttachmentBuilder WithText(string text, bool enableFormatting = true);

        /// <summary>
        /// With optional pre-text
        /// </summary>
        /// <remarks>
        /// This is optional text that appears above the message attachment
        /// block.
        /// </remarks>
        /// <param name="text">Pre-text</param>
        /// <param name="enableFormatting">Whether or not to enable formatting for text</param>
        ISlackAttachmentBuilder WithPreText(string text, bool enableFormatting = true);

        /// <summary>
        /// With required plain-text summary of the attachment
        /// </summary>
        /// <remarks>
        /// A plain-text summary of the attachment. This text will be used in 
        /// clients that don't show formatted text (eg. IRC, mobile 
        /// notifications) and should not contain any markup.
        /// </remarks>
        /// <param name="fallback"></param>
        /// <returns></returns>
        ISlackAttachmentBuilder WithFallback(string fallback);

        /// <summary>
        /// With hex-based color
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
        /// <param name="hexColor">Hex color or one of named colors (good, warning, danger)</param>
        ISlackAttachmentBuilder WithColor(string hexColor);

        /// <summary>
        /// With color from <see cref="Color"/> instance
        /// </summary>
        /// <param name="color">Color instance to set color from</param>
        ISlackAttachmentBuilder WithColor(Color color);

        /// <summary>
        /// With author name, and optional link url and icon url
        /// </summary>
        /// <remarks>
        /// The author parameters will display a small section at the top of a
        /// message attachment.<para/>
        /// A valid URL that will hyperlink the <see cref="SlackAttachment.AuthorName"/> text
        /// mentioned above. Will only work if <see cref="SlackAttachment.AuthorName"/> is
        /// present.<para/>
        /// A valid URL that displays a small 16x16px image to the left of the
        /// <see cref="SlackAttachment.AuthorName"/> text. Will only work if
        /// <see cref="SlackAttachment.AuthorName"/> is present.
        /// </remarks>
        /// <param name="name">Author name (required)</param>
        /// <param name="linkUrl">Author link url (optional)</param>
        /// <param name="iconUrl">Author icon url (optional)</param>
        ISlackAttachmentBuilder WithAuthor(string name, string linkUrl = null, string iconUrl = null);

        /// <summary>
        /// With image url
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
        /// <param name="url">Image url</param>
        ISlackAttachmentBuilder WithImage(string url);

        /// <summary>
        /// With thumbnail url
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
        /// <param name="url">Thumbnail url</param>
        ISlackAttachmentBuilder WithThumbnail(string url);

        /// <summary>
        /// With footer text and optional footer icon
        /// </summary>
        /// <remarks>
        /// Add some brief text to help contextualize and identify an
        /// attachment. Limited to 300 characters, and may be truncated further
        /// when displayed to users in environments with limited screen real
        /// estate. <para/>
        /// To render a small icon beside your footer text, provide a publicly
        /// accessible URL string in the footer_icon field. You must also
        /// provide a footer for the field to be recognized.<para/>
        /// <para/>
        /// We'll render what you provide at 16px by 16px. It's best to use an
        /// image that is similarly sized.
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="iconUrl"></param>
        /// <returns></returns>
        ISlackAttachmentBuilder WithFooter(string text, string iconUrl = null);

        /// <summary>
        /// With timestamp based on <paramref name="timestamp"/>
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
        /// <param name="timestamp">DateTimeOffset to set timestamp from</param>
        ISlackAttachmentBuilder WithTimestamp(DateTimeOffset timestamp);

        /// <summary>
        /// With epoc timestamp
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
        /// <param name="epochTime">Epoch timestamp</param>
        ISlackAttachmentBuilder WithTimestamp(int epochTime);

        /// <summary>
        /// With attachment field shown as a table inside the message attachment
        /// </summary>
        /// <remarks>
        /// If <paramref name="enableFormatting"/> is enabled, you can use Slack message formatting in 
        /// <paramref name="value"/> and it will automatically be encoded according to slack encoding rules.
        /// </remarks>
        /// <param name="title">
        /// Title of field<para/>
        /// Shown as a bold heading above the value text. It cannot contain
        /// markup and will be escaped for you.
        /// </param>
        /// <param name="value">
        /// Value of field (may contain formatting if enabled)<para/>
        /// The text value of the field. It may contain standard message markup
        /// and must be escaped as normal. May be multi-line.
        /// </param>
        /// <param name="isShort">Whether field can be shown side-by-side with other fields (optional)</param>
        /// <param name="enableFormatting">Whether or not to enable formatting for value</param>
        ISlackAttachmentBuilder WithField(string title, string value, bool isShort = false,
            bool enableFormatting = true);

        /// <summary>
        /// With link button action, shown at the bottom of the attachment
        /// </summary>
        /// <remarks>
        /// An attachment may contain multiple actions
        /// </remarks>
        /// <param name="text">Test shown on link button</param>
        /// <param name="url">URL opened if link button is pressed</param>
        /// <param name="style">Optional style</param>
        ISlackAttachmentBuilder WithLinkButtonAction(string text, string url, ActionStyle? style = null);
    }
}