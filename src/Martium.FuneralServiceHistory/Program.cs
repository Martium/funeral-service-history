using System;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Forms;
using Martium.FuneralServiceHistory.Repositories;

namespace Martium.FuneralServiceHistory
{
    static class Program
    {
        private static readonly DatabaseInitializerRepository DatabaseInitializerRepository = new DatabaseInitializerRepository();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool success = InitializeDatabase();

            if (success)
            {
                Application.Run(new FuneralServiceListForm());
            }
        }
        
        private static bool InitializeDatabase()
        {
            bool success = true;

            try
            {
                DatabaseInitializerRepository.InitializeDatabaseIfNotExist();
            }
            catch (Exception exception)
            {
                success = false;

                MessageBox.Show(exception.Message, "Klaidos pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }
    }
}
