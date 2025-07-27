using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class A
{
    [JsonProperty("item")]
    public string Item { get; set; } = string.Empty;

    [JsonProperty("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonProperty("quantity")]
    public int? Quantity { get; set; }

    [JsonProperty("value")]
    public int? Value { get; set; }
}

public class B
{
    [JsonProperty("value")]
    public int? Value { get; set; }
}

public class Background
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

    [JsonProperty("skillProficiencies")]
    public List<SkillProficiency> SkillProficiencies { get; set; } = [];

    [JsonProperty("languageProficiencies")]
    public List<LanguageProficiency> LanguageProficiencies { get; set; } = [];

    [JsonProperty("startingEquipment")]
    public List<StartingEquipment> StartingEquipment { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("hasFluff")]
    public bool? HasFluff { get; set; }

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }

    [JsonProperty("edition")]
    public string Edition { get; set; } = string.Empty;

    [JsonProperty("ability")]
    public List<Ability> Ability { get; set; } = [];

    [JsonProperty("feats")]
    public List<Feat> Feats { get; set; }

    [JsonProperty("toolProficiencies")]
    public List<ToolProficiency> ToolProficiencies { get; set; } = [];

    [JsonProperty("hasFluffImages")]
    public bool? HasFluffImages { get; set; }

    [JsonProperty("fromFeature")]
    public FromFeature FromFeature { get; set; } = null!;

    [JsonProperty("_copy")]
    public Copy Copy { get; set; } = null!;

    [JsonProperty("additionalSpells")]
    public List<AdditionalSpell> AdditionalSpells { get; set; } = [];

    [JsonProperty("additionalSources")]
    public List<AdditionalSource> AdditionalSources { get; set; } = [];

    [JsonProperty("prerequisite")]
    public List<Prerequisite> Prerequisite { get; set; } = [];

    [JsonProperty("skillToolLanguageProficiencies")]
    public List<SkillToolLanguageProficiency> SkillToolLanguageProficiencies { get; set; } = [];
}

public class C
{
    [JsonProperty("special")]
    public string Special { get; set; } = string.Empty;
}

public class Class
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("visible")]
    public bool? Visible { get; set; }
}

public class D
{
    [JsonProperty("special")]
    public string Special { get; set; }
}

public class FromFeature
{
    [JsonProperty("feats")]
    public bool? Feats { get; set; }
}

public class Level
{
    [JsonProperty("level")]
    public int? LevelEntry { get; set; }

    [JsonProperty("class")]
    public Class Class { get; set; }
}

public class Prerequisite
{
    [JsonProperty("level")]
    public Level Level { get; set; }
}

public class BackgroundsRoot
{
    [JsonProperty("_meta")]
    public Meta Meta { get; set; }

    [JsonProperty("background")]
    public List<Background> Background { get; set; }
}

public class StartingEquipment
{
    [JsonProperty("_")]
    public List<object> _List { get; set; }

    [JsonProperty("a")]
    public List<object> AList { get; set; }

    [JsonProperty("b")]
    public List<object> BList { get; set; }

    [JsonProperty("A")]
    public List<A> A { get; set; }

    [JsonProperty("B")]
    public List<B> B { get; set; }

    [JsonProperty("c")]
    public List<C> C { get; set; }

    [JsonProperty("d")]
    public List<D> D { get; set; }
}

public class Weighted
{
    [JsonProperty("from")]
    public List<string> From { get; set; }

    [JsonProperty("weights")]
    public List<int?> Weights { get; set; }
}
