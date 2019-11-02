namespace OOP_Exercise_NTU_Part2
{
    class Account
    {
        private readonly int id;
        private readonly AccountCustomer customer;
        private double balance;

        public Account(int id, AccountCustomer customer, double balance) : this(id, customer) => this.balance = balance;

        public Account(int id, AccountCustomer customer)
        {
            this.id = id;
            this.customer = customer;
            balance = 0;
        }

        public int GetID() => id;

        public AccountCustomer GetCustomer() => customer;

        public double GetBalance() => balance;

        public void SetBalance(double balance) => this.balance = balance;

        public override string ToString() => string.Format("{0} balance=${1}", customer, string.Format("{0:0,0.00}", balance));

        public string GetCustomerName() => customer.GetName();

        public AccountCustomer Deposit(double amount)
        {
            balance += amount;
            return customer;
        }

        public AccountCustomer Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }else
            {
                System.Console.WriteLine("amount withdraw exceeds the current balance!");
            }
            return customer;
        }
    }
}
