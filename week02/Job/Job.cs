using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear y asignar valores al primer trabajo usando el constructor
        Job job1 = new Job("Microsoft", "Software Engineer", 2015, 2020);
        Console.WriteLine("First job:");
        job1.Display(); // Llamar al método para mostrar los valores

        // Crear y asignar valores al segundo trabajo usando el constructor
        Job job2 = new Job("Apple", "Product Manager", 2021, 2023);
        Console.WriteLine("Second job:");
        job2.Display(); // Llamar al método para mostrar los valores

        // Mantener la consola abierta
        Console.ReadLine();
    }
}
