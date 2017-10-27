using Newtonsoft.Json;
using SlackWebhook.Messages;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebhook
{
    public interface ISlackClient
    {
        /// <summary>
        /// Send new <see cref="SlackMessage"/> by configuring the provided <see cref="ISlackMessageBuilder"/>
        /// </summary>
        /// <param name="configureBuilder">Configure message to send using this builder</param>
        /// <exception cref="Exceptions.SlackMessageValidationException">
        /// Thrown if validation of the message fails, such as if a required field is missing.
        /// <para/>
        /// Uses <see cref="SlackMessage.Validate"/> to perform validation.
        /// </exception>
        Task SendAsync(Action<ISlackMessageBuilder> configureBuilder);

        /// <summary>
        /// Send the provided <see cref="SlackMessage"/>
        /// </summary>
        /// <param name="message">Slack message to send</param>
        /// <exception cref="Exceptions.SlackMessageValidationException">
        /// Thrown if validation of the message fails, such as if a required field is missing.
        /// <para/>
        /// Uses <see cref="SlackMessage.Validate"/> to perform validation.
        /// </exception>
        Task SendAsync(SlackMessage message);
    }

    public class SlackClient : ISlackClient
    {
        private readonly string _webhookUrl;

        public SlackClient(string webhookUrl)
        {
            _webhookUrl = webhookUrl ?? throw new ArgumentNullException(nameof(webhookUrl));
        }

        public Task SendAsync(Action<ISlackMessageBuilder> configureBuilder)
        {
            if (configureBuilder == null) throw new ArgumentNullException(nameof(configureBuilder));

            var builder = new SlackMessageBuilder();
            configureBuilder(builder);
            var message = builder.Build();
            return SendAsync(message);
        }

        public async Task SendAsync(SlackMessage message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            message.ThrowIfInvalid();

            using (var httpClient = new HttpClient())
            {
                var jsonPayload = JsonConvert.SerializeObject(message);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                await httpClient.PostAsync(_webhookUrl, content);
            }
        }
    }
}
