using IndexiumUI.DataBase;
using IndexiumUI.DataProcessor.HandlerModule.HandlerComponents;
using IndexiumUI.DataProcessor.ParserModule.ParserComponents;
using IndexiumUI.Entities;
// ReSharper disable StringLiteralTypo

namespace IndexiumUI.DataProcessor;

public class DataProcessorClient
{
    public DataProcessorClient()
    {
    }

    public void UseDataProcessor()
    {
        var city = new City(
            new Guid("A04A011A-9FD9-4C4F-948E-FBB8470FDBB3"), 
            "Санкт-Петербург", 
            "59°56′19″ с.ш., 30°18′50″ в.д.", 
            DateTime.Now, 
            new List<District>()
            );
        
        var parser = new YandexMapsParser(city);
        var handler = new YandexMapsDataHandler();
        var dataBaseWorker = new DataBaseWorker();
        
        var dataProcessor = new DataProcessor(parser, handler);
        var parsedData = dataProcessor.ParseData();

        foreach (var dataUnit in parsedData)
        {
            var handledData = dataProcessor.HandleData(dataUnit);
            dataBaseWorker.WriteDataToDataBase(handledData);
        }
    }
}