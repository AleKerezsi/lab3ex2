using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Ex 2 Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul */
            Console.WriteLine("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            VerificaNumarPrim(n);
        }

        public static void VerificaNumarPrim(int x) 
        {
            int numarDivizori = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    numarDivizori = numarDivizori + 1;
                }
            }
            if (numarDivizori == 2) Console.WriteLine("Numarul " + x + " este prim");
            else Console.WriteLine("Numarul " + x + " nu este prim");
        }
    }
}
