namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hora actual (1-12): ");
        int horaActual = Convert.ToInt32(Console.ReadLine());

        Console.Write("Hores a incrementar: ");
        int hores = Convert.ToInt32(Console.ReadLine());

    
        int novaHora = ((horaActual + hores - 1) % 12) + 1;

        Console.WriteLine($"D'aquí a {hores} hores seran les {novaHora}");
    }
}
