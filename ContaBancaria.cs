using System.Globalization;

class ContaBancaria
{
  public int Numero { get; private set; }
  private string Titular { get; set; }
  public double Saldo { get; private set; }
  private const double TAXA = 5;

  public ContaBancaria(int numero, string titular)
  {
    Numero = numero;
    Titular = titular;
    Saldo = 0.00;
  }

  public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
  {
    Saldo = saldo < 0 ? 0 : saldo;
  }

  public void Depositar(double valor)
  {
    this.Saldo += valor;
  }

  public void Sacar(double valor)
  {
    this.Saldo = (this.Saldo - valor) - TAXA;
  }

  public override string ToString()
  {
    return $"Conta: {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
  }
}