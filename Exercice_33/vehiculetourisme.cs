using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_33
{
    internal class VehiculeTourisme : Vehicule
    {
        private int nombrePlaces;
        private bool climatisation;

        public VehiculeTourisme(string code, string libelle, double prixJour, int nombrePlaces, bool climatisation)
            : base(code, libelle, prixJour)
        {
            this.nombrePlaces = nombrePlaces;
            this.climatisation = climatisation;
        }

        public int GetNombrePlaces()
        {
            return nombrePlaces;
        }

        public bool GetClimatisation()
        {
            return climatisation;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nNombre de places : " + nombrePlaces +
                   "\nClimatisation : " + "" +
                   "\nCoût location : " + base.CoutLocation(1) + "€/jour";
        }
    }
}
