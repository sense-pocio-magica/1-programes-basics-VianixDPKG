namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
   public static void Main()
    {
        Console.WriteLine("Nom producte");
        string? Prod = Console.ReadLine();

        Console.WriteLine("Preu");
        var Preu = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Esta en estoc");
        var estoc = Console.ReadLine();

        Console.WriteLine($" {Prod}, {Preu}€ {estoc}");

    }
}
