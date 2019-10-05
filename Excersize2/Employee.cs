namespace Excersize2
{
    internal class Employee : Person
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string name, System.DateTime birthDate,Gender gender,  int salary, string profession) : base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        internal Room Room { get => room; set => room = value; }

        public override string ToString()
        {
            return "Name: "+ name + " Birth date: "+ birthDate + " Gender: " + gender + " Salary: " + salary + " Profession: "+ profession;
        }
    }
}