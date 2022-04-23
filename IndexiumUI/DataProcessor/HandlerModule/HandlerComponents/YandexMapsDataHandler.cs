using Newtonsoft.Json.Linq;

namespace IndexiumUI.DataProcessor.HandlerModule.HandlerComponents;

public class YandexMapsDataHandler: Handler
{
    public override string? ExtractUsefulData(string data)
    {
        var jsonData = JObject.Parse(data);
        return jsonData["properties"]?["ResponseMetaData"]?["SearchResponse"]?["found"]?.ToString();
    }
}