using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20_1_2
{
    internal class Program
    {
        static Complexe SaisirComplexe()
        {
            Console.Write("Valeur de la partie réelle : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valeur de la partie imaginaire : ");
            double y = Convert.ToDouble(Console.ReadLine());

            return new Complexe(x, y);
        }
        static void Main(string[])
        {
            Console.WriteLine("1. Afficher la somme de deux nombres complexes saisis par l’utilisateur.");
            Console.WriteLine("2. Afficher la soustraction de deux nombres complexes saisis par l’utilisateur.");
            Console.WriteLine("3. Afficher le produit de deux nombres complexes saisis par l’utilisateur.");
            Console.WriteLine("4. Afficher l’inverse d’un nombre complexe saisi par l’utilisateur.");
            Console.WriteLine("5. Afficher le module d’un nombre complexe saisi par l’utilisateur.");
            Console.WriteLine("6. Ajouter un Complexe dans un tableau.");
            Console.WriteLine("7. Faire la somme des nombres complexes du tableau.");
            Console.WriteLine("8 .Quitter.");
            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    Console.WriteLine("\nSaisissez le premier nombre complexe :");
                    Complexe c1 = SaisirComplexe();

                    Console.WriteLine("Saisissez le deuxième nombre complexe :");
                    Complexe c2 = SaisirComplexe();

                    Complexe somme = c1.Addition(c2);
                    Console.WriteLine($"Résultat de l'addition : {somme}");
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine();
                    break;
                case "6":
                    Console.WriteLine();
                    break;
                case "7":
                    Console.WriteLine();
                    break;
                case "8":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;

            }

            Console.ReadLine();
        }

    }
}