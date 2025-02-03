using System;
using System.Collections.Generic;
using System.Linq;
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
            return Supprimer();
        }
        public bool Existe()
        {
            return Existe();
        }
        public Vider()
        {
            return;
        }
        public int NomBreDElements()
        {
            return;
        }
        public override string ToString()
        {
            return;
        }
    }
}