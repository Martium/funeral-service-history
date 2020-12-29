using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Enums;

namespace Martium.FuneralServiceHistory.Forms
{
    public partial class ManageFuneralServiceForm : Form
    {
        private readonly FuneralServiceOperation _funeralServiceOperation;
        private readonly int? _orderNumber;

        public ManageFuneralServiceForm(FuneralServiceOperation funeralServiceOperation, int? orderNumber = null)
        {
            _funeralServiceOperation = funeralServiceOperation;
            _orderNumber = orderNumber;

            InitializeComponent();

            SetControlsInitialState();
        }

        private void CreateFuneralServiceForm_Load(object sender, EventArgs e)
        {
            ResolveFormText();
        }

        private void OrderDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            // if empty or not XXXX-XX-XX format 
            if (string.IsNullOrWhiteSpace(OrderDateTextBox.Text))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError($"Negali būti tuščias! pvz {DateTime.Now.ToString("yyyy - MM - dd")}", OrderDateTextBox, OrderDateErrorMessageLabel);
            }
            else if (!DateTime.TryParseExact(OrderDateTextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError($"Įveskite teisingą datą pvz {DateTime.Now.ToString("yyyy-MM-dd")}", OrderDateTextBox, OrderDateErrorMessageLabel);
            }
            else
            {
                e.Cancel = false;
                DisplayCorrectLabelAndTextBox(OrderDateErrorMessageLabel, OrderDateTextBox);
            }
        }

        private void CustomerPhoneNumbersRichTextBox_Validating(object sender, CancelEventArgs e)
        {
            // TODO: validate if phone number is not empty or white space
            if (string.IsNullOrWhiteSpace(CustomerPhoneNumbersRichTextBox.Text))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError("Kad išsaugoti duomenis būtina užpildyti šį langelį", CustomerPhoneNumbersRichTextBox, CustomerPhoneNumbersErrorMessageLabel);
            }
            else
            {
                e.Cancel = false;
                DisplayCorrectLabelAndTextBox(CustomerPhoneNumbersErrorMessageLabel, CustomerPhoneNumbersRichTextBox);
            }
        }

        #region Helpers

        private void SetControlsInitialState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = OrderNumberLabel;

            OrderNumberTextBox.ReadOnly = true;

            SaveFuneralServiceChangesButton.Enabled = false;

            OrderDateErrorMessageLabel.Visible = false;

            CustomerPhoneNumbersErrorMessageLabel.Visible = false;
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
            else if (_funeralServiceOperation == FuneralServiceOperation.Copy)
            {
                this.Text = "Esamos paslaugos kopijavimas (sukurti naują)";
            }
            else
            {
                throw new Exception($"Paslaugų valdymo formoje gauta nežinoma opercija: '{_funeralServiceOperation}'");
            }
        }

        private void DisplayLabelAndTextBoxError(string errorText,TextBoxBase textBoxBase, Label label) // use same method for both text boxes: TextBoxBase
        {
            textBoxBase.BackColor = Color.Red;
            label.Visible = true;
            label.Text = errorText;
        }

        private void DisplayCorrectLabelAndTextBox(Label label, TextBoxBase textBoxBase)
        {
            label.Visible = false;
            textBoxBase.BackColor = Color.White;
        }

        #endregion
    }
}