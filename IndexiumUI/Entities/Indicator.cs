namespace IndexiumUI.Entities;

public class Indicator
{
    public Guid IndicatorId { get; set; }
    public Guid CriterionId { get; set; }
    public Guid IndicatorTypeId { get; set; }
    public int Value { get; set; }
    public string DataSource { get; set; }
    public DateTime InfoRefreshDate { get; set; }
    public int MinValue { get; set; }
    public int MaxValue { get; set; }
}