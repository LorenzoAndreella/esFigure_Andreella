using System;
using System.Collections.Generic;
using System.Text;

namespace esFigure
{
    internal class CCerchio : CFigura
    {
        private double raggio;
        public double Raggio
        {
            get { return raggio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Il raggio deve essere maggiore di zero.");
                }
                raggio = value;
            }
        }

        public CCerchio(string nome, double raggio) : base(nome)
        {
            Raggio = raggio;
        }

        public override double CalcoloArea()
        {
            return double.Pi * Raggio * Raggio;
        }

        public override double CalcoloPerimetro()
        {
            return 2 * double.Pi * Raggio;
        }

        public override string Descrizione()
        {
            return $"Figura: {Nome},    Area: {CalcoloArea()},      Circonferenza: {CalcoloPerimetro()},        Raggio: {Raggio}";
        }
    }
}
