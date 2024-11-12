using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula1_Enumeracoes.Entidades.Enums;


namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula1_Enumeracoes.Entidades;

internal class Pedido
{
    public int Id { get; set; }
    public DateTime Momento { get; set; }
    public StatusPedido Status { get; set; }


    public override string ToString()
    {
        return Id
            + ","
            + Momento
            + ","
            + Status;
    }


}
