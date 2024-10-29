namespace MVC_29._10._24;

class Program
{
    static void Main(string[] args)
    {
        //we initialize new instances of out MVC classes
        Model model = new Model("Lars", 42);
        view view = new view();
        Controller controller = new Controller(model, view);

        //we use the controller, to test out program
        controller.DisplayModel();

        //checking how ReadLine & Convert actually works
        string? testReadLine = Console.ReadLine();
        int test = Convert.ToInt32(testReadLine);
        Console.WriteLine(test.GetType());
    }
}
