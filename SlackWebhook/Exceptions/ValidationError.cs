namespace SlackWebhook.Exceptions
{
    /// <summary>
    /// Validation error details
    /// </summary>
    public struct ValidationError
    {
        public ValidationError(string typeName, string propertyName, string error)
        {
            TypeName = typeName;
            PropertyName = propertyName;
            Error = error;
        }

        public string TypeName { get; }
        public string PropertyName { get; }
        public string Error { get; }

        public override string ToString()
        {
            return $"{TypeName}.{PropertyName} is invalid: {Error}";
        }
    }
}