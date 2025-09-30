namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
   public static void Main()
    {
        Console.WriteLine("Introdueix el teu carrer");
        string? Carrer = Console.ReadLine();

        Console.WriteLine("Introdueix el teu número de portal");
        var NumPortal = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Introdueix el teu codi postal");
        var CodiPostal = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Introdueix la teva població");
        string? Poblacio = Console.ReadLine();



        Console.WriteLine($"El teu carrer es, {Carrer}, {NumPortal} de {Poblacio} amb codi postal {CodiPostal}");

    }
}
