using OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula6_Exercicio.Entidades;

namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula6_Exercicio;

internal class Programa
{
    static void Main(string[] args)
    {
        HashSet<RegistroDeLog> set = new HashSet<RegistroDeLog>();

        Console.WriteLine("Entre com o caminho do arquivo");
        string caminho = Console.ReadLine();

        try
        {
            using (StreamReader sr = File.OpenText(caminho))
            {

                while (!sr.EndOfStream)
                {
                    string[] linha = sr.ReadLine().Split(' ');
                    string nome = linha[0];
                    DateTime instante = DateTime.Parse(linha[1]);
                    set.Add(new RegistroDeLog { NomeUsuario = nome, Instante = instante });



                }
                Console.WriteLine("Total de usuários: " + set.Count);

            }


        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);

        }


    }
}
