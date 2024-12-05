namespace BankAccount
{
    public class BankAccount
    {
        private int _balance;

        public BankAccount()
        {
            Console.Write("Enter initial balance: ");
            while (!int.TryParse(Console.ReadLine(), out _balance) || _balance < 0)
            {
                Console.WriteLine("Invalid balance. Please enter a valid positive number: ");
            }
        }
        public void Deposit()
        {
            Console.Write("Enter amount to deposit: ");
            if (int.TryParse(Console.ReadLine(), out int amount) && amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please try again.");
            }
        }
        public void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            if (int.TryParse(Console.ReadLine(), out int amount) && amount > 0)
            {
                if (amount <= _balance)
                {
                    _balance -= amount;
                    Console.WriteLine($"Withdrew: {amount}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance. Transaction canceled.");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount. Please try again.");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Current balance: {_balance}");
        }
        public void DisplayMenu()
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
    }
}