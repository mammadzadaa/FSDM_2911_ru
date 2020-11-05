using System;
using System.Linq;

namespace Chain_of_Responsibility
{
    class CheckAmount : IOperationHandeler
    {
        public IOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string pin, decimal moneyToWithdraw)
        {
            var account = AccountDatabase.accounts.FirstOrDefault(x => x.CardNumber == cardNumber);
            if (account.Amount >= moneyToWithdraw)
            {
                Next.Handle(cardNumber, pin, moneyToWithdraw);
            }
            else
            {
                Console.WriteLine("Not enogh money to withdraw");
            }
        }
    }

}
 