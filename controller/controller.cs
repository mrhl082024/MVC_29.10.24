public class Controller
{
    //inherit the Model and View classes, and create the objects _model & _view
    Model? _model;
    view? _view;

    //created the constructor with Model & View as parameters
    public Controller(Model model, view view)
    {
        _model = model;
        _view = view;
    }

    public void UpdateName()
    {
        Console.WriteLine("Write a new name");
        string? newName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("Name cannot be empty");
        }
        else
        {
            _model.Name = newName;
        }
        //_model.Name = newName;
    }
    public void UpdateAge()
    {
        Console.WriteLine("Write a new age");
        string? userInput = Console.ReadLine();
        int.TryParse(in userInput out newAge)
        {
            Console.WriteLine();
        }
    }

}