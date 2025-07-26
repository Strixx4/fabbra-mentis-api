using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Action
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("source")]
    public string Source { get; set; } = null!;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("basicRules")]
    public bool? BasicRules { get; set; }

    [JsonProperty("time")]
    public List<object> Time { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("reprintedAs")]
    public List<object> ReprintedAs { get; set; } = [];

    [JsonProperty("seeAlsoAction")]
    public List<string> SeeAlsoAction { get; set; } = [];

    [JsonProperty("fromVariant")]
    public string FromVariant { get; set; } = null!;

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }
}

public class ActionsRoot
{
    [JsonProperty("action")]
    public List<Action> Action { get; set; } = [];
}
