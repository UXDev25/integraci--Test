// Program.cs
using System;
using System.Reflection.Metadata.Ecma335;

namespace CodeWithIssues
{
    // afegim el 'public' a la classe
    public static class Program
    {
        static void Main(string[] args)
        {
            //borrem la declaració de la variable 'unusedVar'

            //borrem els writelines redundants
            Console.WriteLine("Benvingut al programa de càlculs!");

            int a = 5;
            int b = 10;
            int c = 15;
            int result = 0;

            result = CalculateResult(a, b, c);
            Console.WriteLine(SendMsg(result));

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

            //treiem declaracións de variables inecessaries

            //borrem els writelines redundants
            Console.WriteLine("Finalitzant el programa...");
        }

        public static int CalculateResult(int a, int b, int c)
        {
            
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        return a + b + c;
                    }
                    else
                    {
                        return a + b;

                    }
                }
                else
                {
                    return a;

                }
            }
            else
            {
                return 0;

            }
        }

        public static string SendMsg(int result) 
        {
            //Optimitzem la complexitat ciclomatica
            switch (result)
            {
                case 0:
                    return "El resultat és zero.";
                case < 0:
                    return "El resultat és negatiu.";
                default:
                    return "El resultat és positiu.";
            }
        }
        
    }
}