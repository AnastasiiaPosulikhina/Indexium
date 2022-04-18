using System.Net;
using System.Text;

namespace Parser.Parser_Components;

public class YandexMapsParser : IParse
{
    private static string key = "https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b";
    //private static City chosenCity = getCity();
    private static string cityName = "Санкт-Петербург"; //getCityName() from IndexiumUI module
    public string Parse(string URL, string cityName)
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

    // Заполнение массива реализовать через цикл foreach
    public readonly List<string> DataToParseList = new List<string>()
    {
        // Школы
        $"{key}&text={cityName}, Адмиралтейский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, общеобразовательная школа&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, общеобразовательная школа&lang=ru_RU&results=500",

        // ВУЗы 
        $"{key}&text={cityName}, Адмиралтейский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, ВУЗ&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, ВУЗ&lang=ru_RU&results=500",
  
        // Детские сады
        $"{key}&text={cityName}, Адмиралтейский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, детский сад&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, детский сад&lang=ru_RU&results=500",
        
        // Медицинские учереждения
        $"{key}&text={cityName}, Адмиралтейский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, медицинское учреждение&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, медицинское учреждение&lang=ru_RU&results=500",
        
        // Продовольственные магазины
        $"{key}&text={cityName}, Адмиралтейский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, продуктовый магазин&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, продуктовый магазин&lang=ru_RU&results=500",
        
        // Тороговые центры 
        $"{key}&text={cityName}, Адмиралтейский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, торгово-развлекательный центр&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, торгово-развлекательный центр&lang=ru_RU&results=500",
        
        // Общественные места (музеи, достопримечательности)
        $"{key}&text={cityName}, Адмиралтейский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, музей&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Адмиралтейский район, достопримечательность&lang=ru_RU&results=500",
        
        // Зеленые/парковые зоны
        $"{key}&text={cityName}, Адмиралтейский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, парк&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, парк&lang=ru_RU&results=500",
        
        // Заповедные зоны
        $"{key}&text={cityName}, Адмиралтейский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, заповедная зона&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, заповедная зона&lang=ru_RU&results=500",
        
        // Промышленные зоны и предприятия
        $"{key}&text={cityName}, Адмиралтейский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Василеостровский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Выборгский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Калининский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кировский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Колпинский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красногвардейский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Красносельский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Кронштадтский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Курортный район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Московский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Невский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петроградский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Петродворцовый район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Приморский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Пушкинский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Фрунзенский район, промышленное предприятие, завод&lang=ru_RU&results=500",
        $"{key}&text={cityName}, Центральный район, промышленное предприятие, завод&lang=ru_RU&results=500",
    };
}