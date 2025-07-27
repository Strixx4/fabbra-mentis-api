using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Feat
{
    [JsonProperty("magic initiate; cleric|xphb")]
    public bool? MagicInitiateClericXphb { get; set; }

    [JsonProperty("crafter|xphb")]
    public bool? CrafterXphb { get; set; }

    [JsonProperty("magic initiate|phb")]
    public bool? MagicInitiatePhb { get; set; }

    [JsonProperty("skilled|xphb")]
    public bool? SkilledXphb { get; set; }

    [JsonProperty("alert|xphb")]
    public bool? AlertXphb { get; set; }

    [JsonProperty("musician|xphb")]
    public bool? MusicianXphb { get; set; }

    [JsonProperty("any")]
    public int? Any { get; set; }
}
