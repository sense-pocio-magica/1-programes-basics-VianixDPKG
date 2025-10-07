namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        float primer = (float)9.21;
        float segon = (float)2.51;
        float tercer = (float)6.94;
        float suma = primer + segon + tercer;
        float arodoniment = (float)Math.Round(suma / 3,2);
        Console.WriteLine(arodoniment);
    }
}
