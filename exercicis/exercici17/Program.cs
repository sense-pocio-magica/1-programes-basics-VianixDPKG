namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Introdueix un nombre real: ");
        double num = Convert.ToDouble(Console.ReadLine());

        // Resta de num decuimal amb la part cencera
        double decimals = num - Math.Truncate(num);

        // Si és negatiu, fem que la part decimal sigui positiva abs = valor absoluto 
        decimals = Math.abs(decimals);


        //Console.WriteLine($"El nombre meravellós és: {decimals}");

        Console.WriteLine("El nombre meravellós és: 0" + decimals.ToString().Substring(1));

    }
}