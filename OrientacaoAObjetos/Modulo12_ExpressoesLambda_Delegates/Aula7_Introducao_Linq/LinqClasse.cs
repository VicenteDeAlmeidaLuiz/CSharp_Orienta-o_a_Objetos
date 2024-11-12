namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula7_Introducao_Linq;

internal class LinqClasse
{

    static void Main(string[] args)
    {
        /*Passo 1 - Especificar a fonte de dados,poderia ser uma lista,coleção,arquivo banco de dados etc mas aqui vai ser vetor*/
        int[] numeros = new int[] { 1, 2, 3, 4, 5 };
        /*Passo 2 - Definir a consulta*/
        IEnumerable<int> resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 10); /*Condição para pegar somente os números pares e ,ultiplicar por 10*/
        /*Passo 3 - Executar a consulta*/

        foreach (int x in resultado)
        {
            Console.WriteLine(x);

        }


    }







}

/*LINQ - Language Integrated Query é a consulta integrada a linguagem
É um conjunto de tcs baseadas na integração de funcionalidades de consulta diretamente na linguagem C#.
Possui diversas operaçãoes de consulta cujos parâmetrso tipicamente são expressões lambda ou expressões de sintaxe similar à SQL.*/
