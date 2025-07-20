// See https://aka.ms/new-console-template for more information

using FabbraMentis.JsonConverter.Object;
using Newtonsoft.Json;

Console.WriteLine("Starting");

try
{
    // Item
    var json = File.ReadAllText(@"C:\Users\andre\Repo\fabbra-mentis-api\src\FabbraMentis.JsonConverterConsoleApp\json\items-base.json");
    var itemProperty = JsonConvert.DeserializeObject<Item_Property>(json);
    
    Console.WriteLine($"Item_Property deserialized successfully: {itemProperty is not null}");
    Console.WriteLine($"Deserialized {itemProperty?.Baseitem.Count} Base items");
}
catch (Exception e)
{
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"StackTrace: {e.StackTrace}");
}
