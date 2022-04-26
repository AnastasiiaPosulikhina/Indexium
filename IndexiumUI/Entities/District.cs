namespace IndexiumUI.Entities;

public class District
{
	public Guid DistrictId { get; set; }
	public Guid CityId { get; set; }
	public string Name { get; set; }
	public string GeographicalCoordinates { get; set; }
	public int IndexValue { get; set; }
	public DateTime InfoRefreshDate { get; set; }
}