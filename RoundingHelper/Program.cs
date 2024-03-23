public static class RoundingHelper
{
    public static decimal RoundToInteger(decimal number) => Math.Floor(number + 0.5m);
    public static decimal RoundToTenths(decimal number) => Math.Floor(number * 10 + 0.5m) / 10;
    public static decimal RoundToHundredths(decimal number) => Math.Floor(number * 100 + 0.5m) / 100;
    public static decimal RoundToThousandths(decimal number) => Math.Floor(number * 1000 + 0.5m) / 1000;
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number to round: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Original number: {number}");
        Console.WriteLine($"Rounded to integer: {RoundingHelper.RoundToInteger(number)}");
        Console.WriteLine($"Rounded to tenths: {RoundingHelper.RoundToTenths(number)}");
        Console.WriteLine($"Rounded to hundredths: {RoundingHelper.RoundToHundredths(number)}");
        Console.WriteLine($"Rounded to thousandths: {RoundingHelper.RoundToThousandths(number)}");
    }
}