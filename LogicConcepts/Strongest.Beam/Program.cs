using Shared;
using System.ComponentModel.DataAnnotations;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    //Configuración de resistencias de las bases
    var resistance = new Dictionary<char, int> {
        { '%', 10 },
        { '&', 30 },
        { '#', 90 }

        };

    ConsoleExtension.GetString("Ingrese la viga.....: ");
    string beam = Console.ReadLine() ??"";
  
    if (string.IsNullOrEmpty(beam)) return;

    //  Validación inicial de la base
    char baseChar = beam[0];
    if (!resistance.ContainsKey(baseChar))
    {
        Console.WriteLine("La viga está mal construida!");
        return;
    }

    int baseCapacity = resistance[baseChar]; 
    double totalWeight = 0;
    int pesoCrossbarNext = 1; 
    int sumSequentialCurrent = 0;        
    bool badBuilt = false; 
    char lastElement = baseChar;

    //  Procesamiento de la viga elemento por elemento
    for (int i = 1; i < beam.Length; i++)
    {
        char piece = beam[i];

        if (piece == '=')
        {
            totalWeight += pesoCrossbarNext;
            sumSequentialCurrent += pesoCrossbarNext;
            pesoCrossbarNext++; // Cada larguero consecutivo pesa uno más
        }
        else if (piece == '*')
        {
            // Regla: No puede haber ** ni conexión directa a la base (según lógica de secuencia)
            if (lastElement == '*' || lastElement == baseChar)
            {
                badBuilt = true;
                break;
            }

            // Regla: Pesa el doble de la secuencia de largueros anterior
            totalWeight += (sumSequentialCurrent * 2);

            // Reiniciar contadores para la nueva secuencia de largueros
            sumSequentialCurrent = 0;
            pesoCrossbarNext = 1;
        }
        else
        {
            // Caracteres inválidos o mal uso de la estructura
            badBuilt = true;
            break;
        }
        lastElement = piece;
    }

    // 4. Mostrar resultados finales
    if (badBuilt)
    {
        Console.WriteLine("La viga está mal construida!");
    }
    else
    {
        if (totalWeight <= baseCapacity)
        {
            Console.WriteLine("La viga soporta el peso!");
        }
        else
        {
            Console.WriteLine("La viga NO soporta el peso!");
        }
    }

do
{
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

Console.WriteLine("Game Over. ");

