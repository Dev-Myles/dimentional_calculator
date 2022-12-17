using dimentional_calculator.menus;

public class App
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome to the Dimentional Calculator!");
        MenuFunctions.RenderMenu();




    }

    public static void AppHeader(string currentPage)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Dimentional Calculator - {currentPage}");
        Console.ForegroundColor = ConsoleColor.White;

    }
}