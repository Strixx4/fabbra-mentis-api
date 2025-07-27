using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Copy
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    // Used for Races, Backgrounds
    [JsonProperty("_mod")]
    public Mod? Mod { get; set; }
}

public class Mod
{
    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = null!;
}

public class Items
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];
}
