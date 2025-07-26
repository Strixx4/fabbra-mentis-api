using Common.Logger;

using FabbraMentis.JsonConverter.Object;

using Newtonsoft.Json;

Logger.LogStartProject("FabbraMentis.JsonConverter.ConsoleApp");

try
{
    // Item
    Logger.LogStartOperation("Item deserialization");

    var json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverter.ConsoleApp\json\items-base.json");
    var items = JsonConvert.DeserializeObject<ItemPropertyRoot>(json);

    Logger.Log($"Items deserialized successfully: {items is not null}");
    Logger.Log($"Deserialized {items?.Baseitem.Count} Base items");

    Logger.LogEndOperation("Item deserialization");

    // Races
    Logger.LogStartOperation("Races deserialization");

    json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverter.ConsoleApp\json\races.json");
    var races = JsonConvert.DeserializeObject<RacesRoot>(json);

    Logger.Log($"Races deserialized successfully: {races is not null}");
    Logger.Log($"Deserialized {races?.Race.Count} Base items");

    Logger.LogEndOperation("Races deserialization");
}
catch (Exception e)
{
    Logger.ErrorLog(e.Message, e);
}

Logger.LogEndProject("FabbraMentis.JsonConverter.ConsoleApp");
