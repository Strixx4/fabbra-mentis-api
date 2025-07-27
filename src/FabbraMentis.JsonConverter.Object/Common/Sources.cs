using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class OtherSource
{
    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }
}
