namespace BankAccount
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            bankAccount.DisplayMenu();
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bankAccount.Deposit();
                    break;
                case "2":
                    bankAccount.Withdraw();
                    break;
                case "3":
                    bankAccount.ShowBalance();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the bank system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}