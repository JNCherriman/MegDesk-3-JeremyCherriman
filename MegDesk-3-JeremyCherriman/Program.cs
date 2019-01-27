using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegDesk_3_JeremyCherriman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        
    }

    private void openAddQuoteButton_Click(object sender, EventArgs e)
    {

        AddQuote addNewQuoteForm = new AddQuote();
        addNewQuoteForm.Tag = this;
        addNewQuoteForm.Show(this);
        Hide();

    }
}
