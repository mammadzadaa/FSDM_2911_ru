using System.Collections.Generic;

namespace Chain_of_Responsibility
{
    static class AccountDatabase
    {
        public static List<Account> accounts;
        static AccountDatabase()
        {
            accounts = new List<Account>()
            {
                new Account() { CardHolder = "Alex", CardNumber = "1111", Pin = "1111", Amount = 1000},
                new Account() { CardHolder = "Samir", CardNumber = "2222", Pin = "2222", Amount = 800},
                new Account() { CardHolder = "Maga", CardNumber = "3333", Pin = "3333", Amount = 1200}
            };
        }
    }

}
 