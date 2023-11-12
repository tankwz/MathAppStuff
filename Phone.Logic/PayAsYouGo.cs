
using Phone.Logic;

public class PayAsYouGo : PhoneAbstract{
  decimal PricePerMegaByte {get;set;}
    public override decimal CalculateFee(double megabytes) => PricePerMegaByte * (decimal)megabytes ;
}