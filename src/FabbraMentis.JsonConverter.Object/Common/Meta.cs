using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Meta
{
    [JsonProperty("internalCopies")]
    public List<string> InternalCopies { get; set; } = [];
}
