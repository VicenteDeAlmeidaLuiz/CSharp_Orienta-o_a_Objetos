namespace OrientacaoAObjetos.Modulo8_TrabalhandoComArquivos.Aula6_Path;

internal class PathAula
{
    static void Main(string[] args)
    {
        /*Realiza operações com string que contém informações de arquivos ou pastas*/

        string path = @"C:\temp\MinhaPastaCsharp\file1.txt";
        Console.WriteLine("DirectorySeparatorChar " + Path.DirectorySeparatorChar); /*Mostra qula é o separadpr de caracteres*/
        Console.WriteLine("PathSeparator " + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName " + Path.GetDirectoryName(path)); /*Pega somente até a pasta sem arquivo*/





    }
}
