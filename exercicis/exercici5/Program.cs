namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom");
        string Nom = Console.ReadLine()!;

        Console.WriteLine("Introdueix la teva edad");
        int Anys = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hola {Nom}! Ja tens {Anys} Anys?");
    }
}
