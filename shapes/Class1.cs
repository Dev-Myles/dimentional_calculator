namespace Classes
{
    internal class Person
    {


        public Person(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }

        public string LastName { get; private set; }

        public string Name
        {
            get; set;
        }

        public void SayName()
        {
            Console.WriteLine($"The name you typed is: {this.Name}");
        }

        public void SayFullName() { Console.WriteLine($"Your full name is {this.Name} {this.LastName}"); }
    }
}
