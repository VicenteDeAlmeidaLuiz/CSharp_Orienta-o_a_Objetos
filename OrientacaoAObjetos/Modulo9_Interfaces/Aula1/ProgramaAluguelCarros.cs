using OrientacaoAObjetos.Modulo9_Interfaces.Aula1.Entidades;
using OrientacaoAObjetos.Modulo9_Interfaces.Aula1.Servicos;
using OrientacaoAObjetos.Modulo9_Interfaces.Entidades;
using OrientacaoAObjetos.Modulo9_Interfaces.Servicos;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula1
{
    internal class ProgramaAluguelCarros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da locação: ");
            Console.Write("Modelo do carro? ");
            string modeloCarro = Console.ReadLine();
            Console.Write("Horário da retirada(dd/MM/yyyy hh:ss)? ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Horário da devolução(dd/MM/yyyy hh:ss)? ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarroAluguel aluguel = new CarroAluguel(retirada, devolucao, new Veiculo(modeloCarro));
            AluguelServico aluguelServico = new AluguelServico(hora, dia, new ImpostosServicos());
            aluguelServico.ProcessarNotaFiscal(aluguel);
            Console.WriteLine();

            Console.WriteLine("Nota Fiscal: ");
            Console.WriteLine(aluguel.NotaFiscal);






        }
    }
}
