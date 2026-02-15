using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a = ConsoleExtension.GetInt("Ingrese el numero de escritorios : ");
    var valueToPay = CalculateValue(a);
    Console.WriteLine($"El valor a pagar es..: {valueToPay:C2}");

    do
{
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

object CalculateValue(int a)
{
    float c;
    if (a < 5)
    {
        c = 0.1f;
    }
    else if (a < 10)
    {
        c = 0.2f;
    }
    else
    {
        c = 0.4f;
    }
    return a * 650000M * (decimal)(1 - c);
}

Console.WriteLine("Game Over. ");
