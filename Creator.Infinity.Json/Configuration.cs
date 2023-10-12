
namespace Creator.Infinity.Json
{
    using Newtonsoft.Json;

    internal class Configuration
    {
        public static JsonSerializerSettings JsonConvertDefaultSettings()
        {
            return new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };
        }
    }
}