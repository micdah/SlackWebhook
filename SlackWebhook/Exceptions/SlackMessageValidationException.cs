using System;
using System.Collections.Generic;

namespace SlackWebhook.Exceptions
{
    [Serializable]
    public class SlackMessageValidationException : Exception
    {
        public ICollection<ValidationError> ValidationErrors { get; }

        public SlackMessageValidationException(string message, IEnumerable<ValidationError> validationErrors) : base(message)
        {
            ValidationErrors = new List<ValidationError>(validationErrors);
        }
    }
}