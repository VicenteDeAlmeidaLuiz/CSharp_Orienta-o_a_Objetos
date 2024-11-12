namespace OrientacaoAObjetos.Modulo8_TrabalhandoComArquivos.Aula2_FileStream_StreamReader;

internal class Aula
{
    static void Main(string[] args)
    {
        string path = @"c:\temp\file1.txt";

        StreamReader sr = null;

        try
        {
            /*Instanciei o arquivo para abrir e acessar*/

            sr = File.OpenText(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);

            }



        }
        catch (IOException e)
        {
            Console.WriteLine("Um erro ocorreu. ");
            Console.WriteLine(e.Message);

        }
        finally
        {
            if (sr != null) sr.Close();


        }


    }
}
