
namespace Creator.Infinity.Json
{
    using Newtonsoft.Json;

    internal class Configuration
    {
        public static JsonSerializerSettings JsonConvertDefaultSettings()
        {
            return new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };
        }
    }
}