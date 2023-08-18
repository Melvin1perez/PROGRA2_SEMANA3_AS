
class Program
{
    static void Main(string[] args)
    {
        // Paso 1: declaro un arreglo
        int[] ArregloMEL;

        // Paso 2: Pedimos el tamaño al usuario
        Console.Write("Ingresamos el tamaño del arreglo (mínimo 5): ");
        int tamañoArreglo = Convert.ToInt32(Console.ReadLine());

        if (tamañoArreglo < 5)
        {
            Console.WriteLine("El tamaño del arreglo debe ser mínimo 5. Saliendo del programa.");
            return;
        }

          ArregloMEL = new int[tamañoArreglo];

        // Paso 3: Pedir el ingreso de cada valor en el arreglo
        for (int i = 0; i < tamañoArreglo; i++)
        {
            Console.Write($"Ingrese el valor para la posición {i + 1}: ");
              ArregloMEL[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Paso 4: Imprimir cada valor del arreglo
        Console.WriteLine("Valores ingresados en el arreglo:");
        foreach (int valor in ArregloMEL)
        {
            Console.WriteLine(valor);
        }
    }
}
