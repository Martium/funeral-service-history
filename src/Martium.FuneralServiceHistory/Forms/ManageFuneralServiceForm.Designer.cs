
using System;
using System.ComponentModel;

namespace Martium.FuneralServiceHistory.Forms
{
    partial class ManageFuneralServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFuneralServiceForm));
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.CustomerInformationLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CustomerNamesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerNamesLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneNumbersLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneNumbersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerEmailsLabel = new System.Windows.Forms.Label();
            this.CustomerEmailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerAddressesLabel = new System.Windows.Forms.Label();
            this.CustomerAddressesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FuneralSericePrintPanel = new System.Windows.Forms.Panel();
            this.CustomerPhoneNumbersErrorMessageLabel = new System.Windows.Forms.Label();
            this.OrderDateErrorMessageLabel = new System.Windows.Forms.Label();
            this.ServiceDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AdditionalInfoLabel = new System.Windows.Forms.Label();
            this.ServicePaymentTypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServicePaymentTypeLabel = new System.Windows.Forms.Label();
            this.ServiceMusicianUnitPricesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceMusicianUnitPricesLabel = new System.Windows.Forms.Label();
            this.ServiceDiscountPercentageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceDiscountPercentageLabel = new System.Windows.Forms.Label();
            this.ServicePaymentAmountRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServicePaymentAmountLabel = new System.Windows.Forms.Label();
            this.PaymentsLabel = new System.Windows.Forms.Label();
            this.DepartedRemainsTypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DepartedRemainsTypeLabel = new System.Windows.Forms.Label();
            this.DepartedConfessionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DepartedConfessionLabel = new System.Windows.Forms.Label();
            this.DepartedInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DepartedInfoLabel = new System.Windows.Forms.Label();
            this.DepartedInformationsLabel = new System.Windows.Forms.Label();
            this.ServiceMusicProgramRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceMusicProgramLabel = new System.Windows.Forms.Label();
            this.ServiceMusiciansCountRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceMusiciansCountLabel = new System.Windows.Forms.Label();
            this.ServiceDurationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceDurationLabel = new System.Windows.Forms.Label();
            this.ServiceTypesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceTypesLabel = new System.Windows.Forms.Label();
            this.ServicePlacesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServicePlacesLabel = new System.Windows.Forms.Label();
            this.ServiceDatesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiceDatesLabel = new System.Windows.Forms.Label();
            this.ServiceInformationLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.SaveFuneralServiceChangesButton = new System.Windows.Forms.Button();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintManageFuneralServiceForm = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewManageFuneralServiceForm = new System.Windows.Forms.PrintPreviewDialog();
            this.FuneralSericePrintPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberLabel.Location = new System.Drawing.Point(5, 4);
            this.OrderNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(204, 31);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "Paslaugų užsakymo Nr.";
            this.OrderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDateLabel.Location = new System.Drawing.Point(265, 4);
            this.OrderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(128, 31);
            this.OrderDateLabel.TabIndex = 2;
            this.OrderDateLabel.Text = "Data";
            this.OrderDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OrderDateTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDateTextBox.Location = new System.Drawing.Point(393, 4);
            this.OrderDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDateTextBox.Multiline = true;
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.Size = new System.Drawing.Size(328, 31);
            this.OrderDateTextBox.TabIndex = 3;
            this.OrderDateTextBox.TextChanged += new System.EventHandler(this.OrderDateTextBox_TextChanged);
            this.OrderDateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OrderDateTextBox_Validating);
            // 
            // CustomerInformationLabel
            // 
            this.CustomerInformationLabel.AutoSize = true;
            this.CustomerInformationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInformationLabel.Location = new System.Drawing.Point(5, 55);
            this.CustomerInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerInformationLabel.Name = "CustomerInformationLabel";
            this.CustomerInformationLabel.Size = new System.Drawing.Size(339, 22);
            this.CustomerInformationLabel.TabIndex = 4;
            this.CustomerInformationLabel.Text = "1.    INFORMACIJA APIE UŽSAKOVĄ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CustomerNamesRichTextBox
            // 
            this.CustomerNamesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNamesRichTextBox.Location = new System.Drawing.Point(207, 93);
            this.CustomerNamesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNamesRichTextBox.Name = "CustomerNamesRichTextBox";
            this.CustomerNamesRichTextBox.Size = new System.Drawing.Size(511, 45);
            this.CustomerNamesRichTextBox.TabIndex = 6;
            this.CustomerNamesRichTextBox.Text = "";
            // 
            // CustomerNamesLabel
            // 
            this.CustomerNamesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerNamesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNamesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNamesLabel.Location = new System.Drawing.Point(5, 93);
            this.CustomerNamesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNamesLabel.Name = "CustomerNamesLabel";
            this.CustomerNamesLabel.Size = new System.Drawing.Size(204, 45);
            this.CustomerNamesLabel.TabIndex = 7;
            this.CustomerNamesLabel.Text = "Vardas, pavardė / Įmonė";
            // 
            // CustomerPhoneNumbersLabel
            // 
            this.CustomerPhoneNumbersLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerPhoneNumbersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerPhoneNumbersLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumbersLabel.Location = new System.Drawing.Point(5, 154);
            this.CustomerPhoneNumbersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerPhoneNumbersLabel.Name = "CustomerPhoneNumbersLabel";
            this.CustomerPhoneNumbersLabel.Size = new System.Drawing.Size(133, 45);
            this.CustomerPhoneNumbersLabel.TabIndex = 8;
            this.CustomerPhoneNumbersLabel.Text = "Telefono Nr.";
            // 
            // CustomerPhoneNumbersRichTextBox
            // 
            this.CustomerPhoneNumbersRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerPhoneNumbersRichTextBox.Location = new System.Drawing.Point(137, 154);
            this.CustomerPhoneNumbersRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerPhoneNumbersRichTextBox.Name = "CustomerPhoneNumbersRichTextBox";
            this.CustomerPhoneNumbersRichTextBox.Size = new System.Drawing.Size(143, 45);
            this.CustomerPhoneNumbersRichTextBox.TabIndex = 9;
            this.CustomerPhoneNumbersRichTextBox.Text = "";
            this.CustomerPhoneNumbersRichTextBox.TextChanged += new System.EventHandler(this.CustomerPhoneNumbersRichTextBox_TextChanged);
            this.CustomerPhoneNumbersRichTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerPhoneNumbersRichTextBox_Validating);
            // 
            // CustomerEmailsLabel
            // 
            this.CustomerEmailsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerEmailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerEmailsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmailsLabel.Location = new System.Drawing.Point(278, 154);
            this.CustomerEmailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerEmailsLabel.Name = "CustomerEmailsLabel";
            this.CustomerEmailsLabel.Size = new System.Drawing.Size(133, 45);
            this.CustomerEmailsLabel.TabIndex = 10;
            this.CustomerEmailsLabel.Text = "El. paštas";
            // 
            // CustomerEmailsRichTextBox
            // 
            this.CustomerEmailsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerEmailsRichTextBox.Location = new System.Drawing.Point(410, 154);
            this.CustomerEmailsRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerEmailsRichTextBox.Name = "CustomerEmailsRichTextBox";
            this.CustomerEmailsRichTextBox.Size = new System.Drawing.Size(307, 45);
            this.CustomerEmailsRichTextBox.TabIndex = 11;
            this.CustomerEmailsRichTextBox.Text = "";
            // 
            // CustomerAddressesLabel
            // 
            this.CustomerAddressesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerAddressesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerAddressesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressesLabel.Location = new System.Drawing.Point(716, 154);
            this.CustomerAddressesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerAddressesLabel.Name = "CustomerAddressesLabel";
            this.CustomerAddressesLabel.Size = new System.Drawing.Size(85, 45);
            this.CustomerAddressesLabel.TabIndex = 12;
            this.CustomerAddressesLabel.Text = "Adresas";
            // 
            // CustomerAddressesRichTextBox
            // 
            this.CustomerAddressesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerAddressesRichTextBox.Location = new System.Drawing.Point(800, 154);
            this.CustomerAddressesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerAddressesRichTextBox.Name = "CustomerAddressesRichTextBox";
            this.CustomerAddressesRichTextBox.Size = new System.Drawing.Size(239, 45);
            this.CustomerAddressesRichTextBox.TabIndex = 13;
            this.CustomerAddressesRichTextBox.Text = "";
            // 
            // FuneralSericePrintPanel
            // 
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerPhoneNumbersErrorMessageLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.OrderDateErrorMessageLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDescriptionRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.AdditionalInfoLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServicePaymentTypeRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServicePaymentTypeLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceMusicianUnitPricesRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceMusicianUnitPricesLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDiscountPercentageRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDiscountPercentageLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServicePaymentAmountRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServicePaymentAmountLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.PaymentsLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedRemainsTypeRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedRemainsTypeLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedConfessionRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedConfessionLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedInfoRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedInfoLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.DepartedInformationsLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceMusicProgramRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceMusicProgramLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceMusiciansCountRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceMusiciansCountLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDurationRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDurationLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceTypesRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceTypesLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServicePlacesRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServicePlacesLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDatesRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceDatesLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.ServiceInformationLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.OrderDateTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerAddressesRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.OrderNumberLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerAddressesLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.OrderDateLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerEmailsRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.OrderNumberTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerEmailsLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerInformationLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerPhoneNumbersRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerNamesRichTextBox);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerPhoneNumbersLabel);
            this.FuneralSericePrintPanel.Controls.Add(this.CustomerNamesLabel);
            this.FuneralSericePrintPanel.Location = new System.Drawing.Point(12, 12);
            this.FuneralSericePrintPanel.Name = "FuneralSericePrintPanel";
            this.FuneralSericePrintPanel.Size = new System.Drawing.Size(1044, 926);
            this.FuneralSericePrintPanel.TabIndex = 14;
            // 
            // CustomerPhoneNumbersErrorMessageLabel
            // 
            this.CustomerPhoneNumbersErrorMessageLabel.AutoSize = true;
            this.CustomerPhoneNumbersErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.CustomerPhoneNumbersErrorMessageLabel.Location = new System.Drawing.Point(134, 199);
            this.CustomerPhoneNumbersErrorMessageLabel.Name = "CustomerPhoneNumbersErrorMessageLabel";
            this.CustomerPhoneNumbersErrorMessageLabel.Size = new System.Drawing.Size(67, 19);
            this.CustomerPhoneNumbersErrorMessageLabel.TabIndex = 48;
            this.CustomerPhoneNumbersErrorMessageLabel.Text = "Error text";
            // 
            // OrderDateErrorMessageLabel
            // 
            this.OrderDateErrorMessageLabel.AutoSize = true;
            this.OrderDateErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.OrderDateErrorMessageLabel.Location = new System.Drawing.Point(389, 35);
            this.OrderDateErrorMessageLabel.Name = "OrderDateErrorMessageLabel";
            this.OrderDateErrorMessageLabel.Size = new System.Drawing.Size(67, 19);
            this.OrderDateErrorMessageLabel.TabIndex = 47;
            this.OrderDateErrorMessageLabel.Text = "Error text";
            // 
            // ServiceDescriptionRichTextBox
            // 
            this.ServiceDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDescriptionRichTextBox.Location = new System.Drawing.Point(4, 800);
            this.ServiceDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceDescriptionRichTextBox.Name = "ServiceDescriptionRichTextBox";
            this.ServiceDescriptionRichTextBox.Size = new System.Drawing.Size(1035, 120);
            this.ServiceDescriptionRichTextBox.TabIndex = 45;
            this.ServiceDescriptionRichTextBox.Text = "";
            // 
            // AdditionalInfoLabel
            // 
            this.AdditionalInfoLabel.AutoSize = true;
            this.AdditionalInfoLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalInfoLabel.Location = new System.Drawing.Point(4, 767);
            this.AdditionalInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            this.AdditionalInfoLabel.Size = new System.Drawing.Size(301, 22);
            this.AdditionalInfoLabel.TabIndex = 43;
            this.AdditionalInfoLabel.Text = "5.    PAPILDOMA INFORMACIJA";
            // 
            // ServicePaymentTypeRichTextBox
            // 
            this.ServicePaymentTypeRichTextBox.AutoWordSelection = true;
            this.ServicePaymentTypeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServicePaymentTypeRichTextBox.Location = new System.Drawing.Point(596, 647);
            this.ServicePaymentTypeRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServicePaymentTypeRichTextBox.Name = "ServicePaymentTypeRichTextBox";
            this.ServicePaymentTypeRichTextBox.Size = new System.Drawing.Size(443, 47);
            this.ServicePaymentTypeRichTextBox.TabIndex = 42;
            this.ServicePaymentTypeRichTextBox.Text = "";
            // 
            // ServicePaymentTypeLabel
            // 
            this.ServicePaymentTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServicePaymentTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServicePaymentTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePaymentTypeLabel.Location = new System.Drawing.Point(435, 648);
            this.ServicePaymentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServicePaymentTypeLabel.Name = "ServicePaymentTypeLabel";
            this.ServicePaymentTypeLabel.Size = new System.Drawing.Size(162, 47);
            this.ServicePaymentTypeLabel.TabIndex = 41;
            this.ServicePaymentTypeLabel.Text = "Atsiskaitymo rūšis\r\n";
            // 
            // ServiceMusicianUnitPricesRichTextBox
            // 
            this.ServiceMusicianUnitPricesRichTextBox.AutoWordSelection = true;
            this.ServiceMusicianUnitPricesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceMusicianUnitPricesRichTextBox.Location = new System.Drawing.Point(137, 705);
            this.ServiceMusicianUnitPricesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceMusicianUnitPricesRichTextBox.Name = "ServiceMusicianUnitPricesRichTextBox";
            this.ServiceMusicianUnitPricesRichTextBox.Size = new System.Drawing.Size(902, 47);
            this.ServiceMusicianUnitPricesRichTextBox.TabIndex = 40;
            this.ServiceMusicianUnitPricesRichTextBox.Text = "";
            // 
            // ServiceMusicianUnitPricesLabel
            // 
            this.ServiceMusicianUnitPricesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceMusicianUnitPricesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceMusicianUnitPricesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceMusicianUnitPricesLabel.Location = new System.Drawing.Point(5, 705);
            this.ServiceMusicianUnitPricesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceMusicianUnitPricesLabel.Name = "ServiceMusicianUnitPricesLabel";
            this.ServiceMusicianUnitPricesLabel.Size = new System.Drawing.Size(133, 47);
            this.ServiceMusicianUnitPricesLabel.TabIndex = 39;
            this.ServiceMusicianUnitPricesLabel.Text = "Pajamų\r\npaskirstymas*";
            // 
            // ServiceDiscountPercentageRichTextBox
            // 
            this.ServiceDiscountPercentageRichTextBox.AutoWordSelection = true;
            this.ServiceDiscountPercentageRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDiscountPercentageRichTextBox.Location = new System.Drawing.Point(359, 648);
            this.ServiceDiscountPercentageRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceDiscountPercentageRichTextBox.Name = "ServiceDiscountPercentageRichTextBox";
            this.ServiceDiscountPercentageRichTextBox.Size = new System.Drawing.Size(77, 47);
            this.ServiceDiscountPercentageRichTextBox.TabIndex = 38;
            this.ServiceDiscountPercentageRichTextBox.Text = "";
            // 
            // ServiceDiscountPercentageLabel
            // 
            this.ServiceDiscountPercentageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceDiscountPercentageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDiscountPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDiscountPercentageLabel.Location = new System.Drawing.Point(265, 648);
            this.ServiceDiscountPercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceDiscountPercentageLabel.Name = "ServiceDiscountPercentageLabel";
            this.ServiceDiscountPercentageLabel.Size = new System.Drawing.Size(95, 47);
            this.ServiceDiscountPercentageLabel.TabIndex = 37;
            this.ServiceDiscountPercentageLabel.Text = "Nuolaida";
            // 
            // ServicePaymentAmountRichTextBox
            // 
            this.ServicePaymentAmountRichTextBox.AutoWordSelection = true;
            this.ServicePaymentAmountRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServicePaymentAmountRichTextBox.Location = new System.Drawing.Point(137, 648);
            this.ServicePaymentAmountRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServicePaymentAmountRichTextBox.Name = "ServicePaymentAmountRichTextBox";
            this.ServicePaymentAmountRichTextBox.Size = new System.Drawing.Size(128, 47);
            this.ServicePaymentAmountRichTextBox.TabIndex = 36;
            this.ServicePaymentAmountRichTextBox.Text = "";
            // 
            // ServicePaymentAmountLabel
            // 
            this.ServicePaymentAmountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServicePaymentAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServicePaymentAmountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePaymentAmountLabel.Location = new System.Drawing.Point(5, 648);
            this.ServicePaymentAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServicePaymentAmountLabel.Name = "ServicePaymentAmountLabel";
            this.ServicePaymentAmountLabel.Size = new System.Drawing.Size(133, 47);
            this.ServicePaymentAmountLabel.TabIndex = 35;
            this.ServicePaymentAmountLabel.Text = "Sumokėta suma";
            // 
            // PaymentsLabel
            // 
            this.PaymentsLabel.AutoSize = true;
            this.PaymentsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsLabel.Location = new System.Drawing.Point(4, 612);
            this.PaymentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentsLabel.Name = "PaymentsLabel";
            this.PaymentsLabel.Size = new System.Drawing.Size(188, 22);
            this.PaymentsLabel.TabIndex = 34;
            this.PaymentsLabel.Text = "4.    APMOKĖJIMAS";
            // 
            // DepartedRemainsTypeRichTextBox
            // 
            this.DepartedRemainsTypeRichTextBox.AutoWordSelection = true;
            this.DepartedRemainsTypeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartedRemainsTypeRichTextBox.Location = new System.Drawing.Point(854, 531);
            this.DepartedRemainsTypeRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartedRemainsTypeRichTextBox.Name = "DepartedRemainsTypeRichTextBox";
            this.DepartedRemainsTypeRichTextBox.Size = new System.Drawing.Size(185, 65);
            this.DepartedRemainsTypeRichTextBox.TabIndex = 33;
            this.DepartedRemainsTypeRichTextBox.Text = "";
            // 
            // DepartedRemainsTypeLabel
            // 
            this.DepartedRemainsTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DepartedRemainsTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartedRemainsTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartedRemainsTypeLabel.Location = new System.Drawing.Point(755, 531);
            this.DepartedRemainsTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartedRemainsTypeLabel.Name = "DepartedRemainsTypeLabel";
            this.DepartedRemainsTypeLabel.Size = new System.Drawing.Size(100, 65);
            this.DepartedRemainsTypeLabel.TabIndex = 32;
            this.DepartedRemainsTypeLabel.Text = "Palaikų\r\npavidalas";
            // 
            // DepartedConfessionRichTextBox
            // 
            this.DepartedConfessionRichTextBox.AutoWordSelection = true;
            this.DepartedConfessionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartedConfessionRichTextBox.Location = new System.Drawing.Point(579, 531);
            this.DepartedConfessionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartedConfessionRichTextBox.Name = "DepartedConfessionRichTextBox";
            this.DepartedConfessionRichTextBox.Size = new System.Drawing.Size(178, 65);
            this.DepartedConfessionRichTextBox.TabIndex = 31;
            this.DepartedConfessionRichTextBox.Text = "";
            // 
            // DepartedConfessionLabel
            // 
            this.DepartedConfessionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DepartedConfessionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartedConfessionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartedConfessionLabel.Location = new System.Drawing.Point(456, 531);
            this.DepartedConfessionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartedConfessionLabel.Name = "DepartedConfessionLabel";
            this.DepartedConfessionLabel.Size = new System.Drawing.Size(124, 65);
            this.DepartedConfessionLabel.TabIndex = 30;
            this.DepartedConfessionLabel.Text = "Konfesija";
            // 
            // DepartedInfoRichTextBox
            // 
            this.DepartedInfoRichTextBox.AutoWordSelection = true;
            this.DepartedInfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartedInfoRichTextBox.Location = new System.Drawing.Point(118, 531);
            this.DepartedInfoRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartedInfoRichTextBox.Name = "DepartedInfoRichTextBox";
            this.DepartedInfoRichTextBox.Size = new System.Drawing.Size(339, 65);
            this.DepartedInfoRichTextBox.TabIndex = 29;
            this.DepartedInfoRichTextBox.Text = "";
            // 
            // DepartedInfoLabel
            // 
            this.DepartedInfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DepartedInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartedInfoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartedInfoLabel.Location = new System.Drawing.Point(5, 532);
            this.DepartedInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartedInfoLabel.Name = "DepartedInfoLabel";
            this.DepartedInfoLabel.Size = new System.Drawing.Size(114, 65);
            this.DepartedInfoLabel.TabIndex = 28;
            this.DepartedInfoLabel.Text = "Mirusysis";
            // 
            // DepartedInformationsLabel
            // 
            this.DepartedInformationsLabel.AutoSize = true;
            this.DepartedInformationsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartedInformationsLabel.Location = new System.Drawing.Point(4, 492);
            this.DepartedInformationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartedInformationsLabel.Name = "DepartedInformationsLabel";
            this.DepartedInformationsLabel.Size = new System.Drawing.Size(380, 22);
            this.DepartedInformationsLabel.TabIndex = 27;
            this.DepartedInformationsLabel.Text = "3.    INFORMACIJA APIE  MIRUSĮ  (-SIUS)";
            // 
            // ServiceMusicProgramRichTextBox
            // 
            this.ServiceMusicProgramRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceMusicProgramRichTextBox.Location = new System.Drawing.Point(423, 393);
            this.ServiceMusicProgramRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceMusicProgramRichTextBox.Name = "ServiceMusicProgramRichTextBox";
            this.ServiceMusicProgramRichTextBox.Size = new System.Drawing.Size(616, 82);
            this.ServiceMusicProgramRichTextBox.TabIndex = 26;
            this.ServiceMusicProgramRichTextBox.Text = "";
            // 
            // ServiceMusicProgramLabel
            // 
            this.ServiceMusicProgramLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceMusicProgramLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceMusicProgramLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceMusicProgramLabel.Location = new System.Drawing.Point(342, 393);
            this.ServiceMusicProgramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceMusicProgramLabel.Name = "ServiceMusicProgramLabel";
            this.ServiceMusicProgramLabel.Size = new System.Drawing.Size(82, 82);
            this.ServiceMusicProgramLabel.TabIndex = 25;
            this.ServiceMusicProgramLabel.Text = "Programa";
            // 
            // ServiceMusiciansCountRichTextBox
            // 
            this.ServiceMusiciansCountRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceMusiciansCountRichTextBox.Location = new System.Drawing.Point(275, 393);
            this.ServiceMusiciansCountRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceMusiciansCountRichTextBox.Name = "ServiceMusiciansCountRichTextBox";
            this.ServiceMusiciansCountRichTextBox.Size = new System.Drawing.Size(69, 83);
            this.ServiceMusiciansCountRichTextBox.TabIndex = 24;
            this.ServiceMusiciansCountRichTextBox.Text = "";
            // 
            // ServiceMusiciansCountLabel
            // 
            this.ServiceMusiciansCountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceMusiciansCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceMusiciansCountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceMusiciansCountLabel.Location = new System.Drawing.Point(207, 393);
            this.ServiceMusiciansCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceMusiciansCountLabel.Name = "ServiceMusiciansCountLabel";
            this.ServiceMusiciansCountLabel.Size = new System.Drawing.Size(69, 83);
            this.ServiceMusiciansCountLabel.TabIndex = 23;
            this.ServiceMusiciansCountLabel.Text = "Atlikėjų skaičius";
            // 
            // ServiceDurationRichTextBox
            // 
            this.ServiceDurationRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDurationRichTextBox.Location = new System.Drawing.Point(118, 393);
            this.ServiceDurationRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceDurationRichTextBox.Name = "ServiceDurationRichTextBox";
            this.ServiceDurationRichTextBox.Size = new System.Drawing.Size(90, 84);
            this.ServiceDurationRichTextBox.TabIndex = 22;
            this.ServiceDurationRichTextBox.Text = "";
            // 
            // ServiceDurationLabel
            // 
            this.ServiceDurationLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceDurationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDurationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDurationLabel.Location = new System.Drawing.Point(5, 393);
            this.ServiceDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceDurationLabel.Name = "ServiceDurationLabel";
            this.ServiceDurationLabel.Size = new System.Drawing.Size(114, 83);
            this.ServiceDurationLabel.TabIndex = 21;
            this.ServiceDurationLabel.Text = "Trukmė";
            // 
            // ServiceTypesRichTextBox
            // 
            this.ServiceTypesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceTypesRichTextBox.Location = new System.Drawing.Point(118, 345);
            this.ServiceTypesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceTypesRichTextBox.Name = "ServiceTypesRichTextBox";
            this.ServiceTypesRichTextBox.Size = new System.Drawing.Size(921, 32);
            this.ServiceTypesRichTextBox.TabIndex = 20;
            this.ServiceTypesRichTextBox.Text = " ";
            // 
            // ServiceTypesLabel
            // 
            this.ServiceTypesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceTypesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceTypesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTypesLabel.Location = new System.Drawing.Point(5, 345);
            this.ServiceTypesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceTypesLabel.Name = "ServiceTypesLabel";
            this.ServiceTypesLabel.Size = new System.Drawing.Size(114, 32);
            this.ServiceTypesLabel.TabIndex = 19;
            this.ServiceTypesLabel.Text = "Paskirtis";
            // 
            // ServicePlacesRichTextBox
            // 
            this.ServicePlacesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServicePlacesRichTextBox.Location = new System.Drawing.Point(519, 261);
            this.ServicePlacesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServicePlacesRichTextBox.Name = "ServicePlacesRichTextBox";
            this.ServicePlacesRichTextBox.Size = new System.Drawing.Size(520, 66);
            this.ServicePlacesRichTextBox.TabIndex = 18;
            this.ServicePlacesRichTextBox.Text = "";
            // 
            // ServicePlacesLabel
            // 
            this.ServicePlacesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServicePlacesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServicePlacesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePlacesLabel.Location = new System.Drawing.Point(362, 261);
            this.ServicePlacesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServicePlacesLabel.Name = "ServicePlacesLabel";
            this.ServicePlacesLabel.Size = new System.Drawing.Size(159, 66);
            this.ServicePlacesLabel.TabIndex = 17;
            this.ServicePlacesLabel.Text = "Adresas";
            // 
            // ServiceDatesRichTextBox
            // 
            this.ServiceDatesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDatesRichTextBox.Location = new System.Drawing.Point(161, 261);
            this.ServiceDatesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceDatesRichTextBox.Name = "ServiceDatesRichTextBox";
            this.ServiceDatesRichTextBox.Size = new System.Drawing.Size(204, 66);
            this.ServiceDatesRichTextBox.TabIndex = 16;
            this.ServiceDatesRichTextBox.Text = "";
            // 
            // ServiceDatesLabel
            // 
            this.ServiceDatesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceDatesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDatesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDatesLabel.Location = new System.Drawing.Point(5, 261);
            this.ServiceDatesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceDatesLabel.Name = "ServiceDatesLabel";
            this.ServiceDatesLabel.Size = new System.Drawing.Size(157, 66);
            this.ServiceDatesLabel.TabIndex = 15;
            this.ServiceDatesLabel.Text = "Paslaugos suteikimo data ir laikas";
            // 
            // ServiceInformationLabel
            // 
            this.ServiceInformationLabel.AutoSize = true;
            this.ServiceInformationLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceInformationLabel.Location = new System.Drawing.Point(5, 222);
            this.ServiceInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceInformationLabel.Name = "ServiceInformationLabel";
            this.ServiceInformationLabel.Size = new System.Drawing.Size(472, 22);
            this.ServiceInformationLabel.TabIndex = 14;
            this.ServiceInformationLabel.Text = "2.    INFORMACIJA APIE UŽSAKOMAS PASLAUGAS";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OrderNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberTextBox.Location = new System.Drawing.Point(209, 4);
            this.OrderNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrderNumberTextBox.Multiline = true;
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.ReadOnly = true;
            this.OrderNumberTextBox.Size = new System.Drawing.Size(56, 31);
            this.OrderNumberTextBox.TabIndex = 1;
            // 
            // SaveFuneralServiceChangesButton
            // 
            this.SaveFuneralServiceChangesButton.Enabled = false;
            this.SaveFuneralServiceChangesButton.Location = new System.Drawing.Point(12, 944);
            this.SaveFuneralServiceChangesButton.Name = "SaveFuneralServiceChangesButton";
            this.SaveFuneralServiceChangesButton.Size = new System.Drawing.Size(119, 48);
            this.SaveFuneralServiceChangesButton.TabIndex = 15;
            this.SaveFuneralServiceChangesButton.Text = "Išsaugoti pakeitimus";
            this.SaveFuneralServiceChangesButton.UseVisualStyleBackColor = true;
            this.SaveFuneralServiceChangesButton.Click += new System.EventHandler(this.SaveFuneralServiceChangesButton_Click);
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.Location = new System.Drawing.Point(137, 944);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(95, 48);
            this.PrintPreviewButton.TabIndex = 16;
            this.PrintPreviewButton.Text = "Spausdinimo peržiūra";
            this.PrintPreviewButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(237, 944);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(80, 48);
            this.PrintButton.TabIndex = 17;
            this.PrintButton.Text = "Spausdinti";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // PrintPreviewManageFuneralServiceForm
            // 
            this.PrintPreviewManageFuneralServiceForm.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewManageFuneralServiceForm.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewManageFuneralServiceForm.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewManageFuneralServiceForm.Document = this.PrintManageFuneralServiceForm;
            this.PrintPreviewManageFuneralServiceForm.Enabled = true;
            this.PrintPreviewManageFuneralServiceForm.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewManageFuneralServiceForm.Icon")));
            this.PrintPreviewManageFuneralServiceForm.Name = "PrintPreviewManageFuneralServiceForm";
            this.PrintPreviewManageFuneralServiceForm.Visible = false;
            // 
            // ManageFuneralServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 1001);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PrintPreviewButton);
            this.Controls.Add(this.SaveFuneralServiceChangesButton);
            this.Controls.Add(this.FuneralSericePrintPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageFuneralServiceForm";
            this.Load += new System.EventHandler(this.CreateFuneralServiceForm_Load);
            this.FuneralSericePrintPanel.ResumeLayout(false);
            this.FuneralSericePrintPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label CustomerInformationLabel;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RichTextBox CustomerNamesRichTextBox;
        private System.Windows.Forms.Label CustomerNamesLabel;
        private System.Windows.Forms.Label CustomerPhoneNumbersLabel;
        private System.Windows.Forms.RichTextBox CustomerPhoneNumbersRichTextBox;
        private System.Windows.Forms.Label CustomerEmailsLabel;
        private System.Windows.Forms.RichTextBox CustomerEmailsRichTextBox;
        private System.Windows.Forms.Label CustomerAddressesLabel;
        private System.Windows.Forms.RichTextBox CustomerAddressesRichTextBox;
        private System.Windows.Forms.Panel FuneralSericePrintPanel;
        private System.Windows.Forms.Label ServiceInformationLabel;
        private System.Windows.Forms.Button SaveFuneralServiceChangesButton;
        private System.Windows.Forms.Label ServiceDatesLabel;
        private System.Windows.Forms.RichTextBox ServiceDatesRichTextBox;
        private System.Windows.Forms.Label ServicePlacesLabel;
        private System.Windows.Forms.RichTextBox ServicePlacesRichTextBox;
        private System.Windows.Forms.Label ServiceTypesLabel;
        private System.Windows.Forms.RichTextBox ServiceTypesRichTextBox;
        private System.Windows.Forms.Label ServiceDurationLabel;
        private System.Windows.Forms.RichTextBox ServiceDurationRichTextBox;
        private System.Windows.Forms.Label ServiceMusiciansCountLabel;
        private System.Windows.Forms.RichTextBox ServiceMusiciansCountRichTextBox;
        private System.Windows.Forms.Label ServiceMusicProgramLabel;
        private System.Windows.Forms.RichTextBox ServiceMusicProgramRichTextBox;
        private System.Windows.Forms.Label DepartedInformationsLabel;
        private System.Windows.Forms.Label DepartedInfoLabel;
        private System.Windows.Forms.Label DepartedConfessionLabel;
        private System.Windows.Forms.RichTextBox DepartedInfoRichTextBox;
        private System.Windows.Forms.RichTextBox DepartedConfessionRichTextBox;
        private System.Windows.Forms.Label DepartedRemainsTypeLabel;
        private System.Windows.Forms.RichTextBox DepartedRemainsTypeRichTextBox;
        private System.Windows.Forms.Label PaymentsLabel;
        private System.Windows.Forms.RichTextBox ServicePaymentAmountRichTextBox;
        private System.Windows.Forms.Label ServiceDiscountPercentageLabel;
        private System.Windows.Forms.RichTextBox ServiceDiscountPercentageRichTextBox;
        private System.Windows.Forms.RichTextBox ServiceMusicianUnitPricesRichTextBox;
        private System.Windows.Forms.Label ServiceMusicianUnitPricesLabel;
        private System.Windows.Forms.RichTextBox ServicePaymentTypeRichTextBox;
        private System.Windows.Forms.Label ServicePaymentTypeLabel;
        private System.Windows.Forms.Label AdditionalInfoLabel;
        private System.Windows.Forms.RichTextBox ServiceDescriptionRichTextBox;
        private System.Windows.Forms.Label OrderDateErrorMessageLabel;
        private System.Windows.Forms.Label CustomerPhoneNumbersErrorMessageLabel;
        private System.Windows.Forms.Label ServicePaymentAmountLabel;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Drawing.Printing.PrintDocument PrintManageFuneralServiceForm;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewManageFuneralServiceForm;
    }
}