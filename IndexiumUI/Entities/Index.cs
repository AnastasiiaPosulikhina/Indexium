namespace IndexiumUI.Entities;

public class Index
{
	public Guid IndexId { get; set; }
	public Guid DistrictId { get; set; }
	public int IndexValue { get; set; }
	public DateTime InfoRefreshDate { get; set; }
}