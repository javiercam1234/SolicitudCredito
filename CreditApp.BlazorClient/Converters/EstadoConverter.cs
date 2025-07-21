using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class EstadoConverter : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetInt32().ToString();
        }
        else if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        else
        {
            throw new JsonException("Unexpected token type.");
        }
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}
