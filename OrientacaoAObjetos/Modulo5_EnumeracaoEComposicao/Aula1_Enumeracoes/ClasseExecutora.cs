using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula1_Enumeracoes.Entidades;
using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula1_Enumeracoes.Entidades.Enums;
using System.Threading.Channels;

namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula1_Enumeracoes;

internal class ClasseExecutora
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido
        {
            Id = 1080,
            Momento = DateTime.Now,
            Status = StatusPedido.PagamentoPendente


        };

        Console.WriteLine(pedido);

        /*Convertendo enum para string*/

        string texto = StatusPedido.PagamentoPendente.ToString();
        Console.WriteLine(texto);

        /*Convertendo string para enum*/
        StatusPedido os = Enum.Parse<StatusPedido>("Entregue"); /*O valor aqui tem que ser um valor igual ao que eu criei lá no enum*/
        Console.WriteLine(os);




    }




}
