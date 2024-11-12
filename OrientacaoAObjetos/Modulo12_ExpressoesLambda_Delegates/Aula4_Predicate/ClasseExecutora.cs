using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula4_Predicate.Entidades;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula4_Predicate;

internal class ClasseExecutora
{
    static void Main(string[] args)
    {
        List<ProdutoAction > produtos = new List<ProdutoAction>();
        produtos.Add(new ProdutoAction("TV", 900.00));
        produtos.Add(new ProdutoAction("Mouse", 50.00));
        produtos.Add(new ProdutoAction("Tablet", 350.50));
        produtos.Add(new ProdutoAction("Estojo", 80.90));

        /*Remover da lista somente os produtos que o preço seja maior ou igual a 100*/

        produtos.RemoveAll(produtos);
        foreach (ProdutoAction p in produtos)
        {
            Console.WriteLine(p);

        }


    }

    public static bool ProdutoTeste(ProdutoAction p)
    {
        return p.Preco >= 100.0;

    }
}
