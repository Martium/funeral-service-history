using System;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Enums;
using Martium.FuneralServiceHistory.Models;

namespace Martium.FuneralServiceHistory.Forms
{
    public partial class ManageFuneralServiceForm : Form
    {
        private readonly FuneralServiceOperation _funeralServiceOperation;
        private readonly FuneralServiceListModel _funeralServiceListModel;

        public ManageFuneralServiceForm(FuneralServiceOperation funeralServiceOperation, FuneralServiceListModel funeralServiceListModel = null)
        {
            _funeralServiceOperation = funeralServiceOperation;
            _funeralServiceListModel = funeralServiceListModel;

            InitializeComponent();

            SetControlsInitialState();
        }

        private void CreateFuneralServiceForm_Load(object sender, EventArgs e)
        {
            ResolveFormText();
        }

        private void SetControlsInitialState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = OrderNumberLabel;

            SaveFuneralServiceChangesButton.Enabled = false;
        }

        private void ResolveFormText()
        {
            if (_funeralServiceOperation == FuneralServiceOperation.Create)
            {
                this.Text = "Naujos paslaugos kūrimas";
            }
            else if (_funeralServiceOperation == FuneralServiceOperation.Edit)
            {
                this.Text = "Esamos paslaugos keitimas";
            }
            else if (_funeralServiceOperation  == FuneralServiceOperation.Copy)
            {
                this.Text = "Esamos paslaugos kopijavimas (sukurti naują)";
            }
            else
            {
                throw new Exception($"Paslaugų valdymo formoje gauta nežinoma opercija: '{_funeralServiceOperation}'");
            }
        }
    }
}
