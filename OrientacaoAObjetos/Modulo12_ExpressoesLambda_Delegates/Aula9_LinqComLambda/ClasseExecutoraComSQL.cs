using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula9_LinqComLambda.Entidades;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula9_LinqComLambda;

internal class ClasseExecutoraComSQL
{
    static void ImprimeSql<T>(string mensagem, IEnumerable<T> colecao)
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
        var resultado1 = from artigo in artigos
                         where artigo.Categoria.Classificação == 1 && artigo.Preco < 900.0
                         select artigo;
        ImprimeSql("Classificação 1 e preço menor que 900 ", resultado1);

        var resultado2 = from artigo in artigos
                         where artigo.Categoria.Nome == "Ferramenta"
                         select artigo.Nome;
        ImprimeSql("Nomes dos produtos que são ferramentas: ", resultado2);

        var resultado3 = from artigo in artigos
                         where artigo.Nome[0] == 'C'
                         select new
                         {
                             artigo.Nome,
                             artigo.Preco,
                             CategoriaNome = artigo.Categoria.Nome

                         };
        ImprimeSql("Nomes iniciados com C e objetos anônimos ", resultado3);

        var resultado4 = from artigo in artigos
                         where artigo.Categoria.Classificação == 1
                         orderby artigo.Nome
                         orderby artigo.Preco
                         select artigo;
        ImprimeSql("Artigos ordenados por nome e preço ", resultado4); /*Preços iguais ordenação por ordem alfabética*/

        var resultado5 = from artigo in artigos
                         group artigo by artigo.Categoria;
        ImprimeSql("Artigos ordenados por categoria", resultado5);

        foreach (IGrouping<Categoria, Artigo> grupo in resultado5)
        {
            Console.WriteLine("Categoria " + grupo.Key.Nome + ":");
            foreach (Artigo artigo in grupo)
            {
                Console.WriteLine(artigo);
            }

        }
    }
}

