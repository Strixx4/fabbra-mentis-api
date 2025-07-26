using FabbraMentis.JsonConverter.Object;
using Newtonsoft.Json;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Starting");
Console.ForegroundColor = ConsoleColor.White;

try
{
    // Item
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Start Items");
    Console.ForegroundColor = ConsoleColor.White;
    
    var json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverter.ConsoleApp\json\items-base.json");
    var items = JsonConvert.DeserializeObject<ItemPropertyRoot>(json);
    
    Console.WriteLine($"Items deserialized successfully: {items is not null}");
    Console.WriteLine($"Deserialized {items?.Baseitem.Count} Base items");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("End Items");
    Console.ForegroundColor = ConsoleColor.White;
    // Races
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Start Races");
    Console.ForegroundColor = ConsoleColor.White;
    
    json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverter.ConsoleApp\json\races.json");
    var races = JsonConvert.DeserializeObject<RacesRoot>(json);
    
    Console.WriteLine($"Races deserialized successfully: {races is not null}");
    Console.WriteLine($"Deserialized {races?.Race.Count} Base items");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("End Races");
    Console.ForegroundColor = ConsoleColor.White;
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Message");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(e.Message);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Stack Trace");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(e.StackTrace);
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Ending");
