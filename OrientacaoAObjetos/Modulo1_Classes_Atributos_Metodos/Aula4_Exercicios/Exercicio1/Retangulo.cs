using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula4_Exercicios.Exercicio1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double calcArea = Largura * Altura;
            return calcArea;

        }

        public double Perimetro()
        {
            double calcPerimetro = 2 * (Largura + Altura);
            return calcPerimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return diagonal;

        }

        public override string ToString()
        {
            return "ÁREA = "

                 + Area().ToString("F2", CultureInfo.InvariantCulture)
                 + "\n"
                 + "PERÍMETRO = "
                 + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                 + "\n"
                 + "DIAGONAL = "
                 + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
