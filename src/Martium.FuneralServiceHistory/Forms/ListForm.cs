using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Martium.DeprofundisHistory.Enums;
using Martium.DeprofundisHistory.Models;
using Martium.DeprofundisHistory.Repositories;

namespace Martium.DeprofundisHistory.Forms
{
    public partial class ListForm : Form
    {
        private readonly FuneralServiceRepository _funeralServiceRepository;

        private static readonly string SearchTextBoxPlaceholderText = "Įveskite paieškos frazę...";
        private readonly int _OrderNumberColumnIndex = 1;

        private bool _searchActive;

        public ListForm()
        {
            _funeralServiceRepository = new FuneralServiceRepository();

            InitializeComponent();

            SetControlsInitialState();
        }

        private void ServiceListForm_Load(object sender, EventArgs e)
        {
            LoadFuneralServiceList();
        }

        private void FuneralServiceDataGridView_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dataGridView = (DataGridView) sender;

            if (dataGridView.Rows.Count == 0)
            {
                string emptyListReason = _searchActive 
                    ? $"Paieškos frazė '{SearchTextBox.Text}' neatitiko jokių rezultatų. Ieškokite kitos frazės arba atšaukite paiešką." 
                    : "Paslaugų istorija tuščia. Galite pradėti kurti naujas paslaugas pasinaudojęs mygtuku 'Įvesti naują paslaugą' dešiniame viršutiniame kampe.";

                DisplayEmptyListReason(emptyListReason, e, dataGridView);
            }
        }
        
        private void CreateNewFuneralServiceButton_Click(object sender, EventArgs e)
        {
            var createForm = new ManageForm(FuneralServiceOperation.Create);

            createForm.Closed += ShowAndRefreshListForm;

            HideListAndOpenManageForm(createForm);
        }

        private void EditFuneralServiceButton_Click(object sender, EventArgs e)
        {
            int selectedOrderNumber = (int) ServiceHistoryDataGridView.SelectedRows[0].Cells[_OrderNumberColumnIndex].Value;

            var editForm = new ManageForm(FuneralServiceOperation.Edit, selectedOrderNumber);

            editForm.Closed += ShowAndRefreshListForm;

            HideListAndOpenManageForm(editForm);
        }

        private void CopyFuneralServiceButton_Click(object sender, System.EventArgs e)
        {
            int selectedOrderNumber = (int)ServiceHistoryDataGridView.SelectedRows[0].Cells[_OrderNumberColumnIndex].Value;

            var copyForm = new ManageForm(FuneralServiceOperation.Copy, selectedOrderNumber);

            copyForm.Closed += ShowAndRefreshListForm;

            HideListAndOpenManageForm(copyForm);
        }

        private void FuneralServiceSearchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == SearchTextBoxPlaceholderText)
            {
                SearchTextBox.Text = string.Empty;
            }
        }

        private void FuneralServiceSearchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = SearchTextBoxPlaceholderText;
                SearchButton.Enabled = false;
            }
        }

        private void FuneralServiceSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchButton.Enabled = true;
            }
            else
            {
                SearchButton.Enabled = false;
            }
        }

        private void FuneralServiceSearchButton_Click(object sender, EventArgs e)
        {
            _searchActive = true;
            LoadFuneralServiceList(SearchTextBox.Text);
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

            ActiveControl = CreateNewButton;

            SearchTextBox.Text = SearchTextBoxPlaceholderText;
            SearchButton.Enabled = false;
            CancelSearchButton.Enabled = false;
        }

        private void ShowAndRefreshListForm(object sender, EventArgs e)
        {
            _searchActive = false;

            SetControlsInitialState();

            LoadFuneralServiceList();

            this.Show();
        }

        private void HideListAndOpenManageForm(Form manageForm)
        {
            this.Hide();

            manageForm.Show(this);
        }

        private void LoadFuneralServiceList(string searchPhrase = null)
        {
            if (_searchActive)
            {
                CancelSearchButton.Enabled = true;
            }

            IEnumerable<FuneralServiceListModel> funeralServiceListModels = _funeralServiceRepository.GetList(searchPhrase);

            ToggleExistingListManaging(enabled: funeralServiceListModels.Any(), searchPhrase);

            FuneralServiceBindingSource.DataSource = funeralServiceListModels;

            ServiceHistoryDataGridView.DataSource = FuneralServiceBindingSource;
        }

        private static void DisplayEmptyListReason(string reason, PaintEventArgs e, DataGridView dataGridView)
        {
            using (Graphics graphics = e.Graphics)
            {
                int leftPadding = 2;
                int topPadding = 41;
                int rowSelectionColumnWidth = 40;
                int messageBackgroundWidth = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed) + rowSelectionColumnWidth;
                int messageBackgroundHeight = 25;

                graphics.FillRectangle(
                    Brushes.White,
                    new Rectangle(
                        new Point(leftPadding, topPadding),
                        new Size(messageBackgroundWidth, messageBackgroundHeight)
                    )
                );
                graphics.DrawString(
                    reason,
                    new Font("Times New Roman", 12),
                    Brushes.DarkGray,
                    new PointF(leftPadding, topPadding));
            }
        }

        private void ToggleExistingListManaging(bool enabled, string searchPhrase)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase))
            {
                SearchTextBox.Enabled = enabled;
                SearchButton.Enabled = false; // Search button needs to be disabled in case search is not used regardless if items returned or not
            }

            EditButton.Enabled = enabled;
            CopyButton.Enabled = enabled;
        }

        #endregion
    }
}
