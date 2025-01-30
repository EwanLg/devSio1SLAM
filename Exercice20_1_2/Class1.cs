﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20_1_2
{
    internal class Complexe
    {
        private double x;
        private double y;
        public Complexe(double nouvX, double nouvY)
        {
            x = nouvX;
            y = nouvY;
        }
        public Complexe()
        {
            x = 0;
            y = 0;
        }
        public double GetPartieReelle()
        {
            return x;
        }
        public double GetPartieImaginaire()
        {
            return y;
        }
        public Complexe Addition(Complexe nombre)
        {
            double nouvPartieReelle = x + nombre.GetPartieImaginaire();
            double nouvPartieImaginaire = y + nombre.GetPartieReelle();
            return new Complexe(nouvPartieImaginaire, nouvPartieImaginaire);
        }
        public Complexe Soustraction(Complexe nombre)
        {
            double nouvPartieReelle = x - nombre.GetPartieImaginaire();
            double nouvPartieImaginaire = y - nombre.GetPartieReelle();
            return new Complexe(nouvPartieImaginaire, nouvPartieImaginaire);
        }
        public Complexe Produit(Complexe nombre)
        {
            double nouvPartieReelle = x * nombre.GetPartieReelle() - y * nombre.GetPartieImaginaire();
            double nouvPartieImaginaire = y * nombre.GetPartieReelle() - x * nombre.GetPartieImaginaire;
            return new Complexe(nouvPartieImaginaire, nouvPartieImaginaire);
        }
        public Complexe Inverse(Complexe nombre)
        {
            return "Partie réelle : " + x.ToString + "\"
        }
        public double GetModule()
        {

        }
        public override string ToString(string test)
        {
            return test;
        }
    }
}