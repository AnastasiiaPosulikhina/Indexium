namespace IndexiumUI.Entities;

public class City
{
	public Guid CityId { get; set; }
	public string Name { get; set; }
	public string Climate { get; set; }
	public string GeographicalCoordinates { get; set; }
	public int Population { get; set; }
	public DateTime InfoRefreshDate { get; set; }
	
	public List<District> Districts { get; set; }

	// конструкторы для создания записей в базе данных
	public City(string name, string geographicalCoordinates)
	{
		Name = name;
		GeographicalCoordinates = geographicalCoordinates;
	}
	
	public City(string name, string geographicalCoordinates, int population)
	{
		Name = name;
		GeographicalCoordinates = geographicalCoordinates;
		Population = population;
	}
	
	public City(string name, string climate, string geographicalCoordinates)
	{
		Name = name;
		Climate = climate;
		GeographicalCoordinates = geographicalCoordinates;
	}

	public City(string name, string climate, string geographicalCoordinates, int population)
	{
		Name = name;
		Climate = climate;
		GeographicalCoordinates = geographicalCoordinates;
		Population = population;
	}
	
	// конструктор для чтения данных из базы
	public City(Guid cityId, string name, string geographicalCoordinates, DateTime infoRefreshDate)
	{
		CityId = cityId;
		Name = name;
		GeographicalCoordinates = geographicalCoordinates;
		InfoRefreshDate = infoRefreshDate;
	}
}