using System.Globalization;

namespace ProjetoConta
{
    internal class ContaBancaria
    {
        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numero)
        {
            _nome = nome;
            Numero = numero;
        }

        public ContaBancaria(string nome, int numero, double depositoInicial) : this(nome, numero)
        {
            Deposito(depositoInicial);
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != _nome && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saldo)
        {
            Saldo = Saldo - saldo - 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
