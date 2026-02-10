using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 3 numeros diferentes...");
    var a = ConsoleExtension.GetInt("Ingrese primer numero  : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero : ");

    if (a == b)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar...");
        continue;
    }

    var c = ConsoleExtension.GetInt("Ingrese tercer numero  : ");
    if (b == c || c == a)
    {
        Console.WriteLine("Deben ser diferentes, vuelva empezar...");
        continue;
    }
    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (a > b && a > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor {b}, el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor {c}, el medio es {b}, el menor es {a}");
        }
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over. ");


