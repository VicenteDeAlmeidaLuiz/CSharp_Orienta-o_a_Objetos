//using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula2_ComposicaoDeObjetos.Entidades;
//using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula2_ComposicaoDeObjetos.Entidades.Enums;
//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula2_ComposicaoDeObjetos;

//internal class Programa
//{
//    static void Main(string[] args) {
//        Console.Write("Digite o nome do departamento: ");
//        string deptNome = Console.ReadLine();
//        Console.WriteLine("Digite os dados do trabalhador! ");
//        Console.Write("Nome:");
//        string nome = Console.ReadLine();
//        Console.Write("Nível: (Júnior/Pleno/Sênior): ");
//        Nivel nivel = Enum.Parse<Nivel>(Console.ReadLine());
//        Console.Write("Base Salarial: ");
//        double baseSalarial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

//        Departamento dept = new Departamento(deptNome);
//        Trabalhador trabalhador = new Trabalhador(nome,nivel,baseSalarial,dept);

//        Console.Write("Quantos contratos serão cadastrados para o trabalhador? ");
//        int numeroDeContratos = int.Parse(Console.ReadLine());

//        for (int i = 1; i<=numeroDeContratos; i++) {
            
//            Console.WriteLine($"Digte os dados do contrato {i}:");
//            Console.Write("Data: (DD/MM/YYYY): ");
//            DateTime data = DateTime.Parse(Console.ReadLine());
//            Console.Write("Valor por hora: ");
//            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Duração (horas): ");
//            int horas = int.Parse(Console.ReadLine());
//            HoraContrato horaContrato = new HoraContrato(data,valorPorHora,horas);
//            trabalhador.AdicionarContrato(horaContrato); 
//        }
//        Console.WriteLine();

//        Console.Write("Digite o mês e ano para calcular o ganho (MM/YYYY): ");
//        string mesAno = Console.ReadLine();
//        int mes = int.Parse(mesAno.Substring(0,2));
//        int ano = int.Parse(mesAno.Substring(3));

//        Console.WriteLine("Nome: " + trabalhador.Nome);
//        Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
//        Console.WriteLine("Ganhos em " + mesAno + ": " + trabalhador.GanhoTotal(ano,mes).ToString("F2"),CultureInfo.InvariantCulture);
    
    
    
    
    
//    }
//}
