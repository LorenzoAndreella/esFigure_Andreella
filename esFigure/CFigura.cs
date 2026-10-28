using System;
using System.Collections.Generic;
using System.Text;

namespace esFigure
{
    public abstract class CFigura
    {
        public string Nome { get; set; }

        public CFigura(string nome)
        {
            Nome = nome;
        }

        public abstract double CalcoloArea();
        public abstract double CalcoloPerimetro();

        public virtual string Descrizione()
        {
            return $"Figura: {Nome},        Area: {CalcoloArea()},     Perimetro: {CalcoloPerimetro()}";
        }

    }
}
