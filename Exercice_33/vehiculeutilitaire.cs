using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_33
{
    internal class Vehiculeutilitaire : Vehicule
    {
        private double chargeUtile, longueur, largeur, hauteur;
        public Vehiculeutilitaire(string code, string libelle, double prixJour, string chargeUtile, double longueur, double largeur, double hauteur)
            : base(code, libelle, prixJour);
        public double GetChargeUtile()
        {
            return chargeUtile;
        }
        public double volume()
        {
            return longueur * largeur * hauteur;
        }
        public override string ToString()
        {
            return "Charge utile : " + chargeUtile + "\nLongueur : " + longueur + "\nLargeur : " + largeur + "\nHauteur : " + hauteur + "\nVolume" + volume() + "\nCoût location : " + base.CoutLocation(1);
                
        }
    }
}
