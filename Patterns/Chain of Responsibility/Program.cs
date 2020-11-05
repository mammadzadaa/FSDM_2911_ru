using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardNumber;
            string pin;
            decimal moneyToWithdraw;

            IOperationHandeler accountHandeler = new VerifyAccount();
            IOperationHandeler amountHandeler = new CheckAmount();
            IOperationHandeler logHandeler = new LogAmountWithdraw();
            IOperationHandeler withdrawHandeler = new UpdateAmountAfterWithdraw();

            logHandeler.Next = withdrawHandeler;
            amountHandeler.Next = logHandeler;
            accountHandeler.Next = amountHandeler;


            Console.WriteLine("Enter your card number:");
            cardNumber = Console.ReadLine();
            Console.WriteLine("Enter your pin:");
            pin = Console.ReadLine();
            Console.WriteLine("Enter amount to withdraw:");
            moneyToWithdraw = Decimal.Parse(Console.ReadLine());

            accountHandeler.Handle(cardNumber, pin, moneyToWithdraw);
        }
    }
}
 