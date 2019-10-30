namespace OOP_Exercise_NTU_NTU
{
    class Employee
    {
        private int id, salary;
        private string firstName, lastName;

        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetName()
        {
            return this.firstName + " " + this.lastName;
        }

        public int GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public int GetAnnualSalary()
        {
            return this.salary * 12;
        }

        public int RaiseSalary(int percent)
        {
            return this.salary += this.salary * (percent / 100);
        }

        public override string ToString()
        {
            return string.Format("Employee[id={0},name={1},salary={2}",
                this.id, this.GetName(), this.salary);
        }

    }

}