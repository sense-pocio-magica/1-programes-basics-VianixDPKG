namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        float metres = (float)1234.213;
        float CPeus = (float)(metres * 3.280084);
        Console.WriteLine(CPeus);
    }
}
