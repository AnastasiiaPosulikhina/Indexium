namespace IndexiumUI.Parser;

public abstract class Parser: IParse
{
    public abstract string Download(string URL);
    public abstract List<string> Parse();
}