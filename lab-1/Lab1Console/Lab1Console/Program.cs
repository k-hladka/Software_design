using System.Text;
using Lab1Console.Classes;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

IMoney moneyForProduct1 = new Money();
IMoney moneyForProduct2 = new Money();

if (moneyForProduct1 is Money && moneyForProduct2 is Money)
{

    ((Money)moneyForProduct1).AddUAN(370, 95);
    Warehouse product1 = new Warehouse("молокo", "літр", moneyForProduct1, 10, "06-03-2023");


    ((Money)moneyForProduct2).AddEUR(17, 23);
    Warehouse product2 = new Warehouse("ноутбук", "шт.", moneyForProduct2, 7, "13-02-2023");

    Console.WriteLine($"Загальна ціна для 10 літрів молока: {((Money)moneyForProduct1).Sum(product1.Count)}");
    Console.WriteLine($"Загальна ціна для 7 ноутбуків: {((Money)moneyForProduct2).Sum(product2.Count)}");


    try
    {
        var arr = Product.ReductionPrice(moneyForProduct1.WholeMoney, moneyForProduct1.Coins, 120, 97);
        moneyForProduct1.WholeMoney = arr[0];
        moneyForProduct1.Coins = arr[1];
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    Console.WriteLine($"Вартість за 1 літр молока, після зниження ціни: {moneyForProduct1.WholeMoney},{moneyForProduct1.Coins}");


    Reporting reportingForProduct1 = new Reporting(product1);
    Reporting reportingForProduct2 = new Reporting(product2);


    ChangingConsoleColor("\nПрибуткова накладна: ");
    Console.WriteLine(reportingForProduct1.RevenueInvoice("Іванов Іван Іванович", "Петренко Петро Петрович"));

    ChangingConsoleColor("\nВидаткова накладна: ");
    Console.WriteLine(reportingForProduct1.SalesInvoice("Петренко Петро Петрович", "Іванов Іван Іванович"));

    ChangingConsoleColor("\nЗалишки на складі: ");
    Console.WriteLine(reportingForProduct2.LeftoversOnWarehouse());
}

void ChangingConsoleColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ResetColor();
}
