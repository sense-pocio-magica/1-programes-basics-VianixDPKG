namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main()
    {
        Console.WriteLine("Introdueix el teu usuari");
        string? usuari = (Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Introdueix el domini");
        string? domini = (Console.ReadLine());
        Console.Clear();
         Console.WriteLine("La teva adreça de correu electrònic es:");
        Console.WriteLine($"{usuari}@{domini}");
    }
    }

