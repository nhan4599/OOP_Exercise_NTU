namespace OOP_Exercise_NTU_Part2
{
    class Invoice
    {
        private readonly int id;
        private InvoiceCustomer customer;
        private double amount;

        public Invoice(int id, InvoiceCustomer customer, double amount)
        {
            this.id = id;
            this.customer = customer;
            this.amount = amount;
        }

        public int GetID()
        {
            return this.id;
        }

        public InvoiceCustomer GetCustomer()
        {
            return this.customer;
        }

        public void SetCustomer(InvoiceCustomer customer)
        {
            this.customer = customer;
        }

        public double GetAmount()
        {
            return this.amount;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public string GetCustomerName()
        {
            return this.customer.GetName();
        }

        public double GetAmountAfterDiscount()
        {
            return this.amount -= this.amount * this.customer.GetDiscount() / 100;
        }
    }
}
