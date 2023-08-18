
class Programs
{
    static void Main(string[] args)
    {
        // Paso 1: arreglo con nombre completo
        string[] nombreCompletomio = new string[2]; 

        // Inicia el arreglo con los valores respectivos
        Console.Write("Ingrese su nombre: ");
        nombreCompletomio[0] = Console.ReadLine();
        Console.Write("Ingrese su apellido: ");
        nombreCompletomio[1] = Console.ReadLine();

        // Paso 2: Imprimir cada valor
        Console.WriteLine("Valores del arreglo:");
        foreach (string valor in nombreCompletomio)
        {
            Console.WriteLine(valor);
        }

        // Paso 3: la longitud o tamaño del arreglo
        int longitudArreglo = nombreCompletomio.Length;

        // Paso 4: Imprimir el tamaño del arreglo y sus respectivos valores
        Console.WriteLine($"Tamaño del arreglo: {longitudArreglo}");
        Console.WriteLine("Valores del arreglo:");
        foreach (string valor in nombreCompletomio)
        {
            Console.WriteLine(valor);
        }
    }
}
