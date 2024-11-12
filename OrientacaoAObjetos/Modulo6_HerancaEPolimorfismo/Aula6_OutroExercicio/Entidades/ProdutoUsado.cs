namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula6_OutroExercicio.Entidades
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataDeManufatura { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco,DateTime dataManufatura) : base(nome, preco)
        {
            DataDeManufatura = dataManufatura;
        }

        public override string EtiquetaDePreco()
        {
            return Nome
                + " (usado)"
                + " R$" + Preco
                + "(Data da manufatura: "
                + DataDeManufatura.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
