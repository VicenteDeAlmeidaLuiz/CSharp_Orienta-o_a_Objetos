using OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula2_ExcecoesPersonalizadas.Entidades.Excecoes;

namespace OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula2_ExcecoesPrsonalizadas.Entidades
{
    internal class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reserva()
        {
        }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {

                throw new DominioException("A data de checkout deve ser maior que a data de checkin!!");

            }
            NumeroQuarto = numeroQuarto;
            Checkin = checkIn;
            Checkout = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = Checkout.Subtract(Checkin);
            return (int)duracao.TotalDays;


        }

        public void AtualizacaoDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime dataatual = DateTime.Now;
            if (checkIn < dataatual || checkOut < dataatual)
            {
               throw new DominioException ("As datas de reservas para atualização devem ser datas futuras!!!");


            }
            if (checkOut <= checkIn)
            {

               throw new DominioException ("A data de checkout deve ser maior que a data de checkin!!");

            }
            Checkin = checkIn;
            Checkout = checkOut;
            


        }
        public override string ToString()
        {
            return "Quarto "
                + NumeroQuarto
                + ", checkin: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out "
                + Checkout.ToString("dd/MM/yyyy,")
                + Duracao()
                + " noites.";
        }
    }
}
