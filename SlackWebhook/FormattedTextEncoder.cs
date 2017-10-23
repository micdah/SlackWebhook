namespace SlackWebhook
{
    /// <summary>
    /// Handles escaping characters which the Slack webhook expects to be HTML 
    /// encoded.<para/>
    /// See https://api.slack.com/docs/message-formatting#how_to_escape_characters
    /// for more.
    /// </summary>
    internal class FormattedTextEncoder
    {
        public string Encode(string unencoded)
        {
            if (string.IsNullOrEmpty(unencoded))
                return unencoded;

            // As noted on Slack documentation, only these three characters 
            // should be replaced, we should NOT use regular HTML entity
            // encoding, which is why we do this simple replace.

            return unencoded
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;");
        }
    }
}
