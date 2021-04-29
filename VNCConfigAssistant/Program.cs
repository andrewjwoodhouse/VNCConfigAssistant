using System;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace VNCConfigAssistant
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            // Store boolean flag
            bool isAdmin;
            string programpath = System.Windows.Forms.Application.ExecutablePath;

            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);

                // If is administrator, the variable updates from False to True
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            // Check with a simple condition whether you are admin or not
            if (isAdmin)
            {
                // OK we have admin rights, so we'll show the main window
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("You don't have administrator rights. Restarting...");
                string[] arguments = System.Environment.GetCommandLineArgs().Skip(1).ToArray(); // requires Linq
                System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo();
                startinfo.FileName = programpath;
                startinfo.UseShellExecute = true;
                startinfo.Verb = "runas";
                startinfo.Arguments = String.Join(" ", arguments);
                System.Diagnostics.Process.Start(startinfo);
                System.Windows.Forms.Application.Exit();
            }

        }
    }
}
