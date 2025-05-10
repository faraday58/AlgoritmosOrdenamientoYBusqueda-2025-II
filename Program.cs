using AlgoritmosOrdenamientoYBusqueda_2025_II;

int [] v = { 2, 4, 1, 20, 0, -4, 9 };

PrintVector(v);
Ordenamiento.BubbleDesc(v);
PrintVector(v);


Console.WriteLine("Ingrese un número a buscar: ");
int x = Convert.ToInt32(Console.ReadLine());

int pos = Busqueda.Directa(v, x);

if (pos == -1)
{
    Console.WriteLine("No se encontró el número");
}
else
{
    Console.WriteLine($"El número {x} está en la posición {pos} ");
}

        

Console.ReadLine();


static int [] GenerateVector(int n)
{
    Random random = new Random();
    int[] v = new int[n];

    for(int i = 0; i < n; i++)
    {
        v[i] = (int)random.NextDouble()*1000;
    }
    return v;
}



static void PrintVector(int [] v)
{
    Console.WriteLine("Vector: ");

    foreach(int element in v)
    {
        Console.Write($" {element} ");
    }
    Console.WriteLine();
} 