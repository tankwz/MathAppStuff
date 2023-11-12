

namespace Phone.Logic;

public class FlatFee : PhonePlan
{
  public decimal MonthlyFee {get;set;}
    public override decimal CalculateFee(double _)
    {
      return MonthlyFee;
    }
}