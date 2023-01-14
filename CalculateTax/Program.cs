
using CalculateTax;

Console.WriteLine("Matrah girin");
decimal total = Convert.ToDecimal(Console.ReadLine());

CalculateTaxOptions options = new CalculateTaxOptions();
options.IsCo = false;
options.KDVRate = .08m;

Tax1 tax1 = CalculateTaxPayment.Tax(total,options);

Console.WriteLine($"KDV : {tax1.KDV}");
Console.WriteLine($"Vergi : {tax1.tax2}");