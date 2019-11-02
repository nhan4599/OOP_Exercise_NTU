namespace OOP_Exercise_NTU_Part2
{
    class AccountCustomer
    {
        private int id;
        private string name;
        private char gender;

        public AccountCustomer(int id, string name, char gender)
        {
            this.id = id;
            this.name = name;
            this.gender = (gender == 'm' || gender == 'f') ? gender : '\0';
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public char GetGender()
        {
            return this.gender;
        }

        public override string ToString()
        {
            return string.Format("name({0})", this.id);
        }
    }
}
