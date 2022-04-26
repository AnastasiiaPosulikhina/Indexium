using IndexiumUI.Entities;
namespace IndexiumUI.DataBase;

public class DataBaseAPI
{
    // City
    public static string SetCityInDataBase(City city)
    {
        if (city.Climate == "" && city.Population == 0)
            return "INSERT INTO city (name, coordinates) VALUES ('" + city.Name + "', '" + city.GeographicalCoordinates + "')";
        if (city.Climate == "" && city.Population != 0)
            return "INSERT INTO city (name, coordinates, population) VALUES ('" + city.Name + "', '" + city.GeographicalCoordinates + "', '" + city.Population + "')";
        if (city.Climate != "" && city.Population == 0)
            return "INSERT INTO city (name, climate, coordinates) VALUES ('" + city.Name + "', '" + city.Climate + "', '" + city.GeographicalCoordinates + "')";
        return "INSERT INTO city (name, climate, coordinates, population) VALUES ('" + city.Name + "', '" + city.Climate + "', '" + city.GeographicalCoordinates + "', '" + city.Population + "')";
    }

    public string UpdateCityInDataBase()
    {
        return "";
    }
	
    public string GetCityFromDataBase()
    {
        return "";
    }
    
    // Criterion
    // CriterionArchive
    // CriterionList
    // District
    // Indicator
    // IndicatorArchive
    // IndicatorList
}