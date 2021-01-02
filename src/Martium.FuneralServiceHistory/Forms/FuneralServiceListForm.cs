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
        private IEnumerable<FuneralServiceListModel> funeralServiceListModels;

        private static readonly string SearchTextBoxPlaceholderText = "Įveskite paieškos frazę...";
        private bool searchActive = false;
        

        public FuneralServiceListForm()
        {
            _funeralServiceRepository = new FuneralServiceRepository();

            InitializeComponent();

            SetControlsInitialState();
        }

        private void ServiceListForm_Load(object sender, EventArgs e)
        {
            LoadFuneralServiceList();
        }

        private void CreateNewFuneralServiceButton_Click(object sender, EventArgs e)
        {
            var createForm = new ManageFuneralServiceForm(FuneralServiceOperation.Create);

            createForm.Closed += RefreshList;

            createForm.Show(this);
        }

        private void EditFuneralServiceButton_Click(object sender, EventArgs e)
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
                FuneralServiceSearchButton.Enabled = false;
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

        private void FuneralServiceSearchButton_Click(object sender, EventArgs e)
        {
            searchActive = true;
            LoadFuneralServiceList(FuneralServiceSearchTextBox.Text);
        }

        private void CancelFuneralServiceSearchButton_Click(object sender, EventArgs e)
        {
            searchActive = false;

            LoadFuneralServiceList();

            SetControlsInitialState();


        }

        #region Helpers

        private void SetControlsInitialState()
        {
            funeralServiceListModels = _funeralServiceRepository.GetList();

            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = CreateNewFuneralServiceButton;

            FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            FuneralServiceSearchButton.Enabled = false;
            CancelFuneralServiceSearchButton.Enabled = false;

            if (funeralServiceListModels.Any())
            {
                EditFuneralServiceButton.Enabled = true;
                CopyFuneralServiceButton.Enabled = true;
            }
        }

        private void RefreshList(object sender, EventArgs e)
        {
            searchActive = true;
            LoadFuneralServiceList();

            SetControlsInitialState();
        }

        private void LoadFuneralServiceList(string searchPhrase = null)
        {
            if (searchActive)
            {
                CancelFuneralServiceSearchButton.Enabled = true;
            }

            funeralServiceListModels = _funeralServiceRepository.GetList(searchPhrase);

            if (!funeralServiceListModels.Any())
            {
                DisableExistingListManaging(searchPhrase);
            }

            FuneralServiceBindingSource.DataSource = funeralServiceListModels;

            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private void LoadFuneralServiceListAfterCancelButton()
        {
            string searchPhrase = null;

            if (searchActive)
            {
                CancelFuneralServiceSearchButton.Enabled = true;
            }

            IEnumerable<FuneralServiceListModel> funeralServiceListModels = _funeralServiceRepository.GetList();

            if (!funeralServiceListModels.Any())
            {
               DisableExistingListManaging(searchPhrase);
            }

            FuneralServiceBindingSource.DataSource = funeralServiceListModels;

            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private void DisableExistingListManaging(string searchPhrase)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase))
            {
                FuneralServiceSearchTextBox.Enabled = false;
                FuneralServiceSearchButton.Enabled = false;
            }

            EditFuneralServiceButton.Enabled = false;
            CopyFuneralServiceButton.Enabled = false;
        }
        #endregion
    }
}
