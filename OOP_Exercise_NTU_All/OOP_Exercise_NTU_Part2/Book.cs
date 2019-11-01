
using System;

namespace OOP_Exercise_NTU_Part2
{
    class Book
    {
        private string name;
        private Author[] authors;
        private double price;
        private int qty;

        public Book(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = 0;
        }

        public Book(string name, Author[] authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public string GetName()
        {
            return this.name;
        }

        public Author[] GetAuthors()
        {
            return this.authors;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public int GetQty()
        {
            return this.qty;
        }

        public void SetQty(int qty)
        {
            this.qty = qty;
        }

        public override string ToString()
        {
            string temp = string.Empty;
            Array.ForEach(this.authors, m => temp += m.ToString() + ",");
            temp = temp.Remove(temp.Length - 1);
            return string.Format("Book[name={0},authors={{{1}}},price={2},qty={3}]",
                this.name, string.Join(",", temp), this.price, this.qty);
        }

        public string GetAuthorNames()
        {
            string str = String.Empty;
            Array.ForEach(this.authors, author => str += author.GetName() + ",");
            str = str.Remove(str.Length - 1);
            return str;
        }
    }
}
