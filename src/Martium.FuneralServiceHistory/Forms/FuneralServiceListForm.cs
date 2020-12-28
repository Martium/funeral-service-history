using System.Collections.Generic;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Enums;
using Martium.FuneralServiceHistory.Models;
using Martium.FuneralServiceHistory.Repositories;

namespace Martium.FuneralServiceHistory.Forms
{
    public partial class FuneralServiceListForm : Form
    {
        private static readonly string SearchTextBoxPlaceholderText = "Įveskite paieškos frazę...";
        private readonly FuneralServiceRepository _funeralHistory = new FuneralServiceRepository();

        public FuneralServiceListForm()
        { 
            InitializeComponent();

            SetControlsInitialState();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ServiceListForm_Load(object sender, System.EventArgs e)
        {
            SetServiceList();
        }

        private void SetControlsInitialState()
        {
            ActiveControl = CreateNewFuneralServiceButton;

            FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            FuneralServiceSearchButton.Enabled = false;

            EditFuneralServiceButton.Enabled = false;
            CopyFuneralServiceButton.Enabled = false;
            
        }

        private void SetServiceList()
        { 
            FuneralServiceBindingSource.DataSource = _funeralHistory.GetAll();
            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private void CreateNewFuneralServiceButton_Click(object sender, System.EventArgs e)
        {
            var createForm = new ManageFuneralServiceForm(FuneralServiceOperation.Create);

            createForm.Show(this);
        }

        private void EditFuneralServiceButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
