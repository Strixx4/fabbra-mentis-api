using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class AdditionalSource
{
    [JsonProperty("source")]
    public string Source { get; set; } = null!;

    [JsonProperty("page")]
    public int? Page { get; set; }
}

public class AdditionalSpell
{
    [JsonProperty("innate")]
    public Innate Innate { get; set; } = null!;

    [JsonProperty("ability")]
    public object Ability { get; set; } = null!;

    [JsonProperty("known")]
    public Known Known { get; set; } = null!;

    [JsonProperty("expanded")]
    public Expanded Expanded { get; set; } = null!;
}
