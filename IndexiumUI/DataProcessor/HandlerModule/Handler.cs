namespace IndexiumUI.DataProcessor.HandlerModule;

public abstract class Handler: IHandle
{
    public abstract string? ExtractUsefulData(string data);

    public Int32? ConvertToInt32(string data)
    {
        var isInt32 = Int32.TryParse(data, out int dataInt);
        
        if (isInt32)
            return dataInt;
        
        return null;
    } 

}