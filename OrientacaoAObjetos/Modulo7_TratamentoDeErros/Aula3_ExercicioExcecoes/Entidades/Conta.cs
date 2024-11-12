using OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula3_ExercicioExcecoes.Entidades.Excecoes;

namespace OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula3_ExercicioExcecoes.Entidades
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string cliente, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Cliente = cliente;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;

        }
        public void Saque(double valorSaque)
        {

            if (valorSaque > LimiteDeSaque)
            {
               
                throw new ExcecaoDominio("Seu valor de saque é maior que o seu limite de saque!!");
            }

            if (valorSaque > Saldo)
            {
               
              throw new ExcecaoDominio("Você não possui saldo suficiente!!");


            }

            Saldo -= valorSaque;



        }
    }
}
