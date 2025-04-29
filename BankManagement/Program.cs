using System;
using System.Collections.Generic;

class BankAccount{
    private string accountHolder;
    private double balance;

    public BankAccount(string holderName){
        accountHolder=holderName;
        balance=0.0;
    }

    public void Deposit(double amount){
        if(amount >0){
            balance+=amount;
            Console.WriteLine($"Deposited {amount} successfully!");
        }

        else
        {
            Console.WriteLine("Invalid amount. Deposit must be greater than zero.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount} successfully!");
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient balance.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
    }
}


class BankManagement{
    public static void Main(string[] args){
        Console.WriteLine("Welcome to Simple Bank Account Manager");

        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        BankAccount myAccount = new BankAccount(name);

        bool running = true;

        while(running){
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice){
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    myAccount.Deposit(depositAmount);
                    break;

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    myAccount.Withdraw(withdrawAmount);
                    break;

                case 3:
                    myAccount.CheckBalance();
                    break;

                case 4:
                    running = false;
                    Console.WriteLine("Thank you for using Bank Account Manager!");
                    break;

                case 5:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

