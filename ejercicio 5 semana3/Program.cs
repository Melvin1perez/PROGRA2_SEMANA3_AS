int[] numeros = { 4, 10, 45, -67, -7, 25, 89, 64 };

Console.WriteLine("Arreglo original:");
Console.WriteLine(string.Join(", ", numeros));

Array.Reverse(numeros);
Console.WriteLine("\nArreglo después de Reverse:");
Console.WriteLine(string.Join(", ", numeros));

Array.Sort(numeros);
Console.WriteLine("\nArreglo después de Sort:");
Console.WriteLine(string.Join(", ", numeros));
