class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hey bob");

        // int x = 10;

        // string name = (x > 10) ? "Bob" : "Betty"; // if the statement is true it will do the first but if it is false it will do the latter

        // Console.WriteLine(name);

        // if (x > 10) // does the same as line 9
        // {
        //     name = "Bob";
        // }
        // else
        // {
        //     name = "Betty";
        // }

        string? name2 = null; // string? tells me that the name2 can carry a null vaule
        int? length = name2?.Length; // keeps from crashing and                          

        Console.WriteLine(length);
        Console.WriteLine(name2?.Length);

        name2 = "Bubby";
        length = name2?.Length;
        Console.WriteLine(length);

        name2 ??= "Jeannie";
        Console.WriteLine(name2);

        string? name3 = null;
        name3 ??= "Jeannie";
        Console.WriteLine(name3);
    }
}