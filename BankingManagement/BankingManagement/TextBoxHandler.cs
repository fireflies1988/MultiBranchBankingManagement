using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankingManagement
{
    class TextBoxHandler
    {
        public static void AcceptsOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = Regex.IsMatch(Clipboard.GetText(), "[^0-9]");
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
            }
        }
        
        public static void PreventASpecificCharInput(object sender, KeyPressEventArgs e, char c)
        {
            e.Handled = (char.IsControl(e.KeyChar) && e.KeyChar != '\b' && Clipboard.GetText().Contains(c.ToString())) || e.KeyChar == c;
        }
    }
}
