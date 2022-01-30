namespace Parser;

public class Converter
{
    public void ConvertToJson(string jsonPath, string content)
    {
        File.WriteAllText(jsonPath, content);
    }
}