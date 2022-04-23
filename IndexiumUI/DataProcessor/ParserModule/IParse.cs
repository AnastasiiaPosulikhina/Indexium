namespace IndexiumUI.DataProcessor.ParserModule;

public interface IParse
{
    public string Download(string URL);
    public List<string> Parse();
}