using System;
using System.Windows.Forms;

namespace Martium.FuneralServiceHistory
{
    public partial class ServiceListForm : Form
    {
        private readonly FuneralServiceRepository _funeralServiceRepository;

        public ServiceListForm()
        {
            _funeralServiceRepository = new FuneralServiceRepository();

            InitializeComponent();
        }

        private void ServiceListForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                _funeralServiceRepository.InitializeDatabaseIfNotExist();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Klaidos pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
