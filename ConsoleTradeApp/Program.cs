// See https://aka.ms/new-console-template for more information

using ConsoleTradeApp;
using ConsoleTradeApp.Factory;
using System.Globalization;

while (true)
{
    
    int quantityTraders = 0;
    Console.WriteLine("Digite a data de referencia ( mm/dd/yyyy) : ");
    DateTime referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy" , CultureInfo.InvariantCulture);
    Console.WriteLine("Digite o número de traders: ");
    int.TryParse(Console.ReadLine(), out quantityTraders);

    var traders = new List<ITrade>();

   
    for (int i = 0; i < quantityTraders; i++)
    {
        Console.WriteLine($"Digite o valor, setor e a data do trade {i + 1}: ");
        var tradersData = Console.ReadLine().Split(" ");

        double traderValue;
        double.TryParse(tradersData[0], out traderValue);

        var sector = tradersData[1];

        DateTime contractDate = DateTime.ParseExact(tradersData[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);

        var trade = ApplicationFactory.ExecuteAction(referenceDate, traderValue, sector, contractDate);

        traders.Add(trade);
    }

    traders.ForEach(x => Console.WriteLine(x.GetType().Name));
}
