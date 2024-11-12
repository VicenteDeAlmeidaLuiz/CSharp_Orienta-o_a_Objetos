using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.EntidadesFormas;
using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Enums;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Entidades
{
    internal class Circuloo : AbstrataForma
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
        public override string ToString()
        {
            return "Cor do círculo: = "
                + Cor 
                + ", raio = "
                + Raio.ToString("F2",CultureInfo.InvariantCulture)
                +", area = "
                + Area().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
