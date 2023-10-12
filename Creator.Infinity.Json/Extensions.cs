
namespace Creator.Infinity.Json
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static string ToJson<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return dictionary == null ? "" : JsonConvert.SerializeObject(dictionary, Configuration.JsonConvertDefaultSettings());
        }

        public static string ToJson(this object obj)
        {
            return obj == null ? "" : JsonConvert.SerializeObject(obj, Configuration.JsonConvertDefaultSettings());
        }
    }
}
