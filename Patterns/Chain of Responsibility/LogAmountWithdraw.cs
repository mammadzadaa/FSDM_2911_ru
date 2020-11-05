using System;
using System.Linq;

namespace Chain_of_Responsibility
{
    class LogAmountWithdraw : IOperationHandeler
    {
        public IOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string pin, decimal moneyToWithdraw)
        {
            var account = AccountDatabase.accounts.FirstOrDefault(x => x.CardNumber == cardNumber);
            Console.WriteLine($"{moneyToWithdraw} been withdrawed from {account.CardHolder}'s account");
            Next.Handle(cardNumber, pin, moneyToWithdraw);
        }
    }

}
 