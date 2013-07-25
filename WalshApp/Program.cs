using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WalshApp.Queue;

namespace WalshApp {
    static class Program {

        public static List<ITask> Tasks = new List<ITask>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);

            string token = frmLogin._doLogin();
            if (token == null || token.Length == 0)
                return;

            frmMain main;
            using (frmSplash splash = new frmSplash()) {
                splash.Show();
                splash.TopMost = true;
                Application.DoEvents();
                main = new frmMain();
                main.user_token = token;
                main.Show();
                splash.Close();
            }
            Application.Run(main);
        }
    }
}
