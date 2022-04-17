namespace DataHandler.Entities;

public class District
{
	public virtual Guid DistrictId { get; set; }
	public virtual Guid CityId { get; set; }
	public virtual string Name { get; set; }
	public virtual double[] GeographicalCoordinates { get; set; }
	public virtual DateTime InfoRefreshDate { get; set; }
}