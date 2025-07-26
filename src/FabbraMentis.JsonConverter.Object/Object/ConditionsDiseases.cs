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

public class ConditionsDiseasesRoot
{
    [JsonProperty("conditionFluff")]
    public List<ConditionFluff> ConditionFluff { get; set; } = [];
}
