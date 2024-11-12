using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.EntidadesFormas;
using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Enums;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Entidades
{
    internal class Retanguloo : AbstrataForma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Cor do Retângulo: "
                + Cor
                + ", largura =  "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + " ,altura = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ",area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
