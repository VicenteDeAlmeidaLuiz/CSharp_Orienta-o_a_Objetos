namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula9_Exercicio.Entidades
{
    internal class PessoaFisica : Contribuinte
    {


        public double GastosSaude { get; set; }

        public PessoaFisica(double gastosSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoImposto()
        {
            if (RendaAnual < 20000.00)
            {
                return RendaAnual * 0.15 - GastosSaude * 0.5;
            }

            else
            {
                return RendaAnual * 0.25 - GastosSaude * 0.5;
            }
        }




    }


}
