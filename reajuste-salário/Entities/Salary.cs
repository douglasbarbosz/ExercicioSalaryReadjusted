namespace Salary
{
    class SalaryReadjusted
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public SalaryReadjusted() { }
        public SalaryReadjusted(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public double Readjustment()
        {
            if (Salary < 300) 
            {
                return Salary = Salary * 1.5;
            }
            else
            {
                return Salary = Salary * 1.3;
            }
        }
    }
}
