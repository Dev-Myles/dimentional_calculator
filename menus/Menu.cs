

namespace dimentional_calculator.menus
{

    public class Menu
    {
        public string Name { get; set; }
        public string Direction { get; set; }
        public string[] Option { get; set; }
        public Menu(string name, string direction, string[] options)
        {
            Name = name;
            Direction = direction;
            Option = options;
        }

    }

    public class Menus
    {
        public List<Menu> MenuList = new List<Menu> {

           new Menu("start_page", "Please select an option", new string[]{ "Calculate",
            "Recent Calculations",
            "Exit"} )
       };
    }

    public class StartMenu
    {
        public string direction = "Please select an option:";
        public string[] options = {
            "Calculate",
            "Recent Calculations",
            "Exit"
            };
    }

    public class MenuFunctions
    {

        public void RenderHeader(string currentPage, string getHistory)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Dimentional Calculator - {currentPage}");
            Console.WriteLine($"{getHistory}");
            Console.ForegroundColor = ConsoleColor.White;

        }




    }
}
