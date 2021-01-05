using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Martium.FuneralServiceHistory.Constants;
using Martium.FuneralServiceHistory.Enums;
using Martium.FuneralServiceHistory.Models;
using Martium.FuneralServiceHistory.Repositories;

namespace Martium.FuneralServiceHistory.Forms
{
    public partial class ManageForm : Form
    {
        private readonly FuneralServiceRepository _funeralServiceRepository;

        private readonly FuneralServiceOperation _funeralServiceOperation;
        private readonly int? _orderNumber;

        private const string OrderDateFormat = "yyyy-MM-dd";

        private Bitmap _funeralServiceMemoryImage;

        public ManageForm(FuneralServiceOperation funeralServiceOperation, int? orderNumber = null)
        {
            _funeralServiceRepository = new FuneralServiceRepository();

            _funeralServiceOperation = funeralServiceOperation;
            _orderNumber = orderNumber;

            ResolveFormOperationDesign();

            InitializeComponent();

            SetControlsInitialState();
            SetTextBoxMaxLengths();

            FuneralServicePrintDocument.PrintPage += PrintManageFuneralServiceForm_PrintPage;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_funeralServiceMemoryImage != null)
            {
                e.Graphics.DrawImage(_funeralServiceMemoryImage, 0, 0);

                base.OnPaint(e);
            }
        }

        private void CreateFuneralServiceForm_Load(object sender, EventArgs e)
        {
            ResolveOrderNumberText();
            LoadFormDataForEditOrCopy();
        }

        private void OrderDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OrderDateTextBox.Text))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError($"Negali būti tuščias! pvz.: {DateTime.Now.ToString(OrderDateFormat)}", OrderDateTextBox, OrderDateErrorMessageLabel);
            }
            else if (!DateTime.TryParseExact(OrderDateTextBox.Text, OrderDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                e.Cancel = true;
                DisplayLabelAndTextBoxError($"Įveskite teisingą datą! pvz.: {DateTime.Now.ToString(OrderDateFormat)}", OrderDateTextBox, OrderDateErrorMessageLabel);
            }
            else
            {
                e.Cancel = false;
                HideLabelAndTextBoxError(OrderDateErrorMessageLabel, OrderDateTextBox);
            }
        }
        
        private void OrderDateTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtonsIfPossible();
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

        private void CustomerPhoneNumbersRichTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtonsIfPossible();
        }

        private void SaveFuneralServiceChangesButton_Click(object sender, EventArgs e)
        {
            var funeralServiceModel = new FuneralServiceModel
            {
                OrderDate = DateTime.ParseExact(OrderDateTextBox.Text, OrderDateFormat, CultureInfo.InvariantCulture),
                CustomerNames = CustomerNamesRichTextBox.Text,
                CustomerPhoneNumbers = CustomerPhoneNumbersRichTextBox.Text,
                CustomerEmails = CustomerEmailsRichTextBox.Text,
                CustomerAddresses = CustomerAddressesRichTextBox.Text,
                ServiceDates = ServiceDatesRichTextBox.Text,
                ServicePlaces = ServicePlacesRichTextBox.Text,
                ServiceTypes = ServiceTypesRichTextBox.Text,
                ServiceDuration = ServiceDurationRichTextBox.Text,
                ServiceMusiciansCount = ServiceMusiciansCountRichTextBox.Text,
                ServiceMusicProgram = ServiceMusicProgramRichTextBox.Text,
                DepartedInfo = DepartedInfoRichTextBox.Text,
                DepartedConfession = DepartedConfessionRichTextBox.Text,
                DepartedRemainsType = DepartedRemainsTypeRichTextBox.Text,
                ServiceMusicianUnitPrices = ServiceMusicianUnitPricesRichTextBox.Text,
                ServiceDiscountPercentage = ServiceDiscountPercentageRichTextBox.Text,
                ServicePaymentAmount = ServicePaymentAmountRichTextBox.Text,
                ServicePaymentType = ServicePaymentTypeRichTextBox.Text,
                ServiceDescription = ServiceDescriptionRichTextBox.Text
            };

            bool success;
            string successMessage;

            if (_funeralServiceOperation == FuneralServiceOperation.Edit)
            {
                success = _funeralServiceRepository.EditFuneralService(_orderNumber.Value, funeralServiceModel);
                successMessage = "Pakeitimai išsaugoti sėkmingai.";
            }
            else
            {
                success = _funeralServiceRepository.CreateNewFuneralService(funeralServiceModel);
                successMessage = "Naujas įrašas sukurtas sekmingai.";
            }

            if (success)
            {
                ShowDataSaveMessage(successMessage);
                this.Close();
            }
            else
            {
                ShowManageFormErrorDialog();
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            CaptureFuneralServiceFormScreen();
            FuneralServicePrintPreviewDialog.Document = FuneralServicePrintDocument;
            FuneralServicePrintPreviewDialog.ShowDialog();
        }

        private void PrintManageFuneralServiceForm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(
                _funeralServiceMemoryImage, 
                0, 
                this.FuneralSericePrintPanel.Location.Y);
        }

        #region Helpers

        private void SetControlsInitialState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            ActiveControl = OrderNumberLabel;

            OrderNumberTextBox.ReadOnly = true;

            SaveChangesButton.Enabled = false;

            OrderDateErrorMessageLabel.Visible = false;

            CustomerPhoneNumbersErrorMessageLabel.Visible = false;

            (FuneralServicePrintPreviewDialog as Form).WindowState = FormWindowState.Maximized;
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

        private void ResolveFormOperationDesign()
        {
            if (_funeralServiceOperation == FuneralServiceOperation.Create)
            {
                this.Text = "Naujos paslaugos kūrimas";
                this.Icon = Properties.Resources.CreateIcon;
            }
            else if (_funeralServiceOperation == FuneralServiceOperation.Edit)
            {
                this.Text = "Esamos paslaugos keitimas";
                this.Icon = Properties.Resources.EditIcon;
            }
            else if (_funeralServiceOperation == FuneralServiceOperation.Copy)
            {
                this.Text = "Esamos paslaugos kopijavimas (sukurti naują)";
                this.Icon = Properties.Resources.CopyIcon;
            }
            else
            {
                throw new Exception($"Paslaugų valdymo formoje gauta nežinoma opercija: '{_funeralServiceOperation}'");
            }
        }

        private void ResolveOrderNumberText()
        {
            if (_funeralServiceOperation == FuneralServiceOperation.Edit)
            {
                OrderNumberTextBox.Text = _orderNumber.Value.ToString();
            }
            else
            {
                int nextOrderNumber = _funeralServiceRepository.GetMaxOrderNumber() + 1;
                OrderNumberTextBox.Text = nextOrderNumber.ToString();

                OrderDateTextBox.Text = DateTime.Now.ToString(OrderDateFormat);
            }
        }

        private void LoadFormDataForEditOrCopy()
        {
            if (_funeralServiceOperation == FuneralServiceOperation.Edit ||
                _funeralServiceOperation == FuneralServiceOperation.Copy)
            {
                FuneralServiceModel funeralServiceModel = _funeralServiceRepository.GetByOrderNumber(_orderNumber.Value);

                OrderDateTextBox.Text = funeralServiceModel.OrderDate.ToString(OrderDateFormat);
                CustomerNamesRichTextBox.Text = funeralServiceModel.CustomerNames;
                CustomerPhoneNumbersRichTextBox.Text = funeralServiceModel.CustomerPhoneNumbers;
                CustomerEmailsRichTextBox.Text = funeralServiceModel.CustomerEmails;
                CustomerAddressesRichTextBox.Text = funeralServiceModel.CustomerAddresses;
                ServiceDatesRichTextBox.Text = funeralServiceModel.ServiceDates;
                ServicePlacesRichTextBox.Text = funeralServiceModel.ServicePlaces;
                ServiceTypesRichTextBox.Text = funeralServiceModel.ServiceTypes;
                ServiceDurationRichTextBox.Text = funeralServiceModel.ServiceDuration;
                ServiceMusiciansCountRichTextBox.Text = funeralServiceModel.ServiceMusiciansCount;
                ServiceMusicProgramRichTextBox.Text = funeralServiceModel.ServiceMusicProgram;
                DepartedInfoRichTextBox.Text = funeralServiceModel.DepartedInfo;
                DepartedConfessionRichTextBox.Text = funeralServiceModel.DepartedConfession;
                DepartedRemainsTypeRichTextBox.Text = funeralServiceModel.DepartedRemainsType;
                ServiceMusicianUnitPricesRichTextBox.Text = funeralServiceModel.ServiceMusicianUnitPrices;
                ServiceDiscountPercentageRichTextBox.Text = funeralServiceModel.ServiceDiscountPercentage;
                ServicePaymentAmountRichTextBox.Text = funeralServiceModel.ServicePaymentAmount;
                ServicePaymentTypeRichTextBox.Text = funeralServiceModel.ServicePaymentType;
                ServiceDescriptionRichTextBox.Text = funeralServiceModel.ServiceDescription;
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

        private void EnableButtonsIfPossible()
        {
            bool enabled = (!string.IsNullOrWhiteSpace(OrderDateTextBox.Text) && !string.IsNullOrWhiteSpace(CustomerPhoneNumbersRichTextBox.Text));

            SaveChangesButton.Enabled = enabled;
            PrintButton.Enabled = enabled;
        }

        private static void ShowDataSaveMessage(string message)
        {
            MessageBox.Show(message, "Info pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowManageFormErrorDialog()
        {
            MessageBox.Show("Nepavyko išsaugoti, bandykite dar kart!", "Klaidos pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CaptureFuneralServiceFormScreen()
        {
            _funeralServiceMemoryImage = new Bitmap(1000, FuneralSericePrintPanel.Height);

            FuneralSericePrintPanel.DrawToBitmap(
                _funeralServiceMemoryImage, 
                new Rectangle(0, 0, 1000, FuneralSericePrintPanel.Height));
        }

        #endregion
    }
}