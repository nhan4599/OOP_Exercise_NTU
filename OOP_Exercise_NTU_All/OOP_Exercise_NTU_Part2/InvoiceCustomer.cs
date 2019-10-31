
namespace OOP_Exercise_NTU_Part2
{
    class InvoiceCustomer
    {
        private int id, discount;
        private string name;

        public InvoiceCustomer(int id, string name, int discount)
        {
            this.id = id;
            this.name = name;
            this.discount = discount;
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetDiscount()
        {
            return this.discount;
        }

        public void SetDisCount(int discount)
        {
            this.discount = discount;
        }

        public override string ToString()
        {
            return string.Format("name({0})", this.name);
        }
    }
}
