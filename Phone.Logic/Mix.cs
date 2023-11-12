
using Phone.Logic;

public class Mix : PhoneAbstract
{

  public decimal MonthlyFee { get; set; }
  public double IncludedMegabytes { get; set; }
  public decimal PricePerMegabytes { get; set; }

  public override decimal CalculateFee(double megabytes)
  {
    var fee = MonthlyFee;
    if (megabytes > IncludedMegabytes)
    {
      fee += PricePerMegabytes * (decimal)(megabytes - IncludedMegabytes);
    }

    return fee;


  }
}