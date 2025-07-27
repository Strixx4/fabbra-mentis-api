using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Ability
{
    [JsonProperty("dex")]
    public int? Dex { get; set; }

    [JsonProperty("wis")]
    public int? Wis { get; set; }

    [JsonProperty("cha")]
    public int? Cha { get; set; }

    [JsonProperty("choose")]
    public Choose Choose { get; set; } = new();

    [JsonProperty("str")]
    public int? Str { get; set; }

    [JsonProperty("int")]
    public int? Int { get; set; }

    [JsonProperty("con")]
    public int? Con { get; set; }

    [JsonProperty("static")]
    public Static? Static { get; set; }
}

public class Choose
{
    [JsonProperty("from")]
    public List<string> From { get; set; } = null!;

    [JsonProperty("count")]
    public int? Count { get; set; }

    [JsonProperty("amount")]
    public int? Amount { get; set; }
}
