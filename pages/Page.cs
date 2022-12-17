namespace dimentional_calculator.pages
{
    internal class Page
    {

        public void RenderPage(string header, string contents)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine(contents);
        }
    }
}
