namespace FabbraMentis.JsonConverter.Object;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Baseitem
    {
        public string name { get; set; }
        public string source { get; set; }
        public int page { get; set; }
        public List<string> reprintedAs { get; set; }
        public string edition { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public double weight { get; set; }
        public string weaponCategory { get; set; }
        public string age { get; set; }
        public List<string> property { get; set; }
        public string range { get; set; }
        public int reload { get; set; }
        public string dmg1 { get; set; }
        public string dmgType { get; set; }
        public bool firearm { get; set; }
        public bool weapon { get; set; }
        public string ammoType { get; set; }
        public string valueRarity { get; set; }
        public List<string> mastery { get; set; }
        public bool? srd { get; set; }
        public bool? basicRules { get; set; }
        public int? value { get; set; }
        public bool? arrow { get; set; }
        public List<object> entries { get; set; }
        public List<PackContent> packContents { get; set; }
        public bool? freeRules2024 { get; set; }
        public string dmg2 { get; set; }
        public bool? axe { get; set; }
        public bool? hasFluffImages { get; set; }
        public bool? needleBlowgun { get; set; }
        public bool? bolt { get; set; }
        public int? ac { get; set; }
        public bool? armor { get; set; }
        public string strength { get; set; }
        public bool? stealth { get; set; }
        public bool? club { get; set; }
        public string scfType { get; set; }
        public bool? dagger { get; set; }
        public bool? sword { get; set; }
        public bool? hasFluff { get; set; }
        public List<string> miscTags { get; set; }
        public bool? bulletFirearm { get; set; }
        public bool? polearm { get; set; }
    }

    public class Copy
    {
        public string abbreviation { get; set; }
        public string source { get; set; }
    }

    public class EntriesTemplate
    {
        public string type { get; set; }
        public string name { get; set; }
        public int page { get; set; }
        public List<string> entries { get; set; }
    }

    public class Entry
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<string> entries { get; set; }
        public int? page { get; set; }
    }

    public class ItemEntry
    {
        public string name { get; set; }
        public string source { get; set; }
        public List<object> entriesTemplate { get; set; }
    }

    public class ItemMastery
    {
        public string name { get; set; }
        public string source { get; set; }
        public int page { get; set; }
        public bool freeRules2024 { get; set; }
        public List<string> entries { get; set; }
    }

    public class ItemProperty
    {
        public string abbreviation { get; set; }
        public string source { get; set; }
        public int page { get; set; }
        public List<string> reprintedAs { get; set; }
        public string template { get; set; }
        public List<Entry> entries { get; set; }
        public bool? freeRules2024 { get; set; }
        public List<EntriesTemplate> entriesTemplate { get; set; }
        public string name { get; set; }
    }

    public class ItemType
    {
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string source { get; set; }
        public int page { get; set; }
        public List<string> reprintedAs { get; set; }
        public List<object> entries { get; set; }
        public bool? freeRules2024 { get; set; }
        public Copy _copy { get; set; }
        public List<string> entriesTemplate { get; set; }
    }

    public class ItemTypeAdditionalEntry
    {
        public string name { get; set; }
        public string source { get; set; }
        public string appliesTo { get; set; }
        public List<object> entries { get; set; }
    }

    public class Meta
    {
        public List<string> internalCopies { get; set; }
    }

    public class PackContent
    {
        public string item { get; set; }
        public int quantity { get; set; }
    }

    public class Root
    {
        public Meta _meta { get; set; }
        public List<Baseitem> baseitem { get; set; }
        public List<ItemProperty> itemProperty { get; set; }
        public List<ItemType> itemType { get; set; }
        public List<ItemTypeAdditionalEntry> itemTypeAdditionalEntries { get; set; }
        public List<ItemEntry> itemEntry { get; set; }
        public List<ItemMastery> itemMastery { get; set; }
    }

