
namespace Creator.Infinity.Json
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static string ToJson<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, JsonSerializerSettings? jsonSerializerSettings = null)
        {
            return dictionary == null ? "" : JsonConvert.SerializeObject(dictionary, jsonSerializerSettings ?? Configuration.JsonConvertDefaultSettings());
        }

        public static string ToJson(this object obj, JsonSerializerSettings? jsonSerializerSettings = null)
        {
            return obj == null ? "" : JsonConvert.SerializeObject(obj, jsonSerializerSettings ?? Configuration.JsonConvertDefaultSettings());
        }
    }
}
