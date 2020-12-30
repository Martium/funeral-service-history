using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Constants;
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
            SetTextBoxMaxLengths();
        }

        private void CreateFuneralServiceForm_Load(object sender, EventArgs e)
        {
            ResolveFormText();
        }

        private void OrderDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            string sampleDateFormat = "yyyy-MM-dd";

            if (string.IsNullOrWhiteSpace(OrderDateTextBox.Text))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError($"Negali būti tuščias! pvz.: {DateTime.Now.ToString(sampleDateFormat)}", OrderDateTextBox, OrderDateErrorMessageLabel);
            }
            else if (!DateTime.TryParseExact(OrderDateTextBox.Text, sampleDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError($"Įveskite teisingą datą! pvz.: {DateTime.Now.ToString(sampleDateFormat)}", OrderDateTextBox, OrderDateErrorMessageLabel);
            }
            else
            {
                e.Cancel = false;
                HideLabelAndTextBoxError(OrderDateErrorMessageLabel, OrderDateTextBox);
            }
        }

        private void CustomerPhoneNumbersRichTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerPhoneNumbersRichTextBox.Text))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError("Kad išsaugoti duomenis būtina užpildyti šį langelį", CustomerPhoneNumbersRichTextBox, CustomerPhoneNumbersErrorMessageLabel);
            }
            else
            {
                e.Cancel = false;
                HideLabelAndTextBoxError(CustomerPhoneNumbersErrorMessageLabel, CustomerPhoneNumbersRichTextBox);
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

        private void SetTextBoxMaxLengths()
        {
            CustomerNamesRichTextBox.MaxLength = FormSettings.TextBoxLengths.CustomerNames;
            CustomerPhoneNumbersRichTextBox.MaxLength = FormSettings.TextBoxLengths.CustomerPhoneNumbers;
            CustomerEmailsRichTextBox.MaxLength = FormSettings.TextBoxLengths.CustomerEmails;
            CustomerAddressesRichTextBox.MaxLength = FormSettings.TextBoxLengths.CustomerAddresses;

            ServiceDatesRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceDates;
            ServicePlacesRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServicePlaces;
            ServiceTypesRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceTypes;
            ServiceDurationRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceDuration;
            ServiceMusiciansCountRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceMusiciansCount;
            ServiceMusicProgramRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceMusicProgram;

            DepartedInfoRichTextBox.MaxLength = FormSettings.TextBoxLengths.DepartedInfo;
            DepartedConfessionRichTextBox.MaxLength = FormSettings.TextBoxLengths.DepartedConfession;
            DepartedRemainsTypeRichTextBox.MaxLength = FormSettings.TextBoxLengths.DepartedRemainsType;

            ServicePaymentAmountRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServicePaymentAmount;
            ServiceDiscountPercentageRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceDiscountPercentage;
            ServicePaymentTypeRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServicePaymentType;
            ServiceMusicianUnitPricesRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceMusicianUnitPrices;
            ServiceDescriptionRichTextBox.MaxLength = FormSettings.TextBoxLengths.ServiceDescription;
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

        private void DisplayLabelAndTextBoxError(string errorText,TextBoxBase textBoxBase, Label label)
        {
            textBoxBase.BackColor = Color.Red;
            label.Visible = true;
            label.Text = errorText;
        }

        private void HideLabelAndTextBoxError(Label label, TextBoxBase textBoxBase)
        {
            label.Visible = false;
            textBoxBase.BackColor = Color.White;
        }

        #endregion
    }
}