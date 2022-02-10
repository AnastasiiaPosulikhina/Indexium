namespace DataHandler.Entities;

public class Index
{
	public virtual Guid IndexId { get; set; }
	public virtual Guid DistrictId { get; set; }
	public virtual int IndexValue { get; set; }
}