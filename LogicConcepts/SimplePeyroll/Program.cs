using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre...................: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese numero de hoas trabajadas: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese valor hora...............: ");
    var salaryMimimun = ConsoleExtension.GetDecimal("Ingrese salio minimo mensual.: ");

    var salary = (decimal) workHours * hourValue;
    if (salary < salaryMimimun)
    {
        Console.WriteLine($"Nombre.... {name}");
        Console.WriteLine($"Salario... {salaryMimimun}");

    }
    else
    {
        Console.WriteLine($"Nombre....: {name}");
        Console.WriteLine($"Salario ..:{salary}");

    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over. ");