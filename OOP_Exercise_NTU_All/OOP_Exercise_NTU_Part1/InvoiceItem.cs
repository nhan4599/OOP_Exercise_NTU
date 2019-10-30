
namespace OOP_Exercise_NTU_NTU
{
    class InvoiceItem
    {
        private string id, desc;
        private int qty;
        private double unitPrice;

        public InvoiceItem(string id, string desc, int qty, double unitPrice)
        {
            this.id = id;
            this.desc = desc;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }

        public string GetID()
        {
            return this.id;
        }

        public string GetDesc()
        {
            return this.desc;
        }

        public int GetQty()
        {
            return this.qty;
        }

        public void SetQty(int qty)
        {
            this.qty = qty;
        }

        public double GetUnitPrice()
        { 
            return this.unitPrice;
        }

        public void SetUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public double GetToTal()
        {
            return this.unitPrice * this.qty;
        }

        public override string ToString()
        {
            return string.Format("Invoice[id={0},desc={1},qty={2},unitPrice={3}]",
                this.id, this.desc, this.qty, this.unitPrice);
        }
    }

}