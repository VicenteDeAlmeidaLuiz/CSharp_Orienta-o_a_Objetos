using OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula2_ExcecoesPersonalizadas.Entidades.Excecoes;
using OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula2_ExcecoesPrsonalizadas.Entidades;

namespace OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula2_ExcecoesPrsonalizadas
{
    internal class ReservaExecutora
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de entrada(dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saida(dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(numeroQuarto, checkin, checkout);
                Console.WriteLine($"Reserva:{reserva}");
                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva:");
                Console.Write("Data de entrada(dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saida(dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.AtualizacaoDatas(checkin, checkout);
                Console.WriteLine($"Reserva:{reserva} ");
            }
            catch (DominioException d)
            {
                Console.WriteLine("Erro na reserva: " + d.Message);


            }
            catch (FormatException f)
            {
                Console.WriteLine("Por favor preencha somente números." + f.Message);

            }




        }





    }
}

