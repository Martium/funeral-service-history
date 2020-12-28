
namespace Martium.FuneralServiceHistory.Forms
{
    partial class FuneralServiceListForm
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
            this.FuneralServiceSearchTextBox = new System.Windows.Forms.TextBox();
            this.FuneralServiceSearchButton = new System.Windows.Forms.Button();
            this.CreateNewFuneralServiceButton = new System.Windows.Forms.Button();
            this.FuneralServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departedInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuneralServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditFuneralServiceButton = new System.Windows.Forms.Button();
            this.CopyFuneralServiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FuneralServiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuneralServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FuneralServiceSearchTextBox
            // 
            this.FuneralServiceSearchTextBox.Location = new System.Drawing.Point(9, 20);
            this.FuneralServiceSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FuneralServiceSearchTextBox.Name = "FuneralServiceSearchTextBox";
            this.FuneralServiceSearchTextBox.Size = new System.Drawing.Size(153, 20);
            this.FuneralServiceSearchTextBox.TabIndex = 0;
            // 
            // FuneralServiceSearchButton
            // 
            this.FuneralServiceSearchButton.Enabled = false;
            this.FuneralServiceSearchButton.Location = new System.Drawing.Point(166, 16);
            this.FuneralServiceSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.FuneralServiceSearchButton.Name = "FuneralServiceSearchButton";
            this.FuneralServiceSearchButton.Size = new System.Drawing.Size(50, 26);
            this.FuneralServiceSearchButton.TabIndex = 1;
            this.FuneralServiceSearchButton.Text = "Ieškoti";
            this.FuneralServiceSearchButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewFuneralServiceButton
            // 
            this.CreateNewFuneralServiceButton.Location = new System.Drawing.Point(783, 9);
            this.CreateNewFuneralServiceButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewFuneralServiceButton.Name = "CreateNewFuneralServiceButton";
            this.CreateNewFuneralServiceButton.Size = new System.Drawing.Size(79, 40);
            this.CreateNewFuneralServiceButton.TabIndex = 2;
            this.CreateNewFuneralServiceButton.Text = "Įvesti naują paslaugą";
            this.CreateNewFuneralServiceButton.UseVisualStyleBackColor = true;
            this.CreateNewFuneralServiceButton.Click += new System.EventHandler(this.CreateNewFuneralServiceButton_Click);
            // 
            // FuneralServiceDataGridView
            // 
            this.FuneralServiceDataGridView.AllowUserToAddRows = false;
            this.FuneralServiceDataGridView.AllowUserToDeleteRows = false;
            this.FuneralServiceDataGridView.AutoGenerateColumns = false;
            this.FuneralServiceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FuneralServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuneralServiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.serviceDatesDataGridViewTextBoxColumn,
            this.customerNamesDataGridViewTextBoxColumn,
            this.customerPhoneNumbersDataGridViewTextBoxColumn,
            this.departedInfoDataGridViewTextBoxColumn});
            this.FuneralServiceDataGridView.DataSource = this.FuneralServiceBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FuneralServiceDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.FuneralServiceDataGridView.Location = new System.Drawing.Point(14, 57);
            this.FuneralServiceDataGridView.MultiSelect = false;
            this.FuneralServiceDataGridView.Name = "FuneralServiceDataGridView";
            this.FuneralServiceDataGridView.ReadOnly = true;
            this.FuneralServiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FuneralServiceDataGridView.Size = new System.Drawing.Size(850, 642);
            this.FuneralServiceDataGridView.TabIndex = 3;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Užsakymo numeris";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // serviceDatesDataGridViewTextBoxColumn
            // 
            this.serviceDatesDataGridViewTextBoxColumn.DataPropertyName = "ServiceDates";
            this.serviceDatesDataGridViewTextBoxColumn.HeaderText = "Paslaugos data(-os)";
            this.serviceDatesDataGridViewTextBoxColumn.Name = "serviceDatesDataGridViewTextBoxColumn";
            this.serviceDatesDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDatesDataGridViewTextBoxColumn.Width = 110;
            // 
            // customerNamesDataGridViewTextBoxColumn
            // 
            this.customerNamesDataGridViewTextBoxColumn.DataPropertyName = "CustomerNames";
            this.customerNamesDataGridViewTextBoxColumn.HeaderText = "Užsakovo vardas(-ai) / Įmonės pavadinimas(-ai)";
            this.customerNamesDataGridViewTextBoxColumn.Name = "customerNamesDataGridViewTextBoxColumn";
            this.customerNamesDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNamesDataGridViewTextBoxColumn.Width = 250;
            // 
            // customerPhoneNumbersDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNumbers";
            this.customerPhoneNumbersDataGridViewTextBoxColumn.HeaderText = "Telefono numeris(-iai)";
            this.customerPhoneNumbersDataGridViewTextBoxColumn.Name = "customerPhoneNumbersDataGridViewTextBoxColumn";
            this.customerPhoneNumbersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departedInfoDataGridViewTextBoxColumn
            // 
            this.departedInfoDataGridViewTextBoxColumn.DataPropertyName = "DepartedInfo";
            this.departedInfoDataGridViewTextBoxColumn.HeaderText = "Mirusiojo(-ių) informacija";
            this.departedInfoDataGridViewTextBoxColumn.Name = "departedInfoDataGridViewTextBoxColumn";
            this.departedInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departedInfoDataGridViewTextBoxColumn.Width = 250;
            // 
            // FuneralServiceBindingSource
            // 
            this.FuneralServiceBindingSource.DataSource = typeof(Martium.FuneralServiceHistory.Models.FuneralServiceListModel);
            // 
            // EditFuneralServiceButton
            // 
            this.EditFuneralServiceButton.Enabled = false;
            this.EditFuneralServiceButton.Location = new System.Drawing.Point(14, 705);
            this.EditFuneralServiceButton.Name = "EditFuneralServiceButton";
            this.EditFuneralServiceButton.Size = new System.Drawing.Size(96, 44);
            this.EditFuneralServiceButton.TabIndex = 4;
            this.EditFuneralServiceButton.Text = "Pakeisti esamą paslaugą";
            this.EditFuneralServiceButton.UseVisualStyleBackColor = true;
            this.EditFuneralServiceButton.Click += new System.EventHandler(this.EditFuneralServiceButton_Click);
            // 
            // CopyFuneralServiceButton
            // 
            this.CopyFuneralServiceButton.Enabled = false;
            this.CopyFuneralServiceButton.Location = new System.Drawing.Point(133, 705);
            this.CopyFuneralServiceButton.Name = "CopyFuneralServiceButton";
            this.CopyFuneralServiceButton.Size = new System.Drawing.Size(106, 44);
            this.CopyFuneralServiceButton.TabIndex = 5;
            this.CopyFuneralServiceButton.Text = "Kopijuoti paslaugą (sukurti naują)";
            this.CopyFuneralServiceButton.UseVisualStyleBackColor = true;
            // 
            // FuneralServiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 761);
            this.Controls.Add(this.CopyFuneralServiceButton);
            this.Controls.Add(this.EditFuneralServiceButton);
            this.Controls.Add(this.FuneralServiceDataGridView);
            this.Controls.Add(this.CreateNewFuneralServiceButton);
            this.Controls.Add(this.FuneralServiceSearchButton);
            this.Controls.Add(this.FuneralServiceSearchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FuneralServiceListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laidojimo paslaugų istorija";
            this.Load += new System.EventHandler(this.ServiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuneralServiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuneralServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FuneralServiceSearchTextBox;
        private System.Windows.Forms.Button FuneralServiceSearchButton;
        private System.Windows.Forms.Button CreateNewFuneralServiceButton;
        private System.Windows.Forms.BindingSource FuneralServiceBindingSource;
        private System.Windows.Forms.DataGridView FuneralServiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departedInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button EditFuneralServiceButton;
        private System.Windows.Forms.Button CopyFuneralServiceButton;
    }
}

