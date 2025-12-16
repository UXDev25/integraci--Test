// Program.cs
using System;

namespace CodeWithIssues
{
    // afegim el 'public' a la classe
    public class Program
    {
        static void Main(string[] args)
        {
            // borrem la declaració de la variable 'unusedVar'

            //borrem els writelines redundants
            Console.WriteLine("Benvingut al programa de càlculs!");

            int a = 0;
            int b = 0;
            int c = 0;
            int result = 0;

            switch (a, b, c)    
            {
                case a < 0:
            }
            
            if (result == 0)
            {
                Console.WriteLine("El resultat és zero.");
            }
            else if (result < 0)
            {
                Console.WriteLine("El resultat és negatiu.");
            }
            else
            {
                Console.WriteLine("El resultat és positiu.");
            }

            int counter = 0;
            while (true)
            {
                counter++;
                if (counter > 100)
                {
                    break;
                }
            }

            //treiem linees de codi comentades

            // treiem declaracións de variables inecessaries

            //borrem els writelines redundants
            Console.WriteLine("Finalitzant el programa...");
        }
    }
}