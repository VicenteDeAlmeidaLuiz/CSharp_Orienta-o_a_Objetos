namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula3_GetHashEEquals;

internal class GetHashCode
{
    /*Método que retorna um número inteiro representando um código gerado a partir das informaçãoes do objeto*/
    static void Main(string[] args)
    {
        string a = "Maria";
        string b = "João";

        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
    }


}
