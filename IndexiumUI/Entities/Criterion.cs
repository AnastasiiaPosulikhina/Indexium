namespace IndexiumUI.Entities;

public class Criterion
{
	public Guid CriterionId { get; set; }
	// public CriterionName Name { get; set; }
	// public CriterionType Type { get; set; }
	public int Value { get; set; }
	public string DataSource { get; set; }
	public DateTime InfoRefreshDate { get; set; }
}