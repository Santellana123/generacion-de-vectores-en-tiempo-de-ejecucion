int longitud;
Console.Write("Ingrese la longitud del vector: ");
longitud = int.Parse(Console.ReadLine());

int[] vector = GenerarVector(longitud);

Console.WriteLine("El vector generado es:");
ImprimirVector(vector);

Console.ReadKey();
       

        static int[] GenerarVector(int longitud)
{
    Random random = new Random();
    int[] vector = new int[longitud];

    for (int i = 0; i < longitud; i++)
    {
        vector[i] = random.Next(1, 100); 
    }

    return vector;
}

static void ImprimirVector(int[] vector)
{
    foreach (int num in vector)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
   }