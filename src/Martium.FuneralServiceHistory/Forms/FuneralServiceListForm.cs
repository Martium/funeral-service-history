using System.Windows.Forms;
using Martium.FuneralServiceHistory.Enums;
using Martium.FuneralServiceHistory.Repositories;

namespace Martium.FuneralServiceHistory.Forms
{
    public partial class FuneralServiceListForm : Form
    {
        private readonly FuneralServiceRepository _funeralServiceRepository;

        private static readonly string SearchTextBoxPlaceholderText = "Įveskite paieškos frazę...";
        

        public FuneralServiceListForm()
        {
            _funeralServiceRepository = new FuneralServiceRepository();

            InitializeComponent();

            SetControlsInitialState();
        }

        private void ServiceListForm_Load(object sender, System.EventArgs e)
        {
            LoadFuneralServiceList();
        }

        private void SetControlsInitialState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = CreateNewFuneralServiceButton;

            FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            FuneralServiceSearchButton.Enabled = false;

            EditFuneralServiceButton.Enabled = false;
            CopyFuneralServiceButton.Enabled = false;
            
        }

        private void LoadFuneralServiceList()
        { 
            FuneralServiceBindingSource.DataSource = _funeralServiceRepository.GetAll();

            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private void CreateNewFuneralServiceButton_Click(object sender, System.EventArgs e)
        {
            var createForm = new ManageFuneralServiceForm(FuneralServiceOperation.Create);

            createForm.Show(this);
        }
    }
}
