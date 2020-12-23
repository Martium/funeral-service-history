using System;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Repositories;

namespace Martium.FuneralServiceHistory
{
    static class Program
    {
        private static readonly DatabaseInitializerRepository DatabaseInitializerRepository = new DatabaseInitializerRepository();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeDatabase();

            Application.Run(new ServiceListForm());
        }

        private static void InitializeDatabase()
        {
            try
            {
                DatabaseInitializerRepository.InitializeDatabaseIfNotExist();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Klaidos pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
