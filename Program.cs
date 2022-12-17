using dimentional_calculator.menus;
using dimentional_calculator.pages;
using dimentional_calculator.stack;

public class App
{


    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome to the Dimentional Calculator!");
        Thread.Sleep
            (2000);

        History appHistory = new();
        MenuFunctions menuFunctions = new MenuFunctions();
        Page page = new Page();

        string currentPage = appHistory.GetCurrentPage();

        page.RenderPage(currentPage, appHistory.WriteHistory());

    }
}