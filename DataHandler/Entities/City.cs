namespace DataHandler.Entities;

public class City
{
	public virtual Guid CityId { get; set; }
	public virtual string Name { get; set; }
	public virtual Climate Climate { get; set; }
	public virtual double[] GeographicalCoordinates { get; set; }
	public virtual int Population { get; set; }
}