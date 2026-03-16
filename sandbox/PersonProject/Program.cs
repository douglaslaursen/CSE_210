class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Person person = new Person("Bob", "Ross", 55, 195);

        Console.WriteLine(person.GetPersonInformation());

        Doctor myDoctor = new Doctor("Ax", "Bob", "Budge", 72, 210);
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}