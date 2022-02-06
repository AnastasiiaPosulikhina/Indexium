namespace DataHandler;

public interface IHandle
{
    public string? ExtractUsefulData(string data);
    public void WriteDataToDataBase(string data);
}