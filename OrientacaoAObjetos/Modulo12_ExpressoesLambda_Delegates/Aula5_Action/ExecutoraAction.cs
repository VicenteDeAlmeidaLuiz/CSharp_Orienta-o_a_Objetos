using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula4_Predicate.Entidades;
using System.Collections.Generic;

namespace orientacaoaobjetos.modulo12_expressoeslambda_delegates.aula5_action;

internal class ExecutoraAction
{

    static void Main(string[] args)
    {
        List<ProdutoAction> produtos = new List<ProdutoAction>();
        produtos.Add(new ProdutoAction("Tv", 900.00));
        produtos.Add(new ProdutoAction("Mouse", 50.00));
        produtos.Add(new ProdutoAction("Tablet", 350.50));
        produtos.Add(new ProdutoAction("Estojo", 80.90));

        Action<ProdutoAction> action = AtualizaPreco;

        produtos.ForEach(AtualizaPreco);

        foreach (ProdutoAction pa in produtos)
        {
            Console.WriteLine(pa);
        }

        /*Aumentar o preço dos produtos em 10 por cento*/


    }

    static void AtualizaPreco(ProdutoAction pa)
    {
        pa.Preco += pa.Preco * 0.1;

    }
}
