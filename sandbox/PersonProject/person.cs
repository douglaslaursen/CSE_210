abstract class Person // now that it is abstact it cant become a opject so we cant just have a normal person. 
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        SetWeight(weight);
        // _age = age;
        // _weight = weight;
    }

    public virtual string GetPersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }

    public abstract double GetSalary();

    public int GetAge()
    {
        return _age;
    }

    public int GetWeight()
    {
        return _weight;
    }

    public void SetWeight(int weight)
    {
        if (weight < 4 || weight > 500)
        {
            Console.WriteLine("Invalid Weight");
        }
        else
        {
            _weight = weight;
        }
    }

    public void SetAge(int age)
    {
        if (age < 4 || age > 500)
        {
            Console.WriteLine("Invalid age");
        }
        else
        {
            _age = age;
        }
    }
}