using System.Linq;

namespace Chain_of_Responsibility
{
    class UpdateAmountAfterWithdraw : IOperationHandeler
    {
        public IOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string pin, decimal moneyToWithdraw)
        {
            var account = AccountDatabase.accounts.FirstOrDefault(x => x.CardNumber == cardNumber);
            account.Amount -= moneyToWithdraw;
        }
    }

}
 