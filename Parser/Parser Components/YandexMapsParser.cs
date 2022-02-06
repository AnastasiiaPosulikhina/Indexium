using System.Net;
using System.Text;

namespace Parser.Parser_Components;

public class YandexMapsParser : IParse
{
    public string Parse(string URL)
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

    public readonly List<string> DataToParseList = new List<string>()
    {
        // Школы
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, общеобразовательная школа&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, общеобразовательная школа&lang=ru_RU&results=500",

        // ВУЗы 
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, ВУЗ&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, ВУЗ&lang=ru_RU&results=500",
  
        // Детские сады
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, детский сад&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, детский сад&lang=ru_RU&results=500",
        
        // Медицинские учереждения
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, медицинское учреждение&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, медицинское учреждение&lang=ru_RU&results=500",
        
        // Продовольственные магазины
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, продуктовый магазин&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, продуктовый магазин&lang=ru_RU&results=500",
        
        // Тороговые центры 
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, торгово-развлекательный центр&lang=ru_RU&results=500",
        
        // Общественные места (музеи, достопримечательности)
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, музей&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, достопримечательность&lang=ru_RU&results=500",
        
        // Зеленые/парковые зоны
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, парк&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, парк&lang=ru_RU&results=500",
        
        // Заповедные зоны
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, заповедная зона&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, заповедная зона&lang=ru_RU&results=500",
        
        // Промышленные зоны и предприятия
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Василеостровский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Выборгский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Калининский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кировский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Колпинский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красногвардейский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Красносельский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Кронштадтский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Курортный район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Московский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Невский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петроградский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Петродворцовый район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Приморский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Пушкинский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Фрунзенский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Центральный район, промышленное предприятие, завод&lang=ru_RU&results=500",
    };
}