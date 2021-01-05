using System;
using System.Threading;
using System.Windows.Forms;
using Martium.DeprofundisHistory.Forms;
using Martium.DeprofundisHistory.Repositories;

namespace Martium.DeprofundisHistory
{
    static class Program
    {
        private const string AppUuid = "e7b565a1-8d49-40ea-a2d4-ab0bcbbc1234";

        private static readonly DatabaseInitializerRepository DatabaseInitializerRepository = new DatabaseInitializerRepository();

        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + AppUuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show(@"Vienu metu galima paleisti tik vieną 'Deprofundis' aplikaciją!");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                bool success = InitializeDatabase();
                if (success)
                {
                    Application.Run(new ListForm());
                }
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
