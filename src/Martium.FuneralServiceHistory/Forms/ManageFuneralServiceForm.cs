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
    public partial class ManageFuneralServiceForm : Form
    {
        private readonly FuneralServiceRepository _funeralServiceRepository;

        private readonly FuneralServiceOperation _funeralServiceOperation;
        private readonly int? _orderNumber;

        private const string OrderDateFormat = "yyyy-MM-dd";

        public ManageFuneralServiceForm(FuneralServiceOperation funeralServiceOperation, int? orderNumber = null)
        {
            _funeralServiceRepository = new FuneralServiceRepository();

            _funeralServiceOperation = funeralServiceOperation;
            _orderNumber = orderNumber;

            InitializeComponent();

            SetControlsInitialState();
            SetTextBoxMaxLengths();
        }

        private void CreateFuneralServiceForm_Load(object sender, EventArgs e)
        {
            ResolveFormOperation();
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
            EnableSaveButtonIfPossible();
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
            EnableSaveButtonIfPossible();
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

            if (_funeralServiceOperation == FuneralServiceOperation.Edit)
            {
                success = _funeralServiceRepository.EditFuneralService(_orderNumber.Value, funeralServiceModel);

                if (success)
                {
                    ShowDataSaveMessage("Pakeitimai išsaugoti sėkmingai.");
                    this.Close();
                }
                else
                {
                    ShowManageFormErrorDialog();
                }
            }
            else
            {
                success = _funeralServiceRepository.CreateNewFuneralService(funeralServiceModel);

                if (success)
                {
                    ShowDataSaveMessage("Naujas įrašas sukurtas sekmingai.");
                    this.Close();
                }
                else
                {
                    ShowManageFormErrorDialog();
                }
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

        private void ResolveFormOperation()
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

        private void EnableSaveButtonIfPossible()
        {
            SaveFuneralServiceChangesButton.Enabled = (!string.IsNullOrWhiteSpace(OrderDateTextBox.Text) && !string.IsNullOrWhiteSpace(CustomerPhoneNumbersRichTextBox.Text));
        }

        private static void ShowDataSaveMessage(string message)
        {
            MessageBox.Show(message, "Info pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowManageFormErrorDialog()
        {
            MessageBox.Show("Nepavyko išsaugoti, bandykite dar kart!", "Klaidos pranešimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}