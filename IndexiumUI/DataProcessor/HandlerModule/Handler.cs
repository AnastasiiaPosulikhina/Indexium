namespace IndexiumUI.DataProcessor.HandlerModule;

public abstract class Handler: IHandle
{
    public abstract string? ExtractUsefulData(string data);

    public Int32 ConvertToInt32(string data)
    {
        return 0;
    } 

}