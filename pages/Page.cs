using dimentional_calculator.menus;


namespace dimentional_calculator.pages
{
    internal class Page
    {
        public void RenderHeader(string currentPage, string getHistory)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Dimentional Calculator - {currentPage}");
            Console.WriteLine($"{getHistory}");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void RenderPage(string currentPage, string getHistory)
        {
            Menus menus = new Menus();
            Menu menu = menus.MenuList.Find(p => p.Name == currentPage);

            string menuName = menu.Name;
            string menuDirection = menu.Direction;
            string[] menuOptions = menu.Option;

            Console.Clear();
            RenderHeader(currentPage, getHistory);
            Console.WriteLine(menuDirection);
        }
    }
}
