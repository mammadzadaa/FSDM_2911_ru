using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Threading;

namespace Lesson_18_09_20_Event
{
    delegate void MyDelegate();
    class Zara
    {
        private event MyDelegate newCollectionArrived;
        public event MyDelegate NewCollectionArrived
        {
            add 
            {
                Console.WriteLine("Someone Subscribed my event");
                newCollectionArrived += value;
            }
            remove 
            {
                Console.WriteLine("Someone unsubscribed my event");
                newCollectionArrived -= value;
            }
        }


        public void CargoArrive()
        {
            newCollectionArrived.Invoke();
        }
    }
    class Timer
    {
        public event Action TimeOut;
        public void StartTimer(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.WriteLine(seconds - i);
                Thread.Sleep(1000);
            }
            TimeOut?.Invoke();
        }

    }
    enum BalanceChangeType
    {
        Deposit, Withdraw
    }
    class BalanceChangedEventArg : EventArgs
    {
        public BalanceChangedEventArg(BalanceChangeType changeType, decimal amount)
        {
            ChangeType = changeType;
            Amount = amount;
        }
        public BalanceChangeType ChangeType { get; set; }
        public decimal Amount { get; }
    }
    class BankAccount
    {
        public BankAccount(string accountHolderName, decimal balance, string number, string email)
        {
            AccountHolderName = accountHolderName;
            Balance = balance;
            Number = number;
            Email = email;
        }
        public event EventHandler BalanceChanged;
        public string AccountHolderName { get;}
        public decimal Balance { get; private set; }
        public string Number { get; }
        public string Email { get; }
   
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                BalanceChanged?.Invoke(this, new BalanceChangedEventArg(BalanceChangeType.Withdraw, amount));
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            BalanceChanged?.Invoke(this, new BalanceChangedEventArg(BalanceChangeType.Deposit, amount));

        }
    }

    static class CustomerNotificationCenter
    {
        public static void SMSNotification(object sender, EventArgs e)
        {
            if (sender is BankAccount account && e is BalanceChangedEventArg arg)
            {
                Console.WriteLine(
                                    $"Sent to {account.Number}: " +
                                    $"\n{arg.Amount} of money been {arg.ChangeType}ed" +
                                    $"\nBalance: {account.Balance} AZN"
                                    );
            }
        }

        public static void EmailNotification(object sender, EventArgs e)
        {
            if (sender is BankAccount account && e is BalanceChangedEventArg arg)
            {
                Console.WriteLine(
                                    $"\nMail to {account.Email}: " +
                                    $"\nDear {account.AccountHolderName}, " +
                                    $"\nWe would like to inform you that {arg.Amount} of money been {arg.ChangeType}ed form yout Balance" +
                                    $"\nYour new Balance is {account.Balance} AZN"
                                    );
            }
        }
    }

    class Program
    {
        static void GoShopping() { Console.WriteLine("I did my shoppng"); }
        static void ShowTimeOut() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Time Out");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        

        static void Main(string[] args)
        {

            BankAccount account = new BankAccount("Aftandil",750.0m,"+994 99 999 9999","aftandil@gmail.com");

            account.BalanceChanged += CustomerNotificationCenter.SMSNotification;
            account.BalanceChanged += CustomerNotificationCenter.EmailNotification;


            account.Withdraw(134.45m);
            Console.WriteLine();
            account.Withdraw(34.19m);
            Console.WriteLine();
            account.Deposit(231.87m);

            


            //ObservableCollection<int> list = new ObservableCollection<int>();

            //list.CollectionChanged += PrintChange;
            //list.CollectionChanged += AddToFile;

            //while (true)
            //{
            //    Console.Write("Enter the number:  ");
            //    int num = int.Parse(Console.ReadLine());
            //    list.Add(num);
            //    Console.WriteLine("Press ESC to finish input, or any button to continue");
            //    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            //        break;

            //}

            //Console.WriteLine();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Timer timer = new Timer();
            //timer.TimeOut += ShowTimeOut;

            //timer.StartTimer(10);

            //Zara t = new Zara();
            ////t.newCollectionArrived += () => Console.WriteLine("Hello");
            ////t.newCollectionArrived += Print;
            ////t.newCollectionArrived -= Print;
            //t.NewCollectionArrived += GoShopping;

            //t.CargoArrive();
        }

       

        private static void AddToFile(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    File.AppendAllText("numbers.txt", item.ToString() + " ");
                }
            }
        }

        private static void PrintChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine(e.Action);
            if (sender is ObservableCollection<int> collection)
            {
                Console.WriteLine($" Count = {collection.Count}");
            }
        }
    }
}
