namespace IndexiumUI.Parser;

public interface IParse
{
    public string Download(string URL);
    public List<string> Parse();
}