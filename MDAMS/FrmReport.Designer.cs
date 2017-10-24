namespace MDAMS
{
    partial class FrmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtGST = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtDrugNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMedName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnPrint);
            this.metroPanel2.Controls.Add(this.btnRemove);
            this.metroPanel2.Controls.Add(this.btnAdd);
            this.metroPanel2.Controls.Add(this.txtQuantity);
            this.metroPanel2.Controls.Add(this.txtGST);
            this.metroPanel2.Controls.Add(this.txtTotal);
            this.metroPanel2.Controls.Add(this.txtPrice);
            this.metroPanel2.Controls.Add(this.txtDrugNo);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.txtMedName);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(24, 374);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(685, 120);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(595, 51);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 54);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(501, 51);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 54);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(406, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 54);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(111, 55);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(95, 23);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGST
            // 
            this.txtGST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtGST.CustomButton.Image = null;
            this.txtGST.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtGST.CustomButton.Name = "";
            this.txtGST.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGST.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGST.CustomButton.TabIndex = 1;
            this.txtGST.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGST.CustomButton.UseSelectable = true;
            this.txtGST.CustomButton.Visible = false;
            this.txtGST.Lines = new string[0];
            this.txtGST.Location = new System.Drawing.Point(575, 7);
            this.txtGST.MaxLength = 32767;
            this.txtGST.Name = "txtGST";
            this.txtGST.PasswordChar = '\0';
            this.txtGST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGST.SelectedText = "";
            this.txtGST.SelectionLength = 0;
            this.txtGST.SelectionStart = 0;
            this.txtGST.ShortcutsEnabled = true;
            this.txtGST.Size = new System.Drawing.Size(95, 23);
            this.txtGST.TabIndex = 12;
            this.txtGST.UseSelectable = true;
            this.txtGST.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGST.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(296, 51);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(95, 23);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDrugNo
            // 
            this.txtDrugNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDrugNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtDrugNo.CustomButton.Image = null;
            this.txtDrugNo.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtDrugNo.CustomButton.Name = "";
            this.txtDrugNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDrugNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDrugNo.CustomButton.TabIndex = 1;
            this.txtDrugNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDrugNo.CustomButton.UseSelectable = true;
            this.txtDrugNo.CustomButton.Visible = false;
            this.txtDrugNo.Lines = new string[0];
            this.txtDrugNo.Location = new System.Drawing.Point(86, 7);
            this.txtDrugNo.MaxLength = 32767;
            this.txtDrugNo.Name = "txtDrugNo";
            this.txtDrugNo.PasswordChar = '\0';
            this.txtDrugNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugNo.SelectedText = "";
            this.txtDrugNo.SelectionLength = 0;
            this.txtDrugNo.SelectionStart = 0;
            this.txtDrugNo.ShortcutsEnabled = true;
            this.txtDrugNo.Size = new System.Drawing.Size(120, 23);
            this.txtDrugNo.TabIndex = 16;
            this.txtDrugNo.UseSelectable = true;
            this.txtDrugNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrugNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Quantity";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(530, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "GST: ";
            // 
            // txtMedName
            // 
            this.txtMedName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMedName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtMedName.CustomButton.Image = null;
            this.txtMedName.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtMedName.CustomButton.Name = "";
            this.txtMedName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMedName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMedName.CustomButton.TabIndex = 1;
            this.txtMedName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMedName.CustomButton.UseSelectable = true;
            this.txtMedName.CustomButton.Visible = false;
            this.txtMedName.Lines = new string[0];
            this.txtMedName.Location = new System.Drawing.Point(296, 7);
            this.txtMedName.MaxLength = 32767;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMedName.SelectedText = "";
            this.txtMedName.SelectionLength = 0;
            this.txtMedName.SelectionStart = 0;
            this.txtMedName.ShortcutsEnabled = true;
            this.txtMedName.Size = new System.Drawing.Size(208, 23);
            this.txtMedName.TabIndex = 15;
            this.txtMedName.UseSelectable = true;
            this.txtMedName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMedName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(227, 55);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Price: ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(13, 7);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Drug No: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(228, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Product: ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.gridData);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(685, 278);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // gridData
            // 
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.AutoGenerateColumns = false;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.gstDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.gridData.DataSource = this.receiptBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(3, 3);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(679, 272);
            this.gridData.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // gstDataGridViewTextBoxColumn
            // 
            this.gstDataGridViewTextBoxColumn.DataPropertyName = "Gst";
            this.gstDataGridViewTextBoxColumn.HeaderText = "Gst";
            this.gstDataGridViewTextBoxColumn.Name = "gstDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(MDAMS.Receipt);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(158, 98);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(227, 94);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(95, 23);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 517);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "FrmReport";
            this.Text = "Generate Bill";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtMedName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDrugNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtGST;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}