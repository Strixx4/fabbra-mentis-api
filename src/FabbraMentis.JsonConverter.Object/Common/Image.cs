using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Image
{
    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("href")]
    public Href? Href { get; set; }

    [JsonProperty("credit")]
    public string? Credit { get; set; }

    [JsonProperty("width")]
    public int? Width { get; set; }

    [JsonProperty("height")]
    public int? Height { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("altText")]
    public string? AltText { get; set; }
}

public class Href
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("path")]
    public string Path { get; set; } = string.Empty;
}
