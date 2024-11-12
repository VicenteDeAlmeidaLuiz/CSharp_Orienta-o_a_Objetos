namespace OrientacaoAObjetos.Modulo8_TrabalhandoComArquivos.Aula5_Directory_DirectoryInfo
{
    internal class Aulas
    {
        /*Servem para operações com pasatas (criar uma pasta,listar arquivos,diretórios etc)*/
        static void Main(string[] args)
        {
            string path = @"C:\temp\MinhaPastaCsharp";

            try
            {
                /*Listar todas as subpastas da pasta. *.* significa qualquer nome e qualquer extensão */
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("PASTAS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                /*Listar todos os arquivos das subpastas*/
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("ARQUIVOS: ");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\novapasta"); /*Aqui criando uma pasta (ou subpasta) a partir da pasta*/


            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu!!");
                Console.WriteLine(e.Message);


            }



        }
    }
}
