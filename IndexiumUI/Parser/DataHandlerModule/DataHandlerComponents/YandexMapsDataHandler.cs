using Newtonsoft.Json.Linq;

namespace IndexiumUI.Parser.DataHandlerModule.DataHandlerComponents;

public class YandexMapsDataHandler : IHandle
{
    public string? ExtractUsefulData(string data)
    {
        var jsonData = JObject.Parse(data);
        return jsonData["properties"]?["ResponseMetaData"]?["SearchResponse"]?["found"]?.ToString();
    }

    public string PrepareDatabaseEntry(string? data)
    {
        return ""; // здесь должен быть метод записи данных в бд
    }
}