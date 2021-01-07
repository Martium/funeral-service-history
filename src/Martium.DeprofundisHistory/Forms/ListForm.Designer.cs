
using System.Windows.Forms;
using Martium.DeprofundisHistory.Models;

namespace Martium.DeprofundisHistory.Forms
{
    partial class ListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.ServiceHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderCreationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departedInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuneralServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuneralServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(10, 24);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(178, 23);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.FuneralServiceSearchTextBox_TextChanged);
            this.SearchTextBox.GotFocus += new System.EventHandler(this.FuneralServiceSearchTextBox_GotFocus);
            this.SearchTextBox.LostFocus += new System.EventHandler(this.FuneralServiceSearchTextBox_LostFocus);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(192, 17);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(61, 30);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Ieškoti";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.FuneralServiceSearchButton_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(960, 10);
            this.CreateNewButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(92, 50);
            this.CreateNewButton.TabIndex = 2;
            this.CreateNewButton.Text = "Įvesti naują paslaugą";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewFuneralServiceButton_Click);
            // 
            // ServiceHistoryDataGridView
            // 
            this.ServiceHistoryDataGridView.AllowUserToAddRows = false;
            this.ServiceHistoryDataGridView.AllowUserToDeleteRows = false;
            this.ServiceHistoryDataGridView.AutoGenerateColumns = false;
            this.ServiceHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ServiceHistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ServiceHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderCreationYear,
            this.orderNumberDataGridViewTextBoxColumn,
            this.serviceDatesDataGridViewTextBoxColumn,
            this.customerNamesDataGridViewTextBoxColumn,
            this.customerPhoneNumbersDataGridViewTextBoxColumn,
            this.departedInfoDataGridViewTextBoxColumn});
            this.ServiceHistoryDataGridView.DataSource = this.FuneralServiceBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ServiceHistoryDataGridView.Location = new System.Drawing.Point(10, 65);
            this.ServiceHistoryDataGridView.MultiSelect = false;
            this.ServiceHistoryDataGridView.Name = "ServiceHistoryDataGridView";
            this.ServiceHistoryDataGridView.ReadOnly = true;
            this.ServiceHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceHistoryDataGridView.Size = new System.Drawing.Size(1042, 868);
            this.ServiceHistoryDataGridView.TabIndex = 3;
            this.ServiceHistoryDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.FuneralServiceDataGridView_Paint);
            // 
            // OrderCreationYear
            // 
            this.OrderCreationYear.DataPropertyName = "OrderCreationYear";
            this.OrderCreationYear.Frozen = true;
            this.OrderCreationYear.HeaderText = "Metai";
            this.OrderCreationYear.Name = "OrderCreationYear";
            this.OrderCreationYear.ReadOnly = true;
            this.OrderCreationYear.Width = 45;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(16, 939);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(123, 50);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Pakeisti esamą paslaugą";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditFuneralServiceButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(171, 939);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(123, 50);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Kopijuoti paslaugą (sukurti naują)";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyFuneralServiceButton_Click);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Enabled = false;
            this.CancelSearchButton.Location = new System.Drawing.Point(257, 17);
            this.CancelSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(61, 30);
            this.CancelSearchButton.TabIndex = 6;
            this.CancelSearchButton.Text = "Atšaukti";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelFuneralServiceSearchButton_Click);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Frozen = true;
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Užsakymo numeris";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // serviceDatesDataGridViewTextBoxColumn
            // 
            this.serviceDatesDataGridViewTextBoxColumn.DataPropertyName = "ServiceDates";
            this.serviceDatesDataGridViewTextBoxColumn.HeaderText = "Paslaugos data (-os)";
            this.serviceDatesDataGridViewTextBoxColumn.Name = "serviceDatesDataGridViewTextBoxColumn";
            this.serviceDatesDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDatesDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerNamesDataGridViewTextBoxColumn
            // 
            this.customerNamesDataGridViewTextBoxColumn.DataPropertyName = "CustomerNames";
            this.customerNamesDataGridViewTextBoxColumn.HeaderText = "Užsakovo vardas (-ai) / Įmonės pavadinimas (-ai)";
            this.customerNamesDataGridViewTextBoxColumn.Name = "customerNamesDataGridViewTextBoxColumn";
            this.customerNamesDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNamesDataGridViewTextBoxColumn.Width = 305;
            // 
            // customerPhoneNumbersDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNumbers";
            this.customerPhoneNumbersDataGridViewTextBoxColumn.HeaderText = "Telefono numeris (-iai)";
            this.customerPhoneNumbersDataGridViewTextBoxColumn.Name = "customerPhoneNumbersDataGridViewTextBoxColumn";
            this.customerPhoneNumbersDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerPhoneNumbersDataGridViewTextBoxColumn.Width = 110;
            // 
            // departedInfoDataGridViewTextBoxColumn
            // 
            this.departedInfoDataGridViewTextBoxColumn.DataPropertyName = "DepartedInfo";
            this.departedInfoDataGridViewTextBoxColumn.HeaderText = "Mirusiojo (-ių)  informacija";
            this.departedInfoDataGridViewTextBoxColumn.Name = "departedInfoDataGridViewTextBoxColumn";
            this.departedInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departedInfoDataGridViewTextBoxColumn.Width = 295;
            // 
            // FuneralServiceBindingSource
            // 
            this.FuneralServiceBindingSource.DataSource = typeof(Martium.DeprofundisHistory.Models.FuneralServiceListModel);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1064, 1001);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ServiceHistoryDataGridView);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deprofundis™ - muzikavimo paslaugų istorija";
            this.Load += new System.EventHandler(this.ServiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuneralServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.BindingSource FuneralServiceBindingSource;
        private System.Windows.Forms.DataGridView ServiceHistoryDataGridView;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CancelSearchButton;
        private DataGridViewTextBoxColumn OrderCreationYear;
        private DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceDatesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNamesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerPhoneNumbersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departedInfoDataGridViewTextBoxColumn;
    }
}

