namespace IndexiumUI.Entities;

public class District
{
	public Guid DistrictId { get; set; }
	public Guid CityId { get; set; }
	public string Name { get; set; }
	public double[] GeographicalCoordinates { get; set; }
	public DateTime InfoRefreshDate { get; set; }
}