using System;
using System.Linq;

namespace Chain_of_Responsibility
{
    class VerifyAccount : IOperationHandeler
    {
        public IOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string pin, decimal moneyToWithdraw)
        {
            if(AccountDatabase.accounts.Any(x => x.CardNumber == cardNumber && x.Pin == pin))
            {
                Next.Handle(cardNumber, pin, moneyToWithdraw);
            }
            else
            {
                Console.WriteLine("Incorrect card or pin");
            }
        }
    }

}
 