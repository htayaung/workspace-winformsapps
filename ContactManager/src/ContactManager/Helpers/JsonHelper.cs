using System.Text.Json;

namespace ContactManager
{
    public class JsonHelper
    {
        public static string Serialize(Object value)
        {
            var json = JsonSerializer.Serialize(value);
            return json;
        }
    }
}
