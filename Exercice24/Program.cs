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
            string designation, reference, answer;
            double prixHT, tauxTVA, pourcentage;
            int choix;
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
                            Console.WriteLine("Produit ajouté");
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
                        foreach (Produit produit in catalogue.Values)
                        {
                            produit.AugmenterPrix(pourcentage);
                        }
                        Console.WriteLine("Tout les prix ont bien été augmenter");
                        break;
                    }
                    case 6:
                        {
                            do
                            {
                                Console.WriteLine("Entrez la référence du produit à supprimer : ");
                                reference = Console.ReadLine();
                                if (!catalogue.ContainsKey(reference) || reference == "") 
                                {
                                    Console.WriteLine("Veuillez entrer une référence valide.");
                                }
                            } while (!catalogue.ContainsKey(reference));
                            catalogue.Remove(reference);
                            Console.WriteLine("Le produit a été supprimé avec succès.");
                            break;
                        }
                    case 7:
                        {
                            foreach (DictionaryEntry produit in catalogue)
                            {
                                Console.WriteLine("Référence du produit . " + produit.Key);
                                Console.WriteLine(((Produit)produit.Value).ToString());
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Entrez la référence du produit : ");
                            reference = Console.ReadLine();
                            if (catalogue.ContainsKey(reference))
                            {
                                Produit produit = (Produit)catalogue[reference];
                                Console.WriteLine(produit.ToString());
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Produit non trouvé dans le catalogue / référence non valide.");
                                break;
                            }
                        }
                    case 9:
                        {
                            Console.WriteLine("Etes vous sur de vouloir vider le catalogue ? y/n");
                            answer = Console.ReadLine();
                            if (answer.ToLower() == "y")
                            {
                                catalogue.Clear();
                                Console.WriteLine("Catalogue vidé.");
                                Console.ReadLine();
                            }
                            else if (answer.ToLower() == "n")
                            {
                                Console.WriteLine("Catalogue intacte.");
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrez une réponse valide.");
                            }
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Au revoir.");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Entrez un choix valide.");
                            break;
                        }

                }

            } while (choix != 10);
        }
    }
}
