
namespace OOP_Exercise_NTU_Part2
{
    class Author
    {
        private string name, email;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            if (gender == 'm' || gender == 'f')
            {
                this.gender = gender;
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public char GetGender()
        {
            return this.gender;
        }

        public override string ToString()
        {
            return string.Format("Author[name={0},email={1},gender={2}]",
                this.name, this.email, this.gender);
        }
    }
}
