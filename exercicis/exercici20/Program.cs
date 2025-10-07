namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix nombre de 3 xifres");
        int num = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

        int cententes = num / 100;
        int decenes = (num / 10) % 10;
        int unitats = num % 10;

        Console.WriteLine($"El teu num erea {num} ara  es {unitats}{decenes}{cententes}");
            
    }
}
