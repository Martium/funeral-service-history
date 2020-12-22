using System;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Repositories;

namespace Martium.FuneralServiceHistory
{
    public partial class ServiceListForm : Form
    {
        private readonly DatabaseInitializerRepository _databaseInitializerRepository;

        public ServiceListForm()
        {
            _databaseInitializerRepository = new DatabaseInitializerRepository();

            InitializeComponent();
        }

        private void ServiceListForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                _databaseInitializerRepository.InitializeDatabaseIfNotExist();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Klaidos pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
