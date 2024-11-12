

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula4_FuncoesParaString;

internal class StringFuncoes
{
    static void Main(string[] args)
    {
        /*Função para coverter todas as strings para maíusculo*/

        string original = "abcde FGHIJ ABC abc DEFG        ";
        string s1 = original.ToUpper();
        Console.WriteLine("Original: " + original + "-");
        Console.WriteLine("ToUpper: " + s1 + "-");
        Console.WriteLine("____________________________________");
        /*Função para coverter todas as strings para minusculo*/
        string s2 = original.ToLower();
        Console.WriteLine("Original: " + original + "-");
        Console.WriteLine("ToLower: " + s2 + "-");
        Console.WriteLine("____________________________________");
        /*Função para apagar os espaços em branco*/
        string s3 = original.Trim();
        Console.WriteLine("Original: " + original + "-");
        Console.WriteLine("Trim: " + s3 + "-");
        Console.WriteLine("____________________________________");
        /*Função de procura,índice a partir de uma parte da string,nesse caso a primeira ocorrência*/
        int numero1 = original.IndexOf("bc");
        Console.WriteLine("Index of('bc')" + numero1);
        /*Função de procura,índice a partir de uma parte da string,nesse caso a última ocorrência*/
        Console.WriteLine("____________________________________");
        int numero2 = original.LastIndexOf("bc");
        Console.WriteLine("LastIndexof('bc')" + numero2);
        Console.WriteLine("____________________________________");
        /*Recortar a string a partir de um certo ponto*/
        string s4 = original.Substring(3);/*Aqui eu recorto a string da posição 3 em diante*/
        Console.WriteLine("Substring 3" + s4);
        Console.WriteLine("____________________________________");
        string s5 = original.Substring(3, 5);/*Aqui eu imprimo cinco caracteres a partir da poisção 3*/
        Console.WriteLine("Substring 3,5 " + s5);
        Console.WriteLine("____________________________________");
        /*Substituir uma parte da string por outra*/
        string s6 = original.Replace('a', 'x'); /*Aqui eu troco todo o caracter a pelo caracter x*/
        Console.WriteLine("Replace de a por x: " + s6);
        Console.WriteLine("____________________________________");
        string s7 = original.Replace("abc", "def");/*Aqui eu troco a ocorrência inteira*/
        Console.WriteLine("Trocando todas as ocrrências de abc por def: " + s7);
        Console.WriteLine("____________________________________");
        /*Testando para ver se o conteúdo é nulo ou vazio*/
        string original1 = "";
        bool b1 = String.IsNullOrEmpty(original1); /*Testando true*/
        Console.WriteLine("É nulo ou vazio o conteúdo da string? " + b1);
        bool b2 = String.IsNullOrEmpty(original); /*Testando false*/
        Console.WriteLine("É nulo ou vazio o conteúdo da string? " + b2);
        /*Testando para ver se o conteúdo é nulo ou um monte de espaço em branco*/
        bool b3 = String.IsNullOrWhiteSpace(original);
        Console.WriteLine("A string é nula ou um monte de espaço em branco? " + b3);
        string original2 = "                ";
        bool b4 = String.IsNullOrWhiteSpace(original2);
        Console.WriteLine("A string é nula ou um monte de espaço em branco? " + b4);









    }
}
