using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Goat_s_KO_Table_Editor
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
                Application.Run(new FormMain());
        }
    }
}
