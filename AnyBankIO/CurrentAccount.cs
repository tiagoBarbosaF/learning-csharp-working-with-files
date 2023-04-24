using System.Globalization;

namespace AnyBankIO
{
    public class CurrentAccount
    {
        public int Number { get; }
        public int Agency { get; }
        public double Balance { get; private set; }
        public Client Holder { get; set; }

        public CurrentAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.", nameof(value));
            }

            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Withdraw value must be greater than zero.", nameof(value));
            }

            if (value > Balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            Balance += value;
        }

        public override string ToString()
        {
            return $"\nAgency: {Agency}\n" +
                   $"Number: {Number}\n" +
                   $"Balance: {Balance.ToString("F").Replace(".",",")}\n" +
                   $"Holder:\n" +
                   $"- Name: {Holder.Name}";
        }
    }
}
