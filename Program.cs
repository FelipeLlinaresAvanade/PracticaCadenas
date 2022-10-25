// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


string cadena;
bool continuar = true;
string opcionSeleccionada;

while (continuar)
{
    Console.WriteLine("Introduce una cadena con al menos 40 caracteres:");
    cadena = Console.ReadLine();

    while (cadena == null || cadena.Length < 40)
    {
        Console.WriteLine($"La cadena introducida posee únicamente {cadena.Length} caracteres.\n Por favor, introduzca una nueva cadena con más de 40 caracteres: \n");
        cadena = Console.ReadLine();
    }

    Console.ForegroundColor = ConsoleColor.Blue;
    
    Console.WriteLine("********************");
    Console.WriteLine("* Selecciona una opcion *");
    Console.WriteLine("********************");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1: Sustituir palabras:");
    Console.WriteLine("2: Buscar palabra");
    Console.WriteLine("3: Buscar palabra al inicio");
    Console.WriteLine("4: Terminar");

    opcionSeleccionada = Console.ReadLine();
    string cadena1;

   if(opcionSeleccionada != null)
    {
        switch (opcionSeleccionada)
        {
            case "1":
                Console.WriteLine("Introduzca la palabra a sustituir y la nueva palabra:");
                cadena1 = Console.ReadLine();
                string[] palabras = cadena1.Split(' ');
                if (palabras.Length == 2)
                {

                    cadena = cadena.Replace(palabras[0], palabras[1]);
                    Console.WriteLine("Resultado: " + cadena);
                }
                else
                {
                    Console.WriteLine("Introduccion errónea");
                }
                break;

            case "2":
                Console.WriteLine("Introduzca la palabra a buscar:");
                cadena1 = Console.ReadLine();

                if (!string.IsNullOrEmpty(cadena1)) {
                    if (cadena.Contains(cadena1))
                        Console.WriteLine($"La palabra '{cadena1}' está contenida en la cadena");
                    else
                        Console.WriteLine($"La palabra '{cadena1}' no está contenida en la cadena");
                }
                else
                {
                    Console.WriteLine("Introduccion errónea");
                }
                break;

            case "3":
                Console.WriteLine("Introduzca la palabra a buscar al principio de la cadena:");
                cadena1 = Console.ReadLine();

                if(!string.IsNullOrEmpty(cadena1)) {
                    if (cadena.StartsWith(cadena1))
                        Console.WriteLine($"La cadena empieza por la palabra '{cadena1}'");
                    else
                        Console.WriteLine($"La cadena no empieza por la palabra '{cadena1}''");
                }
                else
                {
                    Console.WriteLine("Introduccion errónea");
                }
                break;

            case "4":
                continuar = false;
                break;
            default:
                Console.WriteLine("Seleccion inválida. Intentelo de nuevo.");
                break;
        }
    }
   
}

Console.WriteLine("Gracias por usar la aplicación");
Console.Read();




