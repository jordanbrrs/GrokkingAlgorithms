using Newtonsoft.Json;

namespace Serializer
{
    internal class TranslateJsonConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            //TO DO: verificar como acessar o atributo
            if (objectType == typeof(string))
            {
                return true;
            }

            return false;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            string? text = value as string;
            if (text != null)
            {
                string value2;
                if (text == "Hot")
                {
                    value2 = "Quente";
                    writer.WriteValue(value2);
                }
                else
                {
                    writer.WriteValue(text);
                }
            }
        }
    }
}
