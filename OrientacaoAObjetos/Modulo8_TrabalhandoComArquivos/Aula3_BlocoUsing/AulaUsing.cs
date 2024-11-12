namespace OrientacaoAObjetos.Modulo8_TrabalhandoComArquivos.Aula3_BlocoUsing;

internal class AulaUsing
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"c:\temp\file1.txt";


            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);


                }

            };
        }
        catch (IOException e)
        {
            Console.WriteLine("Ocorreu um erro!!");
            Console.WriteLine(e.Message);

        }
    }
}

