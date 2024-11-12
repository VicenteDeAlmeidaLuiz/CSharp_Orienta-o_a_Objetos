using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades.Enum;
using System.Globalization;
using System.Text;

namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades;

internal class Pedido
{
    public DateTime Momento { get; set; }
    public SituacaoPedido Status { get; set; }
    public List<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
    public Cliente Cliente { get; set; }

    public Pedido()
    {
    }

    public Pedido(DateTime momento, SituacaoPedido status, Cliente cliente)
    {
        Momento = momento;
        Status = status;
        Cliente = cliente;
    }

    public void AdicionarItem(ItemPedido item)
    {
        ItemPedidos.Add(item);


    }

    public void RemoverrItem(ItemPedido item)
    {
        ItemPedidos.Remove(item);


    }

    public double Total()
    {
        double soma = 0.0;

        foreach (ItemPedido item in ItemPedidos)
        {
            soma += item.SubTotal();
        }

        return soma;


    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Resumo do pedido: ");
        stringBuilder.AppendLine("Data: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
        stringBuilder.AppendLine("Status do Pedido: " + Status);
        stringBuilder.AppendLine("Cliente: " + Cliente);
        stringBuilder.AppendLine("Itens do pedido: ");
        foreach (ItemPedido item in ItemPedidos)
        {
            stringBuilder.AppendLine(item.ToString());


        }
        stringBuilder.AppendLine("Preço total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return stringBuilder.ToString();

    }
}
