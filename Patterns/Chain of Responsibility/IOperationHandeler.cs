namespace Chain_of_Responsibility
{
    interface IOperationHandeler
    {
        public IOperationHandeler Next { get; set; }
        void Handle(string cardNumber, string pin, decimal moneyToWithdraw);
    }

}
 