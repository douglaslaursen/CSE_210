class Program
{
    public static void ProcessPerson(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());  //This is where Polymorfizam is taking place. 
        // if (person is Police police)
        // {
        //     Console.WriteLine(police.GetPoliceInformation());
        // }
        // else if (person is Doctor doctor)
        // {
        //     Console.WriteLine(doctor.GetDoctorInformation());
        // }
        // else
        // {
        //     Console.WriteLine(person.GetPersonInformation());
        // }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine();
        Person person = new Person("Bob", "Ross", 55, 195);
        Console.WriteLine(person.GetPersonInformation());

        Console.WriteLine();
        Doctor myDoctor = new Doctor("Ax", "Bob", "Budge", 72, 210);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        Console.WriteLine();
        Police myPolice = new Police("Gun", "Lance", "Bob", 43, 198);
        // Console.WriteLine(myPolice.GetPoliceInformation());

        Console.WriteLine();
        myPolice.SetWeight(myPolice.GetWeight() + 5);
        myPolice.SetAge(myPolice.GetAge() + 1);
        // Console.WriteLine(myPolice.GetPoliceInformation());
        Console.WriteLine();


        List<Person> myPeople = new List<Person>();
        myPeople.Add(person);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person tempPerson in myPeople)
        {
            // Console.WriteLine(tempPerson.GetPersonInformation());
            ProcessPerson(tempPerson);
        }
    }
}