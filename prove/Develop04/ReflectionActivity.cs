class ReflectionActivity : Activity
{
    private Random _random;
    private List<string> _promts;
    private List<string> _questions;

    public ReflectionActivity(List<string> prompts, List<string> questions)
    : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ")
    {
        List<string> _promts = prompts;
        List<string> _questions = questions;
    }

    public void RunReflectionActivity()
    {
        IntroActivity();

        
    }
}