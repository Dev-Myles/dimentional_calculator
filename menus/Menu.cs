

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

    public class MenuFunctions
    {


    }
}
