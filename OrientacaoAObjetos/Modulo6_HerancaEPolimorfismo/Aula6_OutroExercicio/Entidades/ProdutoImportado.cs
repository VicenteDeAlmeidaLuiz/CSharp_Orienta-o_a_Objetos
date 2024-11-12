using System.Globalization;

namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula6_OutroExercicio.Entidades
{
    internal class ProdutoImportado : Produto
    {
        public double CustoDeAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double custoDeAlfandega) : base(nome, preco)
        {
            CustoDeAlfandega = custoDeAlfandega;
        }

        public override string EtiquetaDePreco()
        {
            return Nome
                + " R$ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custos com a alfândega: R$ "
                + CustoDeAlfandega.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

        public double PrecoTotal()
        {
            return Preco + CustoDeAlfandega;

        }
    }
}
