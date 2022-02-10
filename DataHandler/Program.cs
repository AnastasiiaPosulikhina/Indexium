using DataHandler;
using DataHandler.Data_Processing;
using DataHandler.Entities;
using NHibernate.Cfg;
using Parser.Parser_Components;

YandexMapsParser parser = new YandexMapsParser();
YandexMapsDataHandler dataHandler = new YandexMapsDataHandler();

List<int> testList = new List<int>();
// сделать цикл для прохода по массиву toParse раз в месяц (узнать, как это можно реализовать)

foreach (string dataToParse in parser.DataToParseList)
{
    // var data = parser.Parse(dataToParse);
    // var result = dataHandler.ExtractUsefulData(data);
    // dataHandler.WriteDataToDataBase(result); 
    // пока метод не реализован, будем записывать в список
    //if (result != null) testList.Add(Int32.Parse(result));
}

//Console.WriteLine(testList);

var cfgFile = "Nhibernate.cfg.xml"; 
var nhConfig = new Configuration().Configure(cfgFile);
var sessionFactory = nhConfig.BuildSessionFactory();
Console.WriteLine("NHibernate Configured!");




