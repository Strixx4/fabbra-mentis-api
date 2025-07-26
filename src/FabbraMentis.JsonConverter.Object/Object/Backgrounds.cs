using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class BackgroundFluff
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("source")]
    public string Source { get; set; } = null!;

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("images")]
    public List<Image> Images { get; set; } = [];
}

public class BackgroundsRoot
{
    [JsonProperty("_meta")]
    public Meta Meta { get; set; }

    [JsonProperty("backgroundFluff")]
    public List<BackgroundFluff> BackgroundFluff { get; set; } = [];
}
