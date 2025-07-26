
using Newtonsoft.Json;

namespace FabbraMentis.JsonConverter.Object;

public class Baseitem
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("edition")]
    public string Edition { get; set; } = string.Empty;

    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("rarity")]
    public string Rarity { get; set; } = string.Empty;

    [JsonProperty("weight")]
    public double? Weight { get; set; }

    [JsonProperty("weaponCategory")]
    public string WeaponCategory { get; set; } = string.Empty;

    [JsonProperty("age")]
    public string Age { get; set; } = string.Empty;

    [JsonProperty("property")]
    public List<string> Property { get; set; } = [];

    [JsonProperty("range")]
    public string Range { get; set; } = string.Empty;

    [JsonProperty("reload")]
    public int? Reload { get; set; }

    [JsonProperty("dmg1")]
    public string Dmg1 { get; set; } = string.Empty;

    [JsonProperty("dmgType")]
    public string DmgType { get; set; } = string.Empty;

    [JsonProperty("firearm")]
    public bool? Firearm { get; set; }

    [JsonProperty("weapon")]
    public bool? Weapon { get; set; }

    [JsonProperty("ammoType")]
    public string AmmoType { get; set; } = string.Empty;

    [JsonProperty("valueRarity")]
    public string ValueRarity { get; set; } = string.Empty;

    [JsonProperty("mastery")]
    public List<string> Mastery { get; set; } = [];

    [JsonProperty("srd")]
    public bool? Srd { get; set; }

    [JsonProperty("basicRules")]
    public bool? BasicRules { get; set; }

    [JsonProperty("value")]
    public double? Value { get; set; }

    [JsonProperty("arrow")]
    public bool? Arrow { get; set; }

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("packContents")]
    public List<PackContent> PackContents { get; set; } = [];

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }

    [JsonProperty("dmg2")]
    public string Dmg2 { get; set; } = string.Empty;

    [JsonProperty("axe")]
    public bool? Axe { get; set; }

    [JsonProperty("hasFluffImages")]
    public bool? HasFluffImages { get; set; }

    [JsonProperty("needleBlowgun")]
    public bool? NeedleBlowgun { get; set; }

    [JsonProperty("bolt")]
    public bool? Bolt { get; set; }

    [JsonProperty("ac")]
    public int? Ac { get; set; }

    [JsonProperty("armor")]
    public bool? Armor { get; set; }

    [JsonProperty("strength")]
    public string Strength { get; set; } = string.Empty;

    [JsonProperty("stealth")]
    public bool? Stealth { get; set; }

    [JsonProperty("club")]
    public bool? Club { get; set; }

    [JsonProperty("scfType")]
    public string ScfType { get; set; } = string.Empty;

    [JsonProperty("dagger")]
    public bool? Dagger { get; set; }

    [JsonProperty("sword")]
    public bool? Sword { get; set; }

    [JsonProperty("hasFluff")]
    public bool? HasFluff { get; set; }

    [JsonProperty("miscTags")]
    public List<string> MiscTags { get; set; } = [];

    [JsonProperty("bulletFirearm")]
    public bool? BulletFirearm { get; set; }

    [JsonProperty("polearm")]
    public bool? Polearm { get; set; }
}

public class EntriesTemplate
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("entries")]
    public List<string> Entries { get; set; } = [];
}

public class Entry
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("entries")]
    public List<string> Entries { get; set; } = [];

    [JsonProperty("page")]
    public int? Page { get; set; }
}

public class ItemEntry
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("entriesTemplate")]
    public List<object> EntriesTemplate { get; set; } = [];
}

public class ItemMastery
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }

    [JsonProperty("entries")]
    public List<string> Entries { get; set; } = [];
}

public class ItemProperty
{
    [JsonProperty("abbreviation")]
    public string Abbreviation { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("template")]
    public string Template { get; set; } = string.Empty;

    [JsonProperty("entries")]
    public List<Entry> Entries { get; set; } = [];

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }

    [JsonProperty("entriesTemplate")]
    public List<EntriesTemplate> EntriesTemplate { get; set; } = [];

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;
}

public class ItemType
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("abbreviation")]
    public string Abbreviation { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("reprintedAs")]
    public List<string> ReprintedAs { get; set; } = [];

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];

    [JsonProperty("freeRules2024")]
    public bool? FreeRules2024 { get; set; }

    [JsonProperty("_copy")]
    public Copy Copy { get; set; } = null!;

    [JsonProperty("entriesTemplate")]
    public List<string> EntriesTemplate { get; set; } = [];
}

public class ItemTypeAdditionalEntry
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("source")]
    public string Source { get; set; } = string.Empty;

    [JsonProperty("appliesTo")]
    public string AppliesTo { get; set; } = string.Empty;

    [JsonProperty("entries")]
    public List<object> Entries { get; set; } = [];
}

public class PackContent
{
    [JsonProperty("item")]
    public string Item { get; set; } = string.Empty;

    [JsonProperty("quantity")]
    public int? Quantity { get; set; }
}

public class ItemPropertyRoot
{
    [JsonProperty("_meta")]
    public Meta Meta { get; set; } = null!;

    [JsonProperty("baseitem")]
    public List<Baseitem> Baseitem { get; set; } = [];

    [JsonProperty("itemProperty")]
    public List<ItemProperty> ItemProperty { get; set; } = [];

    [JsonProperty("itemType")]
    public List<ItemType> ItemType { get; set; } = [];

    [JsonProperty("itemTypeAdditionalEntries")]
    public List<ItemTypeAdditionalEntry> ItemTypeAdditionalEntries { get; set; } = [];

    [JsonProperty("itemEntry")]
    public List<ItemEntry> ItemEntry { get; set; } = [];

    [JsonProperty("itemMastery")]
    public List<ItemMastery> ItemMastery { get; set; } = [];
}