namespace ExercicioFixacao
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaBancaria contaBancaria;

      System.Console.Write("Entre o número da conta: ");
      int numeroConta = int.Parse(Console.ReadLine());

      System.Console.Write("Entre o titular da conta: ");
      string titularConta = Console.ReadLine();

      System.Console.Write("Haverá depósito inicial (s/n)? ");
      char resposta = char.Parse(Console.ReadLine());

      if (Char.ToLower(resposta) == 's')
      {
        System.Console.Write("Entre o valor de depósito inicial: ");
        double quantia = double.Parse(Console.ReadLine());
        contaBancaria = new ContaBancaria(numeroConta, titularConta, quantia);
      }
      else
      {
        contaBancaria = new ContaBancaria(numeroConta, titularConta);
      }

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