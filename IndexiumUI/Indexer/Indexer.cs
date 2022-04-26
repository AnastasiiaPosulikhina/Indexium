using IndexiumUI.Entities;

namespace IndexiumUI.Indexer;

public class Indexer
{
    public City ChosenCity { get; set; }
    public District ChosenDistrict { get; set; }
    public List<Indicator> IndicatorsList { get; set; }
    public List<Criterion> CriteriaList { get; set; }
    
    
    public Indexer(City chosenCity, District chosenDistrict)
    {
        ChosenCity = chosenCity;
        ChosenDistrict = chosenDistrict;
    }

    public int CalculateIndex(IEnumerable<Criterion> chosenCriteria)
    {
        return chosenCriteria.Sum(criterion => criterion.Value);
    }

    public int CalculateCriterionValue(List<Indicator> indicators)
    {
        int criterionValue = indicators.Sum(indicator => (indicator.Value - indicator.MinValue) / (indicator.MaxValue - indicator.MinValue));
        criterionValue /= indicators.Count;
        
        return criterionValue;
    }
}