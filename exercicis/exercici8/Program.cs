namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        int min = 80;
        int horas = (min / 60);
        int minhoras = (min % 60);
        Console.WriteLine($"{horas} hores i {minhoras} minuts.");
    }
}
