using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20_2
{
    internal class Collections
    {
        private Entree[] tableau;
        private int positionLibre;
        private int MAX = 100;

        public Collections()
        {
            tableau = new Entree[MAX];
            positionLibre = 0;
        }
        public bool Ajouter(string cle, object valeur)
        {
            if (positionLibre >= tableau.Length || Existe(cle))
                return false;
            tableau[positionLibre] = new Entree(cle, valeur);
            positionLibre++;
            return true;
        }
        public object Retourner(string cle)
        {
            foreach (var entree in tableau)
            {
                if (entree != null && entree.GetCle() == cle)
                    return entree.GetValeur();
            }
            return null;
        }
        public bool Supprimer(string cle)
        {
            for (int i = 0; i < positionLibre; i++)
            {
                if (tableau[i].GetCle() == cle)
                    for (int j = i; j < positionLibre - 1; j++)
                    {
                        tableau[j] = tableau[j + 1];
                    }
                positionLibre--;
                return true;
            }
            return false;
        }
        public bool Existe(string cle)
        {
           for (int i = 0; i < positionLibre; i++)
            {
                if (tableau[i].GetCle == cle)
                    return true;
            }
            return false;
        }
        public void Vider()
        {
            positionLibre = 0;
        }
        public int NomBreDElements()
        {
            return positionLibre;
        }
        public override string ToString()
        {
            string result = "\n";
            for (int i = 0; i < positionLibre; i++)
            {
                result += tableau[i].ToString() + "\n";
            }
            return result;
        }
    }
}