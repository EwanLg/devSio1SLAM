using GestionProduits;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice24
{
    internal class Program
    {
        static Hashtable catalogue = new Hashtable();
        static void Main(string[] args)
        {
            string designation, reference;
            double prixHT, tauxTVA, pourcentage;
            int choix, positionLibre;
            bool continuer;
            do
            {
                Console.WriteLine("1. Ajouter un produit au catalogue\n2. Augmenter le prix HT d'un produit\n3. Baisser le prix HT d'un produit\n4. Modifier le taux de TVA d'un produit\n5. Augmenter tous les produits du catalogue\n6. Supprimer un produit du catalogue\n7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)\n8. Afficher toutes les informations sur un produit (inc. Prix TTC)\n9. Vider le catalogue\n10. Quitter\nChoix ?");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        {
                            Console.WriteLine("Entrez le nom du produit : ");
                            designation = Console.ReadLine();
                            Console.WriteLine("Entrez le prix hors taxes du produit : ");
                            prixHT = double.Parse(Console.ReadLine());
                            Console.WriteLine("Entrez le taux de TVA du produit : ");
                            tauxTVA = double.Parse(Console.ReadLine());
                            do
                            {
                                Console.WriteLine("Référence du produit : ");
                                reference = Console.ReadLine();
                                if (catalogue.ContainsKey(reference))
                                {
                                    Console.WriteLine("Référence déjà existente, veuillez ressayez.");
                                }
                                else if (reference == "")
                                {
                                    Console.WriteLine("Veuillez enter une référence");
                                }
                            } while (catalogue.ContainsKey(reference) || reference == "");
                            
                            Produit produit = new Produit(designation, prixHT, tauxTVA);
                            catalogue.Add(reference, produit);
                            continuer = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Entrez la référence du produit : ");
                            reference = Console.ReadLine();
                            if (catalogue.ContainsKey(reference))
                            {
                                Produit produit = (Produit)catalogue[reference];
                                Console.WriteLine("Prix HT du produit " + produit.GetDesignation() + ": " + produit.GetPrixHT());
                                Console.WriteLine("De combien de % voulez-vous augmenter le prix HT du produit ? ");
                                pourcentage = double.Parse(Console.ReadLine());
                                produit.AugmenterPrix(pourcentage);
                                Console.WriteLine("Nouveau prix HT du produit " + produit.GetDesignation() + ": " + produit.GetPrixHT());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Produit non trouvé dans le catalogue.");
                                break;
                            }
                        }
                    case 3:
                        {
                            Console.WriteLine("Entrez la référence du produit : ");
                            reference = Console.ReadLine();
                            if (catalogue.ContainsKey(reference))
                            {
                                Produit produit = (Produit)catalogue[reference];
                                Console.WriteLine("Prix HT du produit " + produit.GetDesignation() + ": " + produit.GetPrixHT());
                                Console.WriteLine("De combien de % voulez-vous baisser le prix HT du produit ? ");
                                pourcentage = double.Parse(Console.ReadLine());
                                produit.BaisserPrix(pourcentage);
                                Console.WriteLine("Nouveau prix HT du produit " + produit.GetDesignation() + ": " + produit.GetPrixHT());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Produit non trouvé dans le catalogue.");
                                break;
                            }
                        }
                    case 4:
                        {
                            Console.WriteLine("Entrez la référence du produit : ");
                            reference = Console.ReadLine();
                            if (catalogue.ContainsKey(reference))
                            {
                                Produit produit = (Produit)catalogue[reference];
                                Console.WriteLine("Taux actuel de TVA du produit " + produit.GetDesignation() + ": " + produit.GetTauxTVA());
                                Console.WriteLine("Quel est le nouveau taux de TVA du produit ? ");
                                tauxTVA = double.Parse(Console.ReadLine());
                                produit.SetTauxTVA(tauxTVA);
                                Console.WriteLine("Nouveau taux de TVA du produit " + produit.GetDesignation() + ": " + produit.GetTauxTVA());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Produit non trouvé dans le catalogue.");
                                break;
                            }
                        }
                    case 5:
                        {
                        Console.WriteLine("De combien de % voulez-vous agumenter tout les prix HT du catalogue ? ");
                        pourcentage = double.Parse(Console.ReadLine());
                        foreach (double cle in catalogue.Keys)
                        {
                            Produit produit = (Produit)catalogue[cle];
                            produit.AugmenterPrix(pourcentage);
                        }
                        Console.WriteLine("Tout les prix ont bien été augmenter");
                        break;
                    }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                    case 9:
                        {
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Au revoir.");
                            Console.ReadLine();
                            break;
                        }

                }

            } while (choix != 10);
        }
    }
}
