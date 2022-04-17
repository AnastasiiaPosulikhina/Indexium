namespace DataHandler.Entities;

public class Criterion
{
	public virtual Guid CriterionId { get; set; }
	public virtual Guid DistrictId { get; set; }
	public virtual CriterionName Name { get; set; }
	public virtual CriterionType Type { get; set; }
	public virtual int CriterionValue { get; set; }
	public virtual string DataSource { get; set; }
	public virtual DateTime InfoRefreshDate { get; set; }
}