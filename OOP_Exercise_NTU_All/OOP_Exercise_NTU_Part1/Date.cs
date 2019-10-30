
namespace OOP_Exercise_NTU_NTU
{
    class Date
    {
        private int day, month, year;

        public Date(int day, int month, int year)
        {
            this.SetDay(day);
            this.SetMonth(month);
            this.SetYear(year);
        }

        public void SetDay(int day)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
            }
        }

        public void SetMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                this.month = month;
            }
        }

        public void SetYear(int year)
        {
            if (year >= 1900 && year <= 9999)
            {
                this.year = year;
            }
        }

        public int GetDay()
        {
            return this.day;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public void SetDate(int day, int month, int year)
        {
            this.SetDay(day);
            this.SetMonth(month);
            this.SetYear(year);
        }

        public override string ToString()
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            strBuilder.Append(this.day.ToString().PadLeft(2, '0') + "/");
            strBuilder.Append(this.month.ToString().PadLeft(2, '0') + "/");
            strBuilder.Append(this.year.ToString().PadLeft(4, '0'));
            return strBuilder.ToString();
        }
    }
}