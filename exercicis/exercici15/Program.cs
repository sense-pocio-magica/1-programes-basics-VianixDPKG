namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriu el teu nom");
        string? nom = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Escriu el teu Cogmnom");
        string? cognom = Console.ReadLine();
        Console.Clear();

        char inicial = char.ToUpper(nom[0]);
        string paraula = nom.Substring(1);

        char Cinicial = char.ToUpper(cognom[0]);
        string Cparaula = cognom.Substring(1);

        Console.WriteLine($"{inicial}{paraula} {Cinicial}{Cparaula}");
        
    }
}
