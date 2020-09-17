using System;

namespace MemeTonervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pensa;
            Console.WriteLine("Oi, O que vc pensa de mim?");
            Pensa = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Quer saber o que penso de voce?");
            Console.WriteLine($"{Pensa.Remove(10)}....Não, Pera \n Eu to nervoso");
            Console.ReadKey();
            
        }  

    }
}
