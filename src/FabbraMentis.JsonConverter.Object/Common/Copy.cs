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
    public List<Entries> Entries { get; set; } = null!;
}

public class Entries
{
    [JsonProperty("mode")]
    public string Mode { get; set; } = string.Empty;

    [JsonProperty("replace")]
    public object Replace { get; set; } = null!;

    [JsonProperty("items")]
    public object Items { get; set; } = null!;

    [JsonProperty("names")]
    public string Names { get; set; } = string.Empty;

    [JsonProperty("entries")]
    public List<object> EntryEntries { get; set; } = [];
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
