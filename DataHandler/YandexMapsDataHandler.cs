using Newtonsoft.Json.Linq;

namespace DataHandler;

public class YandexMapsDataHandler : IHandle
{
    public string? ExtractUsefulData(string data)
    {
        var jsonData = JObject.Parse(data);
        return jsonData["properties"]?["ResponseMetaData"]?["SearchResponse"]?["found"]?.ToString();
    }

    public void WriteDataToDataBase(string? data)
    {
        // здесь должен быть метод записи данных в бд 
    }
}