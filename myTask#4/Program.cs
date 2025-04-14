namespace myTask_4
{
    internal class Program
    {
        public static class AccountUtil
        {
            public static void Deposit(List<Account> account, double amount)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].Deposit(amount))
                    {
                        Console.WriteLine($"{account[i].Name} is deposit successfully {account[i].Balance}");
                    }
                    else
                    {
                        Console.WriteLine($"{account[i].Name} is deposit failed {account[i].Balance}");
                    }
                }

            }

            public static void WithDraw(List<Account> account, double amount)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].Withdraw(amount))
                    {
                        Console.WriteLine($"{account[i].Name}  withdraw successfully {account[i].Balance}");
                    }
                    else
                    {
                        Console.WriteLine($"{account[i].Name}  withdraw failed {account[i].Balance}");
                    }
                }

            }

            public static void WithDraw2(List<SavingAccount> savaccount, double amount)
            {
                for (int i = 0; i < savaccount.Count; i++)
                {
                    if (savaccount[i].Withdraw(amount))
                    {
                        Console.WriteLine($"{savaccount[i].Name}  withdraw successfully {savaccount[i].Balance}");
                    }
                    else if (amount > savaccount[i].Balance * 0.2)
                    {
                        Console.WriteLine($"the amount is greater than 20%");
                    }
                    else
                    {
                        Console.WriteLine($"{savaccount[i].Name}  withdraw failed {savaccount[i].Balance}");
                    }
                }

            }
        }


        static void Main(string[] args)
        {

            List<Account> accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));
            AccountUtil.Deposit(accounts, 1000);
            Console.WriteLine("======================================");
            AccountUtil.WithDraw(accounts, 300);

            Console.WriteLine("======================================");

            //Saving
            List<Account> savAccounts = new List<Account>();
            savAccounts.Add(new SavingAccount());
            savAccounts.Add(new SavingAccount("Superman"));
            savAccounts.Add(new SavingAccount("Batman", 2000));
            savAccounts.Add(new SavingAccount("Wonderwoman", 5000, 5.0));
            AccountUtil.Deposit(savAccounts, 1000);
            Console.WriteLine("======================================");
            AccountUtil.WithDraw(savAccounts, 100);

            Console.WriteLine("======================================");

            //Checking
            List<Account> checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));
            AccountUtil.Deposit(checAccounts, 1000);
            Console.WriteLine("======================================");
            AccountUtil.WithDraw(checAccounts, 500);

            Console.WriteLine("======================================");

            //trust
            List<SavingAccount> trustAccounts = new List<SavingAccount>();
            List<Account> trsAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));
            AccountUtil.Deposit(trsAccounts, 1000);
            AccountUtil.Deposit(trsAccounts, 6000);
            AccountUtil.WithDraw2(trustAccounts, 600);
           


        }
    }
}
