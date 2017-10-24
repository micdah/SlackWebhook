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
        /// Sets the <see cref="SlackAttachment.Title"/> required field
        /// </remarks>
        /// <param name="title">Title</param>
        ISlackAttachmentBuilder WithTitle(string title);

        /// <summary>
        /// With link on attachment title
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="SlackAttachment.TitleLink"/> property
        /// </remarks>
        /// <param name="url"></param>
        ISlackAttachmentBuilder WithLink(string url);

        /// <summary>
        /// With optional text
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="SlackAttachment.Text"/> and <see cref="SlackAttachment.EnableFormatting"/> (with
        /// <see cref="SlackAttachment.FormattingText"/>).
        /// <para/>
        /// If <paramref name="enableFormatting"/> is enabled, you can use Slack message formatting in 
        /// <paramref name="text"/> and it will automatically be encoded according to slack encoding rules.
        /// </remarks>
        /// <param name="text">Text</param>
        /// <param name="enableFormatting">Whether or not to enable formatting for text</param>
        ISlackAttachmentBuilder WithText(string text, bool enableFormatting = true);
    }
}