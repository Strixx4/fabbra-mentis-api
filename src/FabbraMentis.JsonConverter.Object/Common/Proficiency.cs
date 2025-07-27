using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class SkillProficiency
{
    [JsonProperty("insight")]
    public bool? Insight { get; set; }

    [JsonProperty("religion")]
    public bool? Religion { get; set; }

    [JsonProperty("history")]
    public bool? History { get; set; }

    [JsonProperty("survival")]
    public bool? Survival { get; set; }

    [JsonProperty("investigation")]
    public bool? Investigation { get; set; }

    [JsonProperty("persuasion")]
    public bool? Persuasion { get; set; }

    [JsonProperty("nature")]
    public bool? Nature { get; set; }

    [JsonProperty("choose")]
    public Choose? Choose { get; set; }

    [JsonProperty("acrobatics")]
    public bool? Acrobatics { get; set; }

    [JsonProperty("athletics")]
    public bool? Athletics { get; set; }

    [JsonProperty("intimidation")]
    public bool? Intimidation { get; set; }

    [JsonProperty("deception")]
    public bool? Deception { get; set; }

    [JsonProperty("animal handling")]
    public bool? AnimalHandling { get; set; }

    [JsonProperty("perception")]
    public bool? Perception { get; set; }

    [JsonProperty("performance")]
    public bool? Performance { get; set; }

    [JsonProperty("sleight of hand")]
    public bool? SleightOfHand { get; set; }
}

public class SkillToolLanguageProficiency
{
    [JsonProperty("anyLanguage")]
    public int? AnyLanguage { get; set; }

    [JsonProperty("anyTool")]
    public int? AnyTool { get; set; }

    [JsonProperty("choose")]
    public List<Choose>? Choose { get; set; }
}

public class ToolProficiency
{
    [JsonProperty("any")]
    public int? Any { get; set; }

    [JsonProperty("choose")]
    public Choose? Choose { get; set; }

    [JsonProperty("anyArtisansTool")]
    public int? AnyArtisansTool { get; set; }

    [JsonProperty("tinker's tools")]
    public bool? TinkerSTools { get; set; }

    [JsonProperty("calligrapher's supplies")]
    public bool? CalligrapherSSupplies { get; set; }

    [JsonProperty("herbalism kit")]
    public bool? HerbalismKit { get; set; }

    [JsonProperty("vehicles (land)")]
    public bool? VehiclesLand { get; set; }

    [JsonProperty("disguise kit")]
    public bool? DisguiseKit { get; set; }

    [JsonProperty("anyGamingSet")]
    public int? AnyGamingSet { get; set; }

    [JsonProperty("anyMusicalInstrument")]
    public int? AnyMusicalInstrument { get; set; }

    [JsonProperty("forgery kit")]
    public bool? ForgeryKit { get; set; }

    [JsonProperty("thieves' tools")]
    public bool? ThievesTools { get; set; }

    [JsonProperty("vehicles (water)")]
    public bool? VehiclesWater { get; set; }
}

public class LanguageProficiency
{
    [JsonProperty("celestial")]
    public bool? Celestial;

    [JsonProperty("auran")]
    public bool? Auran { get; set; }

    [JsonProperty("common")]
    public bool? Common { get; set; }

    [JsonProperty("other")]
    public bool? Other { get; set; }

    [JsonProperty("anyStandard")]
    public int? AnyStandard { get; set; }

    [JsonProperty("goblin")]
    public bool? Goblin { get; set; }

    [JsonProperty("sylvan")]
    public bool? Sylvan { get; set; }

    [JsonProperty("draconic")]
    public bool? Draconic { get; set; }

    [JsonProperty("dwarvish")]
    public bool? Dwarvish { get; set; }

    [JsonProperty("elvish")]
    public bool? Elvish { get; set; }

    [JsonProperty("giant")]
    public bool? Giant { get; set; }

    [JsonProperty("primordial")]
    public bool? Primordial { get; set; }

    [JsonProperty("undercommon")]
    public bool? Undercommon { get; set; }

    [JsonProperty("aquan")]
    public bool? Aquan { get; set; }

    [JsonProperty("gnomish")]
    public bool? Gnomish { get; set; }

    [JsonProperty("choose")]
    public Choose? Choose { get; set; }
}
