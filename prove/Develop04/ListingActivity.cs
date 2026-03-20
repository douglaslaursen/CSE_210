class ListingActivity : Activity
{
    private Random _random;
    private List<string> _promts;
    private List<string> _items;

    public ListingActivity(List<string> prompts, List<string> items)
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        List<string> _promts = prompts;
        List<string> _items = items;
    }

    public void RunListingActivity()
    {
        IntroActivity();

        
    }
}