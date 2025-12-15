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

            int a = 5;
            int b = 10;
            int c = 15;
            int result = 0;

            if (a <= 0)
            {
                result = 0;
            }
            else
            {
                if (b <= 0)
                {
                    result = a;
                }
                else
                {
                    
                    if (c <= 0)
                    {
                        result = a + b;
                    }
                    else
                    {
                        
                        result = a + b + c;
                    }
                }
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