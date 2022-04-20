using IndexiumUI.Parser.ParserComponents;

namespace IndexiumUI.Parser;

public class IndexiumParser
{
    private YandexMapsParser _yandexMapsParser;
    // другие типы парсеров

    public IndexiumParser(YandexMapsParser yandexMapsParser)
    {
        _yandexMapsParser = yandexMapsParser;
    }

    public List<string> Parse()
    {
        var databaseEntries = _yandexMapsParser.Parse();
        // другие типы парсеров, соединенные в databaseEntries с помощью Concat()
        return databaseEntries;
    }

}