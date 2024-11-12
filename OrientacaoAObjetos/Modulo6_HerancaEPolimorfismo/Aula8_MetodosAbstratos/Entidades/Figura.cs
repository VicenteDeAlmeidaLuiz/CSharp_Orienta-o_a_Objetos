using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades.Enums;

namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades
{
    internal abstract class Figura
    {
        public Cor Cor { get; set; }

        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area(); /*Aqui é a declaração de que o método é abstrato,ele obriga que a classe também seja abstrata*/
    }
}
