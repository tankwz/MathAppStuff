

namespace Phone.Logic;

public class FlatFee : PhoneAbstract
{
  decimal MonthlyFee {get;set;}
    public override decimal CalculateFee(double _)
    {
      return MonthlyFee;
    }
}