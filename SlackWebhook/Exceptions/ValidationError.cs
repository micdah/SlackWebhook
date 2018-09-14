namespace SlackWebhook.Exceptions
{
    /// <summary>
    /// Validation error details
    /// </summary>
    public struct ValidationError
    {
        /// <summary>
        /// Create new validation error
        /// </summary>
        /// <param name="typeName">Type where validation error occurred</param>
        /// <param name="propertyName">Property which failed validation</param>
        /// <param name="error">Validation error</param>
        public ValidationError(string typeName, string propertyName, string error)
        {
            TypeName = typeName;
            PropertyName = propertyName;
            Error = error;
        }

        /// <summary>
        /// Type where validation error occurred
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// Property which failed validation
        /// </summary>
        public string PropertyName { get; }

        /// <summary>
        /// Validation error
        /// </summary>
        public string Error { get; }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{TypeName}.{PropertyName} is invalid: {Error}";
        }
    }
}