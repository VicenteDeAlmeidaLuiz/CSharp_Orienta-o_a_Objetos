using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula9_LinqComLambda.Entidades;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula9_LinqComLambda;

internal class ClasseExecutoraComLambda
{
    static void Imprime<T>(string mensagem, IEnumerable<T> colecao)
    {
        Console.WriteLine(mensagem);
        foreach (T obj in colecao)
        {
            Console.WriteLine(obj);

        }
        Console.WriteLine();


    }
    static void Main(string[] args)
    {
        Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramenta", Classificação = 2 };
        Categoria c2 = new Categoria() { Id = 2, Nome = "Computador", Classificação = 1 };
        Categoria c3 = new Categoria() { Id = 3, Nome = "Eletrônico", Classificação = 1 };

        List<Artigo> artigos = new List<Artigo>() {
            new Artigo(){Id = 1,Nome = "Computador",Preco = 1100.0,Categoria = c2 },
            new Artigo(){Id = 2,Nome = "Martelo",Preco = 90.0,Categoria = c1 },
            new Artigo(){Id = 3,Nome = "TV",Preco = 1700.0,Categoria = c3 },
            new Artigo(){Id = 4,Nome = "Notebook",Preco = 1300.0,Categoria = c2 },
            new Artigo(){Id = 5,Nome = "Serra",Preco = 80.0,Categoria = c1 },
            new Artigo(){Id = 6,Nome = "Tablet",Preco = 700.0,Categoria = c3 },
            new Artigo(){Id = 7,Nome = "Camera",Preco = 700.0,Categoria = c3 },
            new Artigo(){Id = 8,Nome = "Impressora",Preco = 350.0,Categoria = c1 },
            new Artigo(){Id = 9,Nome = "MacBook",Preco = 1800.0,Categoria = c2 },
            new Artigo(){Id = 10,Nome = "Sound Bar",Preco = 700.0,Categoria = c3 },
            new Artigo(){Id = 11,Nome = "Nível",Preco = 70.0,Categoria = c1 }
};
        /*Agora usando o linq*/
        var resultado1 = artigos.Where(artigo => artigo.Categoria.Classificação == 1 && artigo.Preco < 900.0);
        Imprime("Produtos da classificação 1 e preço menor que 900", resultado1);

        var resultado2 = artigos.Where(artigo => artigo.Categoria.Nome == "Ferramenta").Select(artigo => artigo.Nome);
        Imprime("Nomes dos produtos classificação ferramenta:", resultado2);

        var resultado3 = artigos.Where(artigo => artigo.Nome[0] == 'C').Select(artigo => new { artigo.Nome, artigo.Preco, CategoriaNome = artigo.Categoria.Nome });
        Imprime("Nomes começados com C e objeto anonimo", resultado3);

        var resultado4 = artigos.Where(artigo => artigo.Categoria.Classificação == 1).OrderBy(artigo => artigo.Preco).ThenBy(artigo => artigo.Nome);
        Imprime("Artigos de classificação 1 ordenados por preço e por nome:", resultado4);

        var resultado5 = resultado4.Skip(2).Take(4);
        Imprime("Pula 2 artigos e pega os próximos quatro com relação a variável resultado 4 ", resultado5);

        var resultado6 = artigos.Skip(2).Take(4);
        Imprime("Pula 2 artigos e pega os próximos quatro com relação a lista geral de artigos ", resultado6);

        var resultado7 = artigos.Max(artigo => artigo.Preco);
        Console.WriteLine("O maior preço da lista é " + resultado7);

        var resultado8 = artigos.Min(artigo => artigo.Preco);
        Console.WriteLine("O menor preço da lista é " + resultado8);

        var resultado9 = artigos.Where(artigo => artigo.Categoria.Id == 1).Sum(artigo => artigo.Preco);
        Console.WriteLine("Soma de preços da categoria 1: " + resultado9);

        var resultado10 = artigos.Where(artigo => artigo.Categoria.Id == 1).Average(artigo => artigo.Preco);
        Console.WriteLine("Média de preços da categoria 1: " + resultado10);
        Console.WriteLine("_________________________________________");

        /*Agrupando a base de dados por categoria*/
        var resultado11 = artigos.GroupBy(artigo => artigo.Categoria);
        foreach (IGrouping<Categoria, Artigo> grupo in resultado11)
        {
            Console.WriteLine("Categoria " + grupo.Key.Nome + ":");
            foreach (Artigo artigo in grupo)
            {
                Console.WriteLine(artigo);


            }
            Console.WriteLine();

        }






    }
}
