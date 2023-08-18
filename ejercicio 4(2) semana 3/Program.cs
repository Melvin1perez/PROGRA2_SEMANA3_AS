string[] palabras = { "Burro", "Casa", "Cebra", "Dedo", "Mar", "Nube", "Perro", "Sol", "Tasa", "Tortuga" };

Console.WriteLine("Arreglo ordenado:");
foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}

Console.WriteLine("BinarySearch");
string[] Palabras_De_Buscar = { "Sol", "Dedo", "Casa" };
foreach (string buscar in Palabras_De_Buscar)
{
    int La_Posicion = Array.BinarySearch(palabras, buscar);
    if (La_Posicion >= 0)
    {
        Console.WriteLine($"La palabra {buscar} se encuentra en la posición {La_Posicion}");
    }
}
