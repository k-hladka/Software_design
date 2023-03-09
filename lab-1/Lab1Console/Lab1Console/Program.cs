using System.Text;
using Lab1Console.Classes;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Money moneyForProduct1 = new Money("UAN", 370, 95);
Warehouse product1 = new Warehouse("молокo", "літр", moneyForProduct1, 10, "06-03-2023");

Money moneyForProduct2 = new Money("EUR", 17, 23);
Warehouse product2 = new Warehouse("ноутбук", "шт.", moneyForProduct2, 7, "13-02-2023");

Console.WriteLine($"Загальна ціна для 10 літрів молока: {moneyForProduct1.Sum(product1)}");
Console.WriteLine($"Загальна ціна для 7 ноутбуків: {moneyForProduct2.Sum(product2)}");


try
{
    Product.ReductionPrice(moneyForProduct1, 120, 97);
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


void ChangingConsoleColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ResetColor();
}
