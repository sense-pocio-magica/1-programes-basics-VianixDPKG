﻿namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix una paraula");
        string? paraula = Console.ReadLine();
        Console.Clear();

        int Long = paraula.Length;
        Console.WriteLine($" La teva paraula es {paraula} i te {Long} de longitud ");
    }
}
