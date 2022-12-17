

namespace dimentional_calculator.stack
{
    public class History
    {

        public Stack<string> history = new Stack<string>(new string[] { "start_page" });

        public string GetCurrentPage()
        {
            string page = history.Peek();
            return page;
        }

        public void PushToHistoryStack(string selectedPage)
        {
            history.Push(selectedPage);
        }

        public void PopToHistoryStack()
        {
            if (history.Count > 0)
                history.Pop();
            else
                return;
        }

        public string WriteHistory()
        {
            Stack<string> historyStack = new Stack<string>(this.history);
            string historyString = string.Join(", ", historyStack);
            return historyString;
        }
    }
}
