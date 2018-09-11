using System.Collections.Generic;
using SlackWebhook.Exceptions;

namespace SlackWebhook.Core
{
    /// <summary>
    /// Object can be validated
    /// </summary>
    public interface IValidateable
    {
        /// <summary>
        /// Validates the current state of the object (including any nested validateable members)
        /// </summary>
        /// <remarks>
        /// Will find all (if any) validation errors and populate <paramref name="validationErrors"/> with each
        /// </remarks>
        /// <param name="validationErrors">Validation errors (if any found)</param>
        /// <returns>True if the object is valid, false otherwise</returns>
        bool Validate(ref ICollection<ValidationError> validationErrors);
    }
}