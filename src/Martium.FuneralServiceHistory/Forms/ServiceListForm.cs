using System.Collections.Generic;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Models;

namespace Martium.FuneralServiceHistory.Forms
{
    public partial class ServiceListForm : Form
    {
        private static readonly string SearchTextBoxPlaceholderText = "Įveskite paieškos frazę...";

        public ServiceListForm()
        { 
            InitializeComponent();

            SetControlsInitialState();
        }

        private void ServiceListForm_Load(object sender, System.EventArgs e)
        {
            SetFakeDataToList();
        }

        private void SetControlsInitialState()
        {
            ActiveControl = CreateNewFuneralServiceButton;

            FuneralServiceSearchTextBox.Text = SearchTextBoxPlaceholderText;
            FuneralServiceSearchButton.Enabled = false;

            EditFuneralServiceButton.Enabled = false;
            CopyFuneralServiceButton.Enabled = false;
        }

        private void SetFakeDataToList()
        {
            var funeralServiceModelForDataGridViews = new List<FuneralServiceListModel>
            {
                new FuneralServiceListModel
                {
                    OrderNumber = 200,
                    ServiceDates = "2020-12-22 10:00, 2020-12-22 10:00, 2020-12-22 10:00",
                    CustomerNames = "Erikas Neverdauskas, Sandra Neverdauskienė",
                    CustomerPhoneNumbers = "+37062505181, +37062505181",
                    DepartedInfo = "Katė Smiltė"
                }
            };


            for (int i = 199; i >= 1; i--)
            {
                funeralServiceModelForDataGridViews.Add(new FuneralServiceListModel
                {
                    OrderNumber = i,
                    ServiceDates = "2020-12-22 10:00",
                    CustomerNames = $"Martynas Gedutis-{i}",
                    CustomerPhoneNumbers = "+37062505181",
                    DepartedInfo = $"Balandis Petras-{i}"
                });
            }

            FuneralServiceBindingSource.DataSource = funeralServiceModelForDataGridViews;
            FuneralServiceDataGridView.DataSource = FuneralServiceBindingSource;
        }
    }
}
