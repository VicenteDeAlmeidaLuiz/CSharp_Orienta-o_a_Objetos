using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula10_Exercicio.Entidades;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula10_Exercicio
{
    internal class ExecutoraProdutoExercicio
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo: ");
            string caminho = Console.ReadLine();

            List<ProdutoExercicioAula10> listaProdutos = new List<ProdutoExercicioAula10>();
            using (StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome = campos[0];
                    double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                    listaProdutos.Add(new ProdutoExercicioAula10(nome, preco));

                }


            }

            var media = listaProdutos.Select(produto => produto.Preco).DefaultIfEmpty(0.0).Average(); /*DefaultIfEmpty: se a lista for vazia ele retorna 0 enão uma excessão*/
            Console.WriteLine("Preço médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

            var nomes = listaProdutos.Where(produto => produto.Preco < media).OrderByDescending(produto => produto.Nome).Select(produto => produto.Nome);
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);

            }


        }
    }
}
