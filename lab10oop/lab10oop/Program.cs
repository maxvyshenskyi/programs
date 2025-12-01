using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10oop
{
    internal static class Program
    {
        public static Form1 MainForm;
        public static AboutForm AboutForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new Form1();
            AboutForm = new AboutForm();

            Application.Run(MainForm);
        }
    }
}
