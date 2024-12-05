namespace Student
{
    public class Student
    {
        private string _name;
        private int _age;
        public Student()
        {
            Console.WriteLine("Enter Student Name");
            _name = Console.ReadLine();
            Console.Write("Enter your age: ");
            while (!int.TryParse(Console.ReadLine(), out _age) || _age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a valid positive number: ");
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public void Introduce()
        {
            Console.WriteLine($"Hello , my name is {_name} and I am {_age} years old");
        }
    }
}
