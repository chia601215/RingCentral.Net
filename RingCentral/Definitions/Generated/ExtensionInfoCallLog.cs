using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionInfoCallLog : Serializable
    {
        // Internal identifier of an extension
        public string id;
        // Canonical URI of an extension
        public string uri;
    }
}