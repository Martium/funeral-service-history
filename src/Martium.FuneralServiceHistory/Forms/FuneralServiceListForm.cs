using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Enums;
using Martium.FuneralServiceHistory.Models;
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

        private void CreateNewFuneralServiceButton_Click(object sender, System.EventArgs e)
        {
            var createForm = new ManageFuneralServiceForm(FuneralServiceOperation.Create);

            createForm.Closed += RefreshList;

            createForm.Show(this);
        }

        private void EditFuneralServiceButton_Click(object sender, System.EventArgs e)
        {
            int selectedOrderNumber = (int) FuneralServiceDataGridView.SelectedRows[0].Cells[0].Value;

            var editForm = new ManageFuneralServiceForm(FuneralServiceOperation.Edit, selectedOrderNumber);

            editForm.Closed += RefreshList;

            editForm.Show(this);
        }

        private void CopyFuneralServiceButton_Click(object sender, System.EventArgs e)
        {
            int selectedOrderNumber = (int)FuneralServiceDataGridView.SelectedRows[0].Cells[0].Value;

            var copyForm = new ManageFuneralServiceForm(FuneralServiceOperation.Copy, selectedOrderNumber);

            copyForm.Closed += RefreshList;

            copyForm.Show(this);
        }

        private void FuneralServiceSearchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (FuneralServiceSearchTextBox.Text == SearchTextBoxPlaceholderText)
            {
                FuneralServiceSearchTextBox.Text = string.Empty;
            }
        }

        private void FuneralServiceSearchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FuneralServiceSearchTextBox.Text))
            {
                FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            }
        }

        private void FuneralServiceSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FuneralServiceSearchTextBox.Text))
            {
                FuneralServiceSearchButton.Enabled = true;
            }
            else
            {
                FuneralServiceSearchButton.Enabled = false;
            }
        }


        #region Helpers

        private void SetControlsInitialState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = CreateNewFuneralServiceButton;

            FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            FuneralServiceSearchButton.Enabled = false;
        }

        private void RefreshList(object sender, EventArgs e)
        {
            LoadFuneralServiceList();
        }

        private void LoadFuneralServiceList()
        {
            IEnumerable<FuneralServiceListModel> funeralServiceListModels = _funeralServiceRepository.GetAll();

            if (!funeralServiceListModels.Any())
            {
                DisableExistingListManaging();
            }

            FuneralServiceBindingSource.DataSource = funeralServiceListModels;

            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private void DisableExistingListManaging()
        {
            FuneralServiceSearchTextBox.Enabled = false;

            EditFuneralServiceButton.Enabled = false;
            CopyFuneralServiceButton.Enabled = false;
        }


        #endregion
    }
}
