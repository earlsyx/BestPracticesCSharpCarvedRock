namespace carvedrock.bl.principles.FCOI
{
    public class Employee
    {
        public int salary;
        public Person person { get; set; }
        public Employee(Person p, int s)
        {
            salary = s;
            person = p;
        }

    }
}
