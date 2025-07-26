using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class ConditionFluff
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("source")]
    public string Source { get; set; } = null!;

    [JsonProperty("images")]
    public List<Image> Images { get; set; } = [];
}

public class Href
{
    [JsonProperty("type")]
    public string Type { get; set; } = null!;

    [JsonProperty("path")]
    public string Path { get; set; } = null!;
}

public class Image
{
    [JsonProperty("type")]
    public string Type { get; set; } = null!;

    [JsonProperty("href")]
    public Href Href { get; set; } = null!;
}

public class ConditionsDiseasesRoot
{
    [JsonProperty("conditionFluff")]
    public List<ConditionFluff> ConditionFluff { get; set; } = [];
}
