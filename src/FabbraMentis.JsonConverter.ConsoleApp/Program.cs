using Common.Logger;

using FabbraMentis.JsonConverter.Object;

using Newtonsoft.Json;

Logger.LogStartProject("ConsoleApp");

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

    // Actions
    Logger.LogStartOperation("Actions deserialization");

    json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverter.ConsoleApp\json\actions.json");
    var actions = JsonConvert.DeserializeObject<ActionsRoot>(json);
    Logger.Log($"Actions deserialized successfully: {actions is not null}");
    Logger.Log($"Deserialized {actions?.Action.Count} Base items");

    Logger.LogEndOperation("Actions deserialization");

    // Conditions and Diseases
    Logger.LogStartOperation("Conditions and Diseases deserialization");

    json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverter.ConsoleApp\json\conditions-diseases.json");
    var cd = JsonConvert.DeserializeObject<ConditionsDiseasesRoot>(json);
    Logger.Log($"Conditions and Diseases deserialized successfully: {cd is not null}");
    Logger.Log($"Deserialized {cd?.ConditionFluff.Count} Base items");

    Logger.LogEndOperation("Conditions and Diseases deserialization");
}
catch (Exception e)
{
    Logger.ErrorLog(e.Message, e);
}

Logger.LogEndProject("ConsoleApp");
