using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Condition
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("basicRules")]
    public bool? BasicRules { get; set; }

    [JsonProperty("otherSources")]
    public List<OtherSource> OtherSources { get; set; } = [];

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("hasFluffImages")]
    public bool? HasFluffImages { get; set; }

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }
}

public class Disease
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;
}

public class ConditionsDiseasesRoot
{
    [JsonProperty("condition")]
    public List<Condition> Condition { get; set; } = [];

    [JsonProperty("disease")]
    public List<Disease> Disease { get; set; } = [];

    [JsonProperty("status")]
    public List<Status> Status { get; set; } = [];
}

public class Status
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("basicRules")]
    public bool? BasicRules { get; set; }

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }
}
