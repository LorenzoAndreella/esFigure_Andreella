using System;
using System.Collections.Generic;
using System.Text;

namespace esFigure
{
    public class CQuadrato : CRettangolo
    {
        public CQuadrato(string nome, double bas, double altezza) : base(nome, bas, altezza)
        {
        }
        public override double CalcoloArea()
        {
            return Base * Base;
        }

        public override double CalcoloPerimetro()
        {
            return Base * 4;
        }
        public override string Descrizione()
        {
            return $"Figura: {Nome},    Area: {CalcoloArea()},      Perimetro:{CalcoloPerimetro()},     Lato: {Base}";
        }
    }
}
