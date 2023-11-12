
using Phone.Logic;

public class Mix : PhonePlan
{
  public Mix()
  {
    
  }
  public Mix(decimal monthlyFee, double includedMegabytes, decimal pricePerMegabytes )
  {
    MonthlyFee = monthlyFee;
    IncludedMegabytes = includedMegabytes;
    PricePerMegabytes = pricePerMegabytes;    
  }

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