using System;
using Testing;

public class Program
{
    public static void Main()
    {
        Account MikeAccount = new Account(111222333, 1112, 0);
        Account ChrisAccount = new Account(111222111, 1234, 20000);

        Account[] Accounts = new Account[2];
        Accounts[0] = MikeAccount;
        Accounts[1] = ChrisAccount;

        Atm BankAtm01 = new Atm(30000, Accounts);

        Console.WriteLine("Mike: " + BankAtm01.CheckAccountBalance(1112, 111222333));
        Console.WriteLine("Andrew: " + BankAtm01.CheckAccountBalance(1234, 111222111));

        Console.WriteLine("Atm is empty: " + BankAtm01.IsEmpty());

        Console.WriteLine("Mike deposit 3000: " + BankAtm01.Deposit(1112, 111222333, 3000));
        Console.WriteLine("Andrew withdraw 30000: " + BankAtm01.Withdraw(1234, 111222111, 30000));

        Console.WriteLine("Atm is empty: " + BankAtm01.IsEmpty());

        Console.WriteLine("Mike withdraw 3000: " + BankAtm01.Withdraw(1112, 111222333, 3000));
        Console.WriteLine("Andrew withdraw 100: " + BankAtm01.Withdraw(1234, 111222111, 100));

        Console.WriteLine("Atm is empty: " + BankAtm01.IsEmpty());

        Console.WriteLine("Andrew deposit 100: " + BankAtm01.Deposit(1234, 111222111, 100));

        Console.WriteLine("Mike: " + BankAtm01.CheckAccountBalance(1112, 111222333));
        Console.WriteLine("Andrew: " + BankAtm01.CheckAccountBalance(1234, 111222111));

        Console.WriteLine("Atm is empty: " + BankAtm01.IsEmpty());
    }
}