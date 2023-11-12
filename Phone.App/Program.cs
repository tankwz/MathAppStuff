// See https://aka.ms/new-console-template for more information
using Phone.Logic;

Console.Write("Choose plan: ");
var planSelect = Console.ReadLine();

Console.Write("How many MB?: ");
var mb = Console.ReadLine();

PhonePlan plan;

switch (planSelect)
{
  case "f":
    {
      Console.Write("Fee: ");
      var fee = decimal.Parse(Console.ReadLine()!);
      plan = new FlatFee()
      {
        MonthlyFee = fee
      };
      break;
    }
  case "m":
    {
      Console.Write("Fee: ");
      var fee = decimal.Parse(Console.ReadLine()!);

      Console.Write("includedMegabyte: ");
      var includedMegabyte = double.Parse(Console.ReadLine()!);

      Console.Write("pricePerMegaByte: ");
      var pricePerMegaByte = decimal.Parse(Console.ReadLine()!);
      plan = new Mix(fee, includedMegabyte, pricePerMegaByte);

      break;
    }
    case "p":
    {

      Console.Write("pricePerMegaByte: ");
      var pricePerMegaByte = decimal.Parse(Console.ReadLine()!);
      plan = new PayAsYouGo( ){
        PricePerMegaByte = pricePerMegaByte
      };
      break;
    }
    default: Console.WriteLine("wrong input"); return;
}

Console.WriteLine($"you have to pay {plan.CalculateFee(double.Parse(mb!))}$");

