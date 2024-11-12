using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades.Enums;

namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades
{
    internal class Retangulo : Figura /*Aqui como eu estou herdando a classe abstrata eu também fico obrigado a implementar o método abstrato da 
                                       superclasse*/
    {
        public Retangulo( double largura,double altura,Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public double  Largura { get; set; }
        public double Altura { get; set; }




        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
