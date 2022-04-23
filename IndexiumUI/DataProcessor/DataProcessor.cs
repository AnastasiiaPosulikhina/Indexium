using IndexiumUI.DataProcessor.HandlerModule;
using IndexiumUI.DataProcessor.ParserModule;

namespace IndexiumUI.DataProcessor;

public class DataProcessor
{
    private readonly Parser _parser;
    private readonly Handler _handler;

    public DataProcessor(Parser parser, Handler handler)
    {
        _parser = parser;
        _handler = handler;
    }

    public List<string> ParseData()
    {
        return _parser.Parse();
    }

    public string? HandleData(string parsedData)
    {
        return _handler.ExtractUsefulData(parsedData);
    }
}
