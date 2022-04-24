// ReSharper disable InconsistentNaming
namespace IndexiumUI.DataProcessor.ParserModule;

public abstract class Parser: IParse
{
    public abstract string Download(string URL);

    public abstract List<string> Parse();

    public void ParseToFile(string path, string content)
    {
        File.WriteAllText(path, content); 
    }
}

