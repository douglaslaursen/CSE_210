class Program
{
    public static void Main(string[] args)
    {
        // Making the program clean looking
        Console.Clear();

        Angle myAngle = new Angle(180);

        Console.WriteLine(myAngle.GetRadians());

        Console.WriteLine(myAngle.GetDegrees());

        myAngle.SetDegrees(270);

        Console.WriteLine(myAngle.GetRadians());

        // myAngle.ToRadians(); // Does not work because that method is private. 
    }
}