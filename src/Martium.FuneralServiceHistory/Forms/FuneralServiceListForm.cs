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
        private bool _searchActive;
        

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
            _searchActive = true;
            LoadFuneralServiceList(FuneralServiceSearchTextBox.Text);
        }

        private void CancelFuneralServiceSearchButton_Click(object sender, EventArgs e)
        {
            _searchActive = false;

            SetControlsInitialState();

            LoadFuneralServiceList();
        }

        #region Helpers

        private void SetControlsInitialState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = CreateNewFuneralServiceButton;

            FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            FuneralServiceSearchButton.Enabled = false;
            CancelFuneralServiceSearchButton.Enabled = false;
        }

        private void RefreshList(object sender, EventArgs e)
        {
            _searchActive = false;

            SetControlsInitialState();

            LoadFuneralServiceList();
        }

        private void LoadFuneralServiceList(string searchPhrase = null)
        {
            if (_searchActive)
            {
                CancelFuneralServiceSearchButton.Enabled = true;
            }

            IEnumerable<FuneralServiceListModel> funeralServiceListModels = _funeralServiceRepository.GetList(searchPhrase);

            ToggleExistingListManaging(enabled: funeralServiceListModels.Any(), searchPhrase);

            FuneralServiceBindingSource.DataSource = funeralServiceListModels;

            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private void ToggleExistingListManaging(bool enabled, string searchPhrase)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase))
            {
                FuneralServiceSearchTextBox.Enabled = enabled;
                FuneralServiceSearchButton.Enabled = false; // Search button needs to be disabled in case search is not used regardless if items returned or not
            }

            EditFuneralServiceButton.Enabled = enabled;
            CopyFuneralServiceButton.Enabled = enabled;
        }

        #endregion
    }
}
