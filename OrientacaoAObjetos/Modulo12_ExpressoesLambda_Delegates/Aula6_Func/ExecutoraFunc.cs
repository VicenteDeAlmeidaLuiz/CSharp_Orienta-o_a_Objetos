using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula6_Func.Entidades;


namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula6_Func;

internal class ExecutoraFunc


{
    static void Main(string[] args)
    {
        List<ProdutosFunc> produtos = new List<ProdutosFunc>();
        produtos.Add(new ProdutosFunc("TV", 900.00));
        produtos.Add(new ProdutosFunc("Geladeira", 1900.00));
        produtos.Add(new ProdutosFunc("Fogão", 300.00));
        produtos.Add(new ProdutosFunc("Maquina de Lavar", 2000.00));

        Func<ProdutosFunc, string> func = NomeMaiusculo;

        /*Gerar uma lista contendo os nomes dos produtos em caixa alta*/
        List<string> resultado = produtos.Select(func).ToList();
        foreach (string s in resultado)
        {
            Console.WriteLine(s);

        }
    }
    static string NomeMaiusculo(ProdutosFunc pf)
    {
        return pf.Nome.ToUpper();

    }


}
