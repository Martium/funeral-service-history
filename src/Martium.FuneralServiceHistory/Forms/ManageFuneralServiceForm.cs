using System;
using System.Drawing;
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

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateFuneralServiceForm_Load(object sender, EventArgs e)
        {
            ResolveFormText();
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

        private void SetControlsInitialState()
        {
            ActiveControl = OrderNumberLabel;

            SaveFuneralServiceChangesButton.Enabled = false;
        }
    }
}
