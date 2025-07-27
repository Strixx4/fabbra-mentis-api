using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class _1
{
    [JsonProperty("rest")]
    public Rest Rest { get; set; } = new();
}

public class _3
{
    [JsonProperty("daily")]
    public Daily Daily { get; set; } = new();
}

public class Abstract
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("source")]
    public string Source { get; set; } = null!;

    [JsonProperty("_mod")]
    public Mod Mod { get; set; } = null!;
}

public class Age
{
    [JsonProperty("mature")]
    public int? Mature { get; set; }

    [JsonProperty("max")]
    public int? Max { get; set; }
}

public class ArmorProficiency
{
    [JsonProperty("light")]
    public bool? Light { get; set; }

    [JsonProperty("medium")]
    public bool? Medium { get; set; }
}

public class Daily
{
    [JsonProperty("1")]
    public List<string> _1 { get; set; } = null!;
}

public class HeightAndWeight
{
    [JsonProperty("weightMod")]
    public string WeightMod = null!;

    [JsonProperty("baseHeight")]
    public int? BaseHeight { get; set; }

    [JsonProperty("heightMod")]
    public string HeightMod { get; set; } = string.Empty;

    [JsonProperty("baseWeight")]
    public int? BaseWeight { get; set; }
}

public class Implementation
{
    [JsonProperty("_variables")]
    public Variables Variables { get; set; } = null!;

    [JsonProperty("resist")]
    public List<string> Resist { get; set; } = [];
}

public class Innate
{
    [JsonProperty("3")]
    public object _3 { get; set; } = null!;

    [JsonProperty("5")]
    public object _5 { get; set; } = null!;

    [JsonProperty("1")]
    public object _1 { get; set; } = null!;
}

public class Known
{
    [JsonProperty("1")]
    public object _1 { get; set; } = null!;
}

public class OtherSource
{
    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }
}

public class Overwrite
{
    [JsonProperty("ability")]
    public bool? Ability { get; set; }

    [JsonProperty("traitTags")]
    public bool? TraitTags { get; set; }

    [JsonProperty("languageProficiencies")]
    public bool? LanguageProficiencies { get; set; }
}

public class Race
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("size")]
    public List<string> Size { get; set; } = [];

    [JsonProperty("speed")]
    public object Speed { get; set; } = null!;

    [JsonProperty("ability")]
    public List<Ability> Ability { get; set; } = [];

    [JsonProperty("traitTags")]
    public List<string> TraitTags { get; set; } = [];

    [JsonProperty("languageProficiencies")]
    public List<LanguageProficiency> LanguageProficiencies { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("otherSources")]
    public List<OtherSource> OtherSources { get; set; } = [];

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("age")]
    public Age Age { get; set; } = null!;

    [JsonProperty("soundClip")]
    public SoundClip SoundClip { get; set; } = null!;

    [JsonProperty("hasFluff")]
    public bool? HasFluff { get; set; }

    [JsonProperty("hasFluffImages")]
    public bool? HasFluffImages { get; set; }

    [JsonProperty("lineage")]
    public object Lineage { get; set; } = null!;

    [JsonProperty("additionalSpells")]
    public List<AdditionalSpell> AdditionalSpells { get; set; } = [];

    [JsonProperty("darkvision")]
    public int? Darkvision { get; set; }

    [JsonProperty("resist")]
    public List<object> Resist { get; set; } = [];

    [JsonProperty("_versions")]
    public List<Version> Versions { get; set; } = [];

    [JsonProperty("heightAndWeight")]
    public HeightAndWeight HeightAndWeight { get; set; } = null!;

    [JsonProperty("edition")]
    public string Edition { get; set; } = string.Empty;

    [JsonProperty("creatureTypes")]
    public List<string> CreatureTypes { get; set; } = [];

    [JsonProperty("sizeEntry")]
    public SizeEntry SizeEntry { get; set; } = null!;

    [JsonProperty("skillProficiencies")]
    public List<SkillProficiency> SkillProficiencies { get; set; } = [];

    [JsonProperty("creatureTypeTags")]
    public List<string> CreatureTypeTags { get; set; } = [];

    [JsonProperty("toolProficiencies")]
    public List<ToolProficiency> ToolProficiencies { get; set; } = [];

    [JsonProperty("conditionImmune")]
    public List<string> ConditionImmune { get; set; } = [];

    [JsonProperty("_copy")]
    public Copy Copy { get; set; } = null!;

    [JsonProperty("feats")]
    public List<Feat> Feats { get; set; } = [];

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("basicRules")]
    public bool? BasicRules { get; set; }

    [JsonProperty("weaponProficiencies")]
    public List<WeaponProficiency> WeaponProficiencies { get; set; } = [];

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }

    [JsonProperty("additionalSources")]
    public List<AdditionalSource> AdditionalSources { get; set; } = [];
}

public class Rest
{
    [JsonProperty("1")]
    public List<string> _1 { get; set; } = [];
}

public class RacesRoot
{
    [JsonProperty("_meta")]
    public Meta Meta { get; set; } = null!;

    [JsonProperty("race")]
    public List<Race> Race { get; set; } = [];

    [JsonProperty("subrace")]
    public List<Subrace> Subrace { get; set; } = [];
}

public class SizeEntry
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("entries")]
    public List<string> Entries { get; set; } = [];
}

public class SoundClip
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("path")]
    public string Path { get; set; } = string.Empty;
}

public class Subrace
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("raceName")]
    public string RaceName { get; set; } = string.Empty;

    [JsonProperty("raceSource")]
    public string RaceSource { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("ability")]
    public List<Ability> Ability { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("hasFluff")]
    public bool? HasFluff { get; set; }

    [JsonProperty("hasFluffImages")]
    public bool? HasFluffImages { get; set; }

    [JsonProperty("skillProficiencies")]
    public List<SkillProficiency> SkillProficiencies { get; set; } = [];

    [JsonProperty("speed")]
    public object Speed { get; set; } = null!;

    [JsonProperty("traitTags")]
    public List<string> TraitTags { get; set; } = [];

    [JsonProperty("toolProficiencies")]
    public List<ToolProficiency> ToolProficiencies { get; set; } = [];

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("_versions")]
    public List<Version> Versions { get; set; } = [];

    [JsonProperty("darkvision")]
    public int? Darkvision { get; set; }

    [JsonProperty("resist")]
    public List<string> Resist { get; set; } = [];

    [JsonProperty("overwrite")]
    public Overwrite Overwrite { get; set; } = null!;

    [JsonProperty("otherSources")]
    public List<OtherSource> OtherSources { get; set; } = [];

    [JsonProperty("languageProficiencies")]
    public List<LanguageProficiency> LanguageProficiencies { get; set; } = [];

    [JsonProperty("additionalSpells")]
    public List<AdditionalSpell> AdditionalSpells { get; set; } = [];

    [JsonProperty("basicRules")]
    public bool? BasicRules { get; set; }

    [JsonProperty("heightAndWeight")]
    public HeightAndWeight HeightAndWeight { get; set; } = null!;

    [JsonProperty("armorProficiencies")]
    public List<ArmorProficiency> ArmorProficiencies { get; set; } = [];

    [JsonProperty("alias")]
    public List<string> Alias { get; set; } = [];

    [JsonProperty("weaponProficiencies")]
    public List<WeaponProficiency> WeaponProficiencies { get; set; } = [];

    [JsonProperty("skillToolLanguageProficiencies")]
    public List<SkillToolLanguageProficiency> SkillToolLanguageProficiencies { get; set; } = [];

    [JsonProperty("age")]
    public Age Age { get; set; } = null!;
}

public class Variables
{
    [JsonProperty("color")]
    public string Color { get; set; } = string.Empty;

    [JsonProperty("damageType")]
    public string DamageType { get; set; } = string.Empty;

    [JsonProperty("area")]
    public string Area { get; set; } = string.Empty;

    [JsonProperty("savingThrow")]
    public string SavingThrow { get; set; } = string.Empty;
}

public class Version
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("_mod")]
    public Mod Mod { get; set; } = null!;

    [JsonProperty("traitTags")]
    public List<string> TraitTags { get; set; } = [];

    [JsonProperty("skillProficiencies")]
    public object SkillProficiencies { get; set; } = null!;

    [JsonProperty("darkvision")]
    public int? Darkvision { get; set; }

    [JsonProperty("_abstract")]
    public Abstract Abstract { get; set; } = null!;

    [JsonProperty("_implementations")]
    public List<Implementation> Implementations { get; set; } = [];

    [JsonProperty("additionalSpells")]
    public List<AdditionalSpell> AdditionalSpells { get; set; } = [];

    [JsonProperty("speed")]
    public object? Speed { get; set; }
}

public class WeaponProficiency
{
    [JsonProperty("battleaxe|phb")]
    public bool? BattleaxePhb { get; set; }

    [JsonProperty("handaxe|phb")]
    public bool? HandaxePhb { get; set; }

    [JsonProperty("light hammer|phb")]
    public bool? LightHammerPhb { get; set; }

    [JsonProperty("warhammer|phb")]
    public bool? WarhammerPhb { get; set; }

    [JsonProperty("longsword|phb")]
    public bool? LongswordPhb { get; set; }

    [JsonProperty("shortsword|phb")]
    public bool? ShortswordPhb { get; set; }

    [JsonProperty("shortbow|phb")]
    public bool? ShortbowPhb { get; set; }

    [JsonProperty("longbow|phb")]
    public bool? LongbowPhb { get; set; }

    [JsonProperty("firearms")]
    public bool? Firearms { get; set; }

    [JsonProperty("rapier|phb")]
    public bool? RapierPhb { get; set; }

    [JsonProperty("hand crossbow|phb")]
    public bool? HandCrossbowPhb { get; set; }

    [JsonProperty("spear|phb")]
    public bool? SpearPhb { get; set; }

    [JsonProperty("trident|phb")]
    public bool? TridentPhb { get; set; }

    [JsonProperty("light crossbow|phb")]
    public bool? LightCrossbowPhb { get; set; }

    [JsonProperty("net|phb")]
    public bool? NetPhb { get; set; }

    [JsonProperty("greatsword|phb")]
    public bool? GreatswordPhb { get; set; }
}
