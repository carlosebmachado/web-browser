using System.Windows.Forms;

namespace Browser
{
    public class Data
    {
        public static AutoCompleteStringCollection history;

        static Data()
        {
            history = new AutoCompleteStringCollection();
            history.Add("https://carlosebmachado.github.io");
            history.Add("https://google.com");
        }
    }
}
