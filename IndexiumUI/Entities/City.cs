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

	public City(Guid cityId, string name, string geographicalCoordinates, DateTime infoRefreshDate, List<District> districts)
	{
		CityId = cityId;
		Name = name;
		GeographicalCoordinates = geographicalCoordinates;
		InfoRefreshDate = infoRefreshDate;
		Districts = districts;
	}

	public City(Guid cityId, string name, string climate, string geographicalCoordinates, int population, DateTime infoRefreshDate, List<District> districts)
	{
		CityId = cityId;
		Name = name;
		Climate = climate;
		GeographicalCoordinates = geographicalCoordinates;
		Population = population;
		InfoRefreshDate = infoRefreshDate;
		Districts = districts;
	}
}