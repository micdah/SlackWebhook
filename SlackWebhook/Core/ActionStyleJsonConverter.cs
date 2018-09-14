using System;
using Newtonsoft.Json;
using SlackWebhook.Enums;

namespace SlackWebhook.Core
{
    /// <summary>
    /// <see cref="ActionStyle"/> json converter
    /// </summary>
    public class ActionStyleJsonConverter : JsonConverter<ActionStyle?>
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, ActionStyle? value, JsonSerializer serializer)
        {
            switch (value)
            {
                case null:
                    writer.WriteNull();
                    break;
                case ActionStyle.Primary:
                    writer.WriteValue("primary");
                    break;
                case ActionStyle.Danger:
                    writer.WriteValue("danger");
                    break;
                default:
                    throw new JsonSerializationException($"Unknown {nameof(ActionStyle)} value {value}");
            }
        }

        /// <inheritdoc />
        public override ActionStyle? ReadJson(JsonReader reader, Type objectType, ActionStyle? existingValue,
            bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            
            if (reader.TokenType != JsonToken.String)
                throw new JsonSerializationException(
                    $"Unexpected token {reader.TokenType} when parsing {nameof(ActionStyle)}");
            
            switch (reader.Value.ToString())
            {
                case "primary": return ActionStyle.Primary;
                case "danger": return ActionStyle.Danger;
                default:
                    throw new JsonSerializationException(
                        $"Error converting value {reader.Value} to {nameof(ActionStyle)}");
            }
        }
    }
}