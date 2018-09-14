using System;
using System.Collections.Generic;

namespace SlackWebhook.Exceptions
{
    /// <summary>
    /// Slack message validation exception
    /// </summary>
    [Serializable]
    public class SlackMessageValidationException : Exception
    {
        /// <summary>
        /// Validations errors
        /// </summary>
        public ICollection<ValidationError> ValidationErrors { get; }

        /// <summary>
        /// Create new validation exception
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="validationErrors">Validation errors</param>
        public SlackMessageValidationException(string message, IEnumerable<ValidationError> validationErrors) : base(message)
        {
            ValidationErrors = new List<ValidationError>(validationErrors);
        }
    }
}