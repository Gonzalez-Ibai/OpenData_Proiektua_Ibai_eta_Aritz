using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenDataVR.Converters
{
    public class FlexibleNullableIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
                return reader.GetInt32();

            if (reader.TokenType == JsonTokenType.String)
            {
                var s = reader.GetString()?.Trim();

                // valores "rotos" del Excel / desconocidos
                if (string.IsNullOrEmpty(s) || s == "#¡VALOR!" || s == "?" || s == "???")
                    return null;

                // por si viene "123" como texto
                if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var v))
                    return v;

                return null;
            }

            if (reader.TokenType == JsonTokenType.Null)
                return null;

            return null;
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            if (value.HasValue) writer.WriteNumberValue(value.Value);
            else writer.WriteNullValue();
        }
    }
}
