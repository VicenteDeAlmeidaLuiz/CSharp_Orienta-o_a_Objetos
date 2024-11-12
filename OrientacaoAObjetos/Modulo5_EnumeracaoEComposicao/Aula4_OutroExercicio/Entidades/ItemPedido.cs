using System.Globalization;

namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades;

internal class ItemPedido
{
    public int Quantidade { get; set; }
    public double Preco { get; set; }

    public Produto Produto { get; set; }

    public ItemPedido()
    {
    }

    public ItemPedido(int quantidade, double preco,Produto produto)
    {
        Quantidade = quantidade;
        Preco = preco;
        Produto = produto;
    }

    public double SubTotal()
    {
        return Quantidade * Preco;


    }

    public override string ToString()
    {
        return Produto.Nome
        + ",R$"
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", Quantidade: "
        + Quantidade
        + " SubTotal: R$ "
        + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
    }
}
