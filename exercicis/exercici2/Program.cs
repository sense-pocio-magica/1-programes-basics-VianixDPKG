
namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

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
