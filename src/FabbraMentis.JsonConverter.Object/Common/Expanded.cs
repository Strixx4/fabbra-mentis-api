using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Expanded
{
    [JsonProperty("s1")]
    public List<string> S1 { get; set; } = null!;

    [JsonProperty("s2")]
    public List<string> S2 { get; set; } = null!;

    [JsonProperty("s3")]
    public List<string> S3 { get; set; } = null!;

    [JsonProperty("s4")]
    public List<string> S4 { get; set; } = null!;

    [JsonProperty("s5")]
    public List<string> S5 { get; set; } = null!;
}
