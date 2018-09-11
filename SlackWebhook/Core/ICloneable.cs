namespace SlackWebhook.Core
{
    /// <summary>
    /// Cloneable type
    /// </summary>
    /// <typeparam name="T">Type of clone</typeparam>
    public interface ICloneable<out T>
    {
        /// <summary>
        /// Creates new clone of this instance
        /// </summary>
        /// <returns>Cloned instance</returns>
        T Clone();
    }
}