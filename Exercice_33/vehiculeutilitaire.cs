using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_33
{
    internal class vehiculeutilitaire
    {
        private double chargeUtile, longueur, largeur, hauteur;
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
            return "Charge utile : " + chargeUtile + "\nLongueur : " + longueur + "\nLargeur : " + largeur + "\nHauteur : " + hauteur + "\nVolume" + volume() + "\nCoût location : " + Vehicule.CoutLocation(5);
                
        }
    }
}
