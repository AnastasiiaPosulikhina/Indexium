using System.Net;
using System.Text;
using IndexiumUI.Entities;
using IndexiumUI.Parser.DataHandlerModule.DataHandlerComponents;

namespace IndexiumUI.Parser.ParserComponents;

public class YandexMapsParser : Parser
{
    private const string Key = "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b";
    private readonly string[] _objectsToParse =
    {
        "детский сад",
        "общеобразовательная школа",
        "ВУЗ",
        "медицинское учреждение",
        "продуктовый магазин",
        "торгово-развлекательный центр",
        "промышленное предприятие, завод",
        "парк",
        "заповедная зона"
    };

    private readonly City _chosenCity;
    private readonly YandexMapsDataHandler _yandexMapsDataHandler;

    public YandexMapsParser(City chosenCity, YandexMapsDataHandler yandexMapsDataHandler)
    {
        _chosenCity = chosenCity;
        _yandexMapsDataHandler = yandexMapsDataHandler;
    }

    public override string Download(string URL)
    {
        StringBuilder result = new StringBuilder();
        
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Accept = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            result.Append(reader.ReadToEnd());
            response.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("The exception was thrown: " + ex.Message);
        }

        return result.ToString();
    }

    public override List<string> Parse()
    {
        var databaseEntries = new List<string>();

        foreach (var district in _chosenCity.Districts)
        {
            foreach (var objectToParse in _objectsToParse)
            {
                var parsedData = Download($"{Key}&text={_chosenCity.Name}, {district.Name}, {objectToParse}&lang=ru_RU&results=500");
                var handledData = _yandexMapsDataHandler.ExtractUsefulData(parsedData);
                databaseEntries.Add(_yandexMapsDataHandler.PrepareDatabaseEntry(handledData)); // заменить на модуль, отвечающий за бд
            }
        }

        return databaseEntries;
    }
}