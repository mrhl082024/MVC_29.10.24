public class view
{
    public void Display(Model model)
    {
        Console.WriteLine(model.ToString());
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}