﻿using System;

namespace CilinderForm
{
    public class Cilinder : Cirkel
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public Cilinder()
        {
            H = new Random().Next(1, 100);
        }

        public Cilinder(double x, double y, double r, double h) : base(x, y, r)
        {
            H = h;
        }

        public double Volume()
        {
            double pi = Math.PI;
            double volume = Math.Round(pi * R * R * H, 2);
            return volume;
        }

        public override double Oppervlakte()
        {
            double oppervlakte = base.Oppervlakte();

            oppervlakte = (2 * oppervlakte) + (Omtrek() * H);
            return oppervlakte;
        }

        public override string Gegevens()
        {
            string gegevens =
            $"{base.Gegevens()} hoogte = {H}\noppervlakte = {Math.Round(Oppervlakte(), 2)}\n(volume = {Math.Round(Volume(), 2)}";

            return gegevens;
        }
    }
}