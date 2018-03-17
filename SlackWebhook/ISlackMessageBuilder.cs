using System;
using SlackWebhook.Enums;
using SlackWebhook.Messages;

namespace SlackWebhook
{
    /// <summary>
    /// Slack message builder that produces <see cref="SlackMessage"/> instances based on the builder's
    /// current configuration.
    /// </summary>
    public interface ISlackMessageBuilder
    {
        /// <summary>
        /// Build <see cref="SlackMessage"/> based on current state of the builder
        /// </summary>
        /// <returns>New message</returns>
        /// <exception cref="Exceptions.SlackMessageValidationException">
        /// Thrown if validation of the message fails, such as if a required field is missing.
        /// <para/>
        /// Uses <see cref="SlackMessage.Validate"/> to perform validation.
        /// </exception>
        SlackMessage Build();

        /// <summary>
        /// With required message text
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="SlackMessage.Text"/> and <see cref="SlackMessage.EnableFormatting"/> properties.
        /// <para/>
        /// If <paramref name="enableFormatting"/> is enabled, you can use Slack message formatting in
        /// <paramref name="text"/> and it will automatically be encoded according to slack encoding rules.
        /// </remarks>
        /// <param name="text">Message text</param>
        /// <param name="enableFormatting">Whether or not to enable formatting for text</param>
        ISlackMessageBuilder WithText(string text, bool enableFormatting = true);

        /// <summary>
        /// With username
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="SlackMessage.Username"/> property
        /// </remarks>
        /// <param name="username">Username</param>
        ISlackMessageBuilder WithUsername(string username);

        /// <summary>
        /// With icon (url or emoji)
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="SlackMessage.IconUrl"/> or <see cref="SlackMessage.IconEmoji"/> based on
        /// <paramref name="iconType"/> with the provided value <paramref name="urlOrEmoji"/>
        /// </remarks>
        /// <param name="iconType">Type of icon</param>
        /// <param name="urlOrEmoji">URL or emoji name (depending on <paramref name="iconType"/>)</param>
        ISlackMessageBuilder WithIcon(IconType iconType, string urlOrEmoji);

        /// <summary>
        /// With channel
        /// </summary>
        /// <param name="channel">The channel.</param>
        /// <remarks>
        /// Sets the <see cref="SlackMessage.Channel"/> property
        /// </remarks>
        ISlackMessageBuilder WithChannel(string channel);

        /// <summary>
        /// With attachment build with provided attachment builder
        /// </summary>
        /// <remarks>
        /// Adds a new <see cref="SlackAttachment"/> to <see cref="SlackMessage.Attachments"/> built using provided 
        /// <see cref="ISlackAttachmentBuilder"/>
        /// </remarks>
        /// <param name="configureAttachment">Attachment builder</param>
        ISlackMessageBuilder WithAttachment(Action<ISlackAttachmentBuilder> configureAttachment);
    }
}