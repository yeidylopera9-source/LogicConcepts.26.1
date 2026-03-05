using Shared;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

     ConsoleExtension.GetString("Ingrese ubicación de los caballos: ");
    string entry = Console.ReadLine() ?? ""; // Ejemplo: B7, C5, E2, H7, G5, F6

    if (string.IsNullOrWhiteSpace(entry)) return;

    //  Limpiar la entrada y convertirla en una lista de coordenadas
    var horses = entry.Split(',')
                          .Select(c => c.Trim().ToUpper())
                          .ToList();

    //  Función para verificar si dos posiciones están en conflicto (movimiento de caballo)
    bool theyAreInConflict(string pos1, string pos2)
    {
        // Convertir coordenadas algebraicas (B7) a numéricas (columna 1-8, fila 1-8)
        int col1 = pos1[0] - 'A' + 1;
        int fila1 = int.Parse(pos1[1].ToString());

        int col2 = pos2[0] - 'A' + 1;
        int fila2 = int.Parse(pos2[1].ToString());

        // El caballo se mueve en "L": (2 pasos en un eje y 1 en el otro)
        int diffCol = Math.Abs(col1 - col2);
        int diffFila = Math.Abs(fila1 - fila2);

        return (diffCol == 2 && diffFila == 1) || (diffCol == 1 && diffFila == 2);
    }

    //  Analizar cada caballo contra los demás
    foreach (var currentHair in horses)
    {
        var conflicts = new List<string>();

        foreach (var anotherHorse in horses)
        {
            if (currentHair == anotherHorse) continue;

            if (theyAreInConflict(currentHair, anotherHorse))
            {
                conflicts.Add(anotherHorse);
            }
        }

        // 4. Mostrar resultados con el formato solicitado
        string conflictResult = conflicts.Count > 0
            ? "Conflicto con " + string.Join(" ", conflicts)
            : "ninguno";

        Console.WriteLine($"Analizando Caballo en {currentHair} => {conflictResult}");
    }

    Console.WriteLine("\nPresione cualquier tecla para salir...");
    Console.ReadKey();

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));