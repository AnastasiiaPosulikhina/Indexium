namespace DataHandler.Data_Processing;

public class Converter
{
    // How to call Converter:
    // converter.ConvertToJson("C:\\Users\\Anastasiia.Posulikhi\\RiderProjects\\Indexium\\Parser_\\AdmiralteiskyDistrictSchools.json", result)
    public void ConvertToJson(string jsonPath, string content)
    {
        File.WriteAllText(jsonPath, content);
    }
}