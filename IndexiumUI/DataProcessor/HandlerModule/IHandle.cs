namespace IndexiumUI.DataProcessor.HandlerModule;

public interface IHandle
{
    public string? ExtractUsefulData(string data);
}