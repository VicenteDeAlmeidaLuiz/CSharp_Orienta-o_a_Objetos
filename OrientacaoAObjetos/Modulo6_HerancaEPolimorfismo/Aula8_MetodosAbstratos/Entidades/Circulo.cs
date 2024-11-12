using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades.Enums;

namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades
{
    internal class Circulo : Figura

    {
        public double Raio { get; set; }
        public Circulo(double raio,Cor cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
