namespace OrientacaoAObjetos.Modulo8_TrabalhandoComArquivos.Aula1_File_FileInfo_IOException;

internal class ArquivosClasse
{
    static void Main(string[] args)
    {
        string caminhoArquivo = @"c:\temp\file1.txt"; /*Colocando o arroba eu posso digitar a barra só uma vez*/
        string caminhoArquivoDestino = @"c:\temp\file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(caminhoArquivo);
            fileInfo.CopyTo(caminhoArquivoDestino); /*Copia de um arquivo para o outro e se eu rodar de novo lança a exceção iformando que o arquivo
                                                     já existe*/
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha); /*Aqui vai imprimir o conteúdo do arquivo*/

            }



        }
        catch (IOException io)
        {
            Console.WriteLine("Um erro ocorreu!!");
            Console.WriteLine(io.Message);

        }



    }
}
