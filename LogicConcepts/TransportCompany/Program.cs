using Shared;
using System.Reflection.Metadata.Ecma335;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    var routeOptions = new List<string> { "1", "2", "3", "4" };
    var route = string.Empty;
    do
    {
        route = ConsoleExtension.GetValidOptions("Ruta [1][2][3][4]...............................:", routeOptions);
    } while (!routeOptions.Any(x => x.Equals(route, StringComparison.CurrentCultureIgnoreCase)));

    var trips = ConsoleExtension.GetInt("Número de viajes................................: ");
    var pasaggers = ConsoleExtension.GetInt("Número de pasajeros total.......................: ");
    var pakages10 = ConsoleExtension.GetInt("Número de encomiendas de menos de 10Kg..........: ");
    var pakages10_20 = ConsoleExtension.GetInt("Número de encomiendas entre 10kg y menos de 20Kg: ");




    do
    {
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

Console.WriteLine("Game Over. ");
