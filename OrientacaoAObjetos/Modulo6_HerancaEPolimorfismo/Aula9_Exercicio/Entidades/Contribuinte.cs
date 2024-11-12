namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula9_Exercicio.Entidades
{
    internal abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoImposto();
    }
}
