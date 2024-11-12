namespace OrientacaoAObjetos.Modulo8_TrabalhandoComArquivos.Aula4_StreamWriter;

internal class AulaStreamWriter
{
    static void Main(string[] args)
    {
        /*Stream para escrita de caracteres no arquivo*/

        string caminhoArquivoOrigem = @"c:\temp\file1.txt";
        string caminhoArquivoDestino = @"c:\temp\file2.txt";

        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivoOrigem);
            using (StreamWriter sw = File.AppendText(caminhoArquivoDestino))
            {
                foreach (string linha in linhas)
                {
                    sw.WriteLine(linha.ToUpper());

                }

            }


        }
        catch (IOException e)
        {
            Console.WriteLine("Erro ocorreu!!");
            Console.WriteLine(e.Message);


        }




    }
}
