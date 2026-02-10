using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a = ConsoleExtension.GetInt("Ingrese primer numero  : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero : ");
    if (b % a == 0)

    {
        Console.WriteLine($"{a} es multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es multiplo de {b}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over. ");
