using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20_2
{
    internal class Entree
    {
        private string cle = "test";
        private object valeur = 15;

        public Entree(string pCle, object pValeur)
        {
            cle = pCle;
            valeur = pValeur;
        }
        public string GetCle()
        {
            return cle;
        }
        public object GetValeur()
        {
            return valeur;
        }
        public override string ToString()
        {
            return $"{cle} : {valeur}";
        }
    }
}
