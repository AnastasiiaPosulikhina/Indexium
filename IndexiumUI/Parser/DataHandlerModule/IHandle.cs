namespace IndexiumUI.Parser.DataHandlerModule;

public interface IHandle
{
    public string? ExtractUsefulData(string data);
    public string PrepareDatabaseEntry(string data);
}