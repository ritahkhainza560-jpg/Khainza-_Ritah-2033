using System;

public class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }

        if (amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        _balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        decimal depositedAmount = 50000;
        account.Deposit(depositedAmount);

        decimal withdrawnAmount = 20000;
        account.Withdraw(withdrawnAmount);

        Console.WriteLine("BANK ACCOUNT");
        Console.WriteLine("----------------------");
        Console.WriteLine("Amount Deposited: " + depositedAmount);
        Console.WriteLine("Amount Withdrawn: " + withdrawnAmount);
        Console.WriteLine("Current Balance: " + account.Balance);
    }
}
