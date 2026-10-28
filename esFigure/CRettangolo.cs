using System;
using System.Collections.Generic;
using System.Text;

namespace esFigure
{
    public class CRettangolo : CFigura
    {
        private double bas;
        private double altezza;
        public double Base
        {
            get { return bas; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("La base deve essere maggiore di zero.");
                }
                bas = value;

            }
        }
        public double Altezza
        {
            get { return altezza; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'altezza deve essere maggiore di zero.");
                }
                altezza = value;

            }
        }

        public CRettangolo(string nome,double bas, double altezza) : base(nome)
        {
            Base = bas;
            Altezza = altezza;
        }

        public override double CalcoloArea()
        {
            return Base * Altezza;
        }

        public override double CalcoloPerimetro()
        {
            return (Base + Altezza) * 2;
        }

        public override string Descrizione()
        {
            return base.Descrizione() + $",     Base: {Base},       Altezza: {Altezza}";
        }
    }
}
