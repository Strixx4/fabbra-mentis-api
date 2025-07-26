namespace FabbraMentis.JsonConverter.Object
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Baseitem
    {
        public string Name { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public int Page { get; set; } = 0;
        public List<string> ReprintedAs { get; set; } = [];
        public string Edition { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Rarity { get; set; } = string.Empty;
        public double Weight { get; set; } = 0.0;
        public string WeaponCategory { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public List<string> Property { get; set; } = [];
        public string Range { get; set; } = string.Empty;
        public int Reload { get; set; } = 0;
        public string Dmg1 { get; set; } = string.Empty;
        public string DmgType { get; set; } = string.Empty;
        public bool Firearm { get; set; } = false;
        public bool Weapon { get; set; } = false;
        public string AmmoType { get; set; } = string.Empty;
        public string ValueRarity { get; set; } = string.Empty;
        public List<string> Mastery { get; set; } = []; 
        
        public bool? Srd { get; set; } = null;
        public bool? BasicRules { get; set; } = null;
        
        public double? Value { get; set; } = null;
        public bool? Arrow { get; set; } = null;

        public List<object> Entries { get; set; } = [];
        public List<PackContent> PackContents { get; set; } = [];

        public bool? FreeRules2024 { get; set; } = null;
        public string Dmg2 { get; set; } = string.Empty;
        public bool? Axe { get; set; } = null;
        public bool? HasFluffImages { get; set; } = null;
        public bool? NeedleBlowgun { get; set; } = null;
        public bool? Bolt { get; set; } = null;
        public int? Ac { get; set; } = null;
        public bool? Armor { get; set; } = null;
        public string Strength { get; set; } = string.Empty;
        public bool? Stealth { get; set; } = null;
        public bool? Club { get; set; } = null;
        public string ScfType { get; set; } = string.Empty;
        public bool? Dagger { get; set; } = null;
        public bool? Sword { get; set; } = null;
        public bool? HasFluff { get; set; } = null;

        public List<string> MiscTags { get; set; } = [];
        public bool? BulletFirearm { get; set; } = null;
        public bool? Polearm { get; set; } = null;
    }

    public class Copy
    {
        public string Abbreviation { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
    }

    public class EntriesTemplate
    {
        public string Type { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Page { get; set; } = 0;
        public List<string> Entries { get; set; } = [];
    }

    public class Entry
    {
        public string Type { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<string> Entries { get; set; } = [];
        public int? Page { get; set; } = null;
    }

    public class ItemEntry
    {
        public string Name { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public List<object> EntriesTemplate { get; set; } = [];
    }

    public class ItemMastery
    {
        public string Name { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public int Page { get; set; } = 0;
        public bool FreeRules2024 { get; set; } = false;
        public List<string> Entries { get; set; } = [];
    }

    public class ItemProperty
    {
        public string Abbreviation { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public int Page { get; set; } = 0;
        public List<string> ReprintedAs { get; set; } = [];
        public string Template { get; set; } = string.Empty;
        public List<Entry> Entries { get; set; } = [];
        public bool? FreeRules2024 { get; set; } = null;
        public List<EntriesTemplate> EntriesTemplate { get; set; } = [];
        public string Name { get; set; } = string.Empty;
    }

    public class ItemType
    {
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public int Page { get; set; } = 0;
        public List<string> ReprintedAs { get; set; } = [];
        public List<object> Entries { get; set; } = [];
        public bool? FreeRules2024 { get; set; } = null;
        public Copy Copy { get; set; } = null;
        public List<string> EntriesTemplate { get; set; } = [];
    }

    public class ItemTypeAdditionalEntry
    {
        public string Name { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string AppliesTo { get; set; } = string.Empty;
        public List<object> Entries { get; set; } = [];
    }

    public class Meta
    {
        public List<string> InternalCopies { get; set; } = [];
    }

    public class PackContent
    {
        public string Item { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
    }

    public class Item_Property
    {
        public Meta Meta { get; set; } = null;
        public List<Baseitem> Baseitem { get; set; } = [];
        public List<ItemProperty> ItemProperty { get; set; } = [];
        public List<ItemType> ItemType { get; set; } = [];
        public List<ItemTypeAdditionalEntry> ItemTypeAdditionalEntries { get; set; } = [];
        public List<ItemEntry> ItemEntry { get; set; } = [];
        public List<ItemMastery> ItemMastery { get; set; } = [];
    }
}
