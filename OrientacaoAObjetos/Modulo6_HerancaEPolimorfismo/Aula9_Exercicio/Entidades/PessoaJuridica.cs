namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula9_Exercicio.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(int numeroFuncionarios, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalculoImposto()
        {


            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;



            }
        }
    }
}
