using System.Drawing;
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
    }
}