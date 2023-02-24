namespace ExercicioFixacao
{
  class Program
  {
    static void Main(string[] args)
    {
      int numeroConta;
      string titularConta;
      char haveraDepositoInicial;
      double saldoInicial = 0;

      System.Console.Write("Entre o número da conta: ");
      numeroConta = int.Parse(Console.ReadLine());

      System.Console.Write("Entre o titular da conta: ");
      titularConta = Console.ReadLine();

      System.Console.Write("Haverá depósito inicial (s/n)? ");
      haveraDepositoInicial = char.Parse(Console.ReadLine());

      if (Char.ToLower(haveraDepositoInicial) == 's')
      {
        System.Console.Write("Entre o valor de depósito inicial: ");
        saldoInicial = double.Parse(Console.ReadLine());
      }

      var contaBancaria = new ContaBancaria(numeroConta, titularConta, saldoInicial);

      System.Console.WriteLine("Dados da conta atualizados:");
      System.Console.WriteLine(contaBancaria);

      System.Console.Write("Entre um valor para depósito: ");
      double valorDeposito = double.Parse(Console.ReadLine());
      contaBancaria.Depositar(valorDeposito);

      System.Console.WriteLine("Dados da conta atualizados:");
      System.Console.WriteLine(contaBancaria);

      System.Console.Write("Entre um valor para saque: ");
      double valorSaque = double.Parse(Console.ReadLine());
      contaBancaria.Sacar(valorSaque);

      System.Console.WriteLine("Dados da conta atualizados:");
      System.Console.WriteLine(contaBancaria);
    }
  }
}