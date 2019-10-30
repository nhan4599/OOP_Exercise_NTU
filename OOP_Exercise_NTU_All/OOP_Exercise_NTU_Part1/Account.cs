using System;

namespace OOP_Exercise_NTU_All
{
    class Account
    {
        private string id, name;
        private int balance;

        public Account(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.balance = 0;
        }

        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public int Credit(int amount)
        {
            return this.balance += amount;
        }

        public int Debit(int amount)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return this.balance;
        }

        public int TransferTo(Account another, int amount)
        {
            if (amount <= this.balance)
            {
                this.Debit(amount);
                another.Credit(amount);
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return this.balance;
        }

        public override string ToString()
        {
            return string.Format("Account[id={0},name={1},balance={2}]",
                this.id, this.name, this.balance);
        }
    }
}
