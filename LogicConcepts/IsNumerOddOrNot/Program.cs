var numberString = string.Empty;
do
{
    Console.Write("Ingrese numero o la palabra'Salir' para salir: ");
    numberString = Console.ReadLine(); // "45"
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

     var numberInt = 0; 
    if (int.TryParse(numberString, out numberInt)) // 45
    {

          if (numberInt % 2 == 0)
          {
                Console.WriteLine($"El numero {numberInt} es par.");
          }
          else
          {
                Console.WriteLine($"El numero {numberInt} es impar.");
          } 
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un numero entero.");
    }
}
while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over. ");
