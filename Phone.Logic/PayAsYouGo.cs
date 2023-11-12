
using Phone.Logic;

public class PayAsYouGo : PhonePlan{
  public decimal PricePerMegaByte {get;set;}
    public override decimal CalculateFee(double megabytes) => PricePerMegaByte * (decimal)megabytes ;
}