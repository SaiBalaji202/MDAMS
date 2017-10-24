namespace MDAMS
{
    partial class FrmUpdateMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateMedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.progLoad = new System.Windows.Forms.PictureBox();
            this.txtDrugNo = new MetroFramework.Controls.MetroTextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.btnUpdateDetails = new MetroFramework.Controls.MetroButton();
            this.txtMRP = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitSize = new MetroFramework.Controls.MetroTextBox();
            this.txtGrp = new MetroFramework.Controls.MetroTextBox();
            this.txtMedName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelData = new System.Windows.Forms.Panel();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.wrng = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picBack = new System.Windows.Forms.PictureBox();
            this.btnDeleteDetails = new MetroFramework.Controls.MetroButton();
            this.toggleMultipleDelete = new MetroFramework.Controls.MetroCheckBox();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.toggleMultipleDelete);
            this.metroPanel1.Controls.Add(this.btnDeleteDetails);
            this.metroPanel1.Controls.Add(this.progLoad);
            this.metroPanel1.Controls.Add(this.txtDrugNo);
            this.metroPanel1.Controls.Add(this.picSearch);
            this.metroPanel1.Controls.Add(this.picClear);
            this.metroPanel1.Controls.Add(this.btnUpdateDetails);
            this.metroPanel1.Controls.Add(this.txtMRP);
            this.metroPanel1.Controls.Add(this.txtUnitSize);
            this.metroPanel1.Controls.Add(this.txtGrp);
            this.metroPanel1.Controls.Add(this.txtMedName);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(39, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(605, 362);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.MouseHover += new System.EventHandler(this.metroPanel1_MouseHover);
            // 
            // progLoad
            // 
            this.progLoad.Image = global::MDAMS.Properties.Resources._30;
            this.progLoad.Location = new System.Drawing.Point(178, 3);
            this.progLoad.Name = "progLoad";
            this.progLoad.Size = new System.Drawing.Size(183, 24);
            this.progLoad.TabIndex = 9;
            this.progLoad.TabStop = false;
            this.progLoad.Visible = false;
            // 
            // txtDrugNo
            // 
            this.txtDrugNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDrugNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtDrugNo.CustomButton.Image = null;
            this.txtDrugNo.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtDrugNo.CustomButton.Name = "";
            this.txtDrugNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDrugNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDrugNo.CustomButton.TabIndex = 1;
            this.txtDrugNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDrugNo.CustomButton.UseSelectable = true;
            this.txtDrugNo.CustomButton.Visible = false;
            this.txtDrugNo.Lines = new string[0];
            this.txtDrugNo.Location = new System.Drawing.Point(212, 51);
            this.txtDrugNo.MaxLength = 32767;
            this.txtDrugNo.Name = "txtDrugNo";
            this.txtDrugNo.PasswordChar = '\0';
            this.txtDrugNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugNo.SelectedText = "";
            this.txtDrugNo.SelectionLength = 0;
            this.txtDrugNo.SelectionStart = 0;
            this.txtDrugNo.ShortcutsEnabled = true;
            this.txtDrugNo.Size = new System.Drawing.Size(95, 23);
            this.txtDrugNo.TabIndex = 6;
            this.txtDrugNo.UseSelectable = true;
            this.txtDrugNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrugNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrugNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtDrugNo_Validating);
            // 
            // picSearch
            // 
            this.picSearch.Image = global::MDAMS.Properties.Resources.search1;
            this.picSearch.Location = new System.Drawing.Point(442, 285);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(39, 36);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 5;
            this.picSearch.TabStop = false;
            this.toolTip1.SetToolTip(this.picSearch, "Search");
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            this.picSearch.MouseEnter += new System.EventHandler(this.picSearch_MouseEnter);
            this.picSearch.MouseLeave += new System.EventHandler(this.picSearch_MouseLeave);
            // 
            // picClear
            // 
            this.picClear.Image = global::MDAMS.Properties.Resources.clear3;
            this.picClear.Location = new System.Drawing.Point(55, 285);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(39, 36);
            this.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClear.TabIndex = 5;
            this.picClear.TabStop = false;
            this.toolTip1.SetToolTip(this.picClear, "Clear All");
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            this.picClear.MouseEnter += new System.EventHandler(this.picClear_MouseEnter);
            this.picClear.MouseLeave += new System.EventHandler(this.picClear_MouseLeave);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(124, 285);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(114, 36);
            this.btnUpdateDetails.TabIndex = 4;
            this.btnUpdateDetails.Text = "Update Details";
            this.toolTip1.SetToolTip(this.btnUpdateDetails, "Update Based on Drug No");
            this.btnUpdateDetails.UseSelectable = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // txtMRP
            // 
            this.txtMRP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMRP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtMRP.CustomButton.Image = null;
            this.txtMRP.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtMRP.CustomButton.Name = "";
            this.txtMRP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMRP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMRP.CustomButton.TabIndex = 1;
            this.txtMRP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMRP.CustomButton.UseSelectable = true;
            this.txtMRP.CustomButton.Visible = false;
            this.txtMRP.Lines = new string[0];
            this.txtMRP.Location = new System.Drawing.Point(212, 196);
            this.txtMRP.MaxLength = 32767;
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.PasswordChar = '\0';
            this.txtMRP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMRP.SelectedText = "";
            this.txtMRP.SelectionLength = 0;
            this.txtMRP.SelectionStart = 0;
            this.txtMRP.ShortcutsEnabled = true;
            this.txtMRP.Size = new System.Drawing.Size(95, 23);
            this.txtMRP.TabIndex = 3;
            this.txtMRP.UseSelectable = true;
            this.txtMRP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMRP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUnitSize
            // 
            this.txtUnitSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnitSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtUnitSize.CustomButton.Image = null;
            this.txtUnitSize.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtUnitSize.CustomButton.Name = "";
            this.txtUnitSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitSize.CustomButton.TabIndex = 1;
            this.txtUnitSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitSize.CustomButton.UseSelectable = true;
            this.txtUnitSize.CustomButton.Visible = false;
            this.txtUnitSize.Lines = new string[0];
            this.txtUnitSize.Location = new System.Drawing.Point(212, 151);
            this.txtUnitSize.MaxLength = 32767;
            this.txtUnitSize.Name = "txtUnitSize";
            this.txtUnitSize.PasswordChar = '\0';
            this.txtUnitSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitSize.SelectedText = "";
            this.txtUnitSize.SelectionLength = 0;
            this.txtUnitSize.SelectionStart = 0;
            this.txtUnitSize.ShortcutsEnabled = true;
            this.txtUnitSize.Size = new System.Drawing.Size(95, 23);
            this.txtUnitSize.TabIndex = 3;
            this.txtUnitSize.UseSelectable = true;
            this.txtUnitSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGrp
            // 
            this.txtGrp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGrp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtGrp.CustomButton.Image = null;
            this.txtGrp.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtGrp.CustomButton.Name = "";
            this.txtGrp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrp.CustomButton.TabIndex = 1;
            this.txtGrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrp.CustomButton.UseSelectable = true;
            this.txtGrp.CustomButton.Visible = false;
            this.txtGrp.Lines = new string[0];
            this.txtGrp.Location = new System.Drawing.Point(212, 242);
            this.txtGrp.MaxLength = 32767;
            this.txtGrp.Name = "txtGrp";
            this.txtGrp.PasswordChar = '\0';
            this.txtGrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrp.SelectedText = "";
            this.txtGrp.SelectionLength = 0;
            this.txtGrp.SelectionStart = 0;
            this.txtGrp.ShortcutsEnabled = true;
            this.txtGrp.Size = new System.Drawing.Size(211, 23);
            this.txtGrp.TabIndex = 3;
            this.txtGrp.UseSelectable = true;
            this.txtGrp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMedName
            // 
            this.txtMedName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMedName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtMedName.CustomButton.Image = null;
            this.txtMedName.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtMedName.CustomButton.Name = "";
            this.txtMedName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMedName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMedName.CustomButton.TabIndex = 1;
            this.txtMedName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMedName.CustomButton.UseSelectable = true;
            this.txtMedName.CustomButton.Visible = false;
            this.txtMedName.Lines = new string[0];
            this.txtMedName.Location = new System.Drawing.Point(212, 103);
            this.txtMedName.MaxLength = 32767;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMedName.SelectedText = "";
            this.txtMedName.SelectionLength = 0;
            this.txtMedName.SelectionStart = 0;
            this.txtMedName.ShortcutsEnabled = true;
            this.txtMedName.Size = new System.Drawing.Size(211, 23);
            this.txtMedName.TabIndex = 3;
            this.txtMedName.UseSelectable = true;
            this.txtMedName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMedName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(62, 246);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(125, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Therapeutic Group: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 200);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "MRP: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Unit Size: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name of the Product: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Drug No: ";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.gridData);
            this.panelData.Location = new System.Drawing.Point(39, 446);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(605, 255);
            this.panelData.TabIndex = 8;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.Icon = ((System.Drawing.Icon)(resources.GetObject("erp.Icon")));
            // 
            // wrng
            // 
            this.wrng.ContainerControl = this;
            this.wrng.Icon = ((System.Drawing.Icon)(resources.GetObject("wrng.Icon")));
            // 
            // picBack
            // 
            this.picBack.Image = global::MDAMS.Properties.Resources.back3;
            this.picBack.Location = new System.Drawing.Point(13, 21);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(39, 36);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 6;
            this.picBack.TabStop = false;
            // 
            // btnDeleteDetails
            // 
            this.btnDeleteDetails.Location = new System.Drawing.Point(275, 285);
            this.btnDeleteDetails.Name = "btnDeleteDetails";
            this.btnDeleteDetails.Size = new System.Drawing.Size(114, 36);
            this.btnDeleteDetails.TabIndex = 10;
            this.btnDeleteDetails.Text = "Delete Details";
            this.btnDeleteDetails.UseSelectable = true;
            this.btnDeleteDetails.Click += new System.EventHandler(this.btnDeleteDetails_Click);
            // 
            // toggleMultipleDelete
            // 
            this.toggleMultipleDelete.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleMultipleDelete.AutoSize = true;
            this.toggleMultipleDelete.Location = new System.Drawing.Point(262, 327);
            this.toggleMultipleDelete.Name = "toggleMultipleDelete";
            this.toggleMultipleDelete.Size = new System.Drawing.Size(148, 15);
            this.toggleMultipleDelete.TabIndex = 11;
            this.toggleMultipleDelete.Text = "Delete Multiple Records";
            this.toggleMultipleDelete.UseSelectable = true;
            // 
            // gridData
            // 
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(605, 255);
            this.gridData.TabIndex = 0;
            this.gridData.SelectionChanged += new System.EventHandler(this.gridData_SelectionChanged);
            // 
            // FrmUpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 724);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.picBack);
            this.Name = "FrmUpdateMedicine";
            this.Text = "     Update Medicine Details";
            this.Load += new System.EventHandler(this.FrmUpdateMedicine_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox picClear;
        private MetroFramework.Controls.MetroButton btnUpdateDetails;
        private MetroFramework.Controls.MetroTextBox txtMRP;
        private MetroFramework.Controls.MetroTextBox txtUnitSize;
        private MetroFramework.Controls.MetroTextBox txtGrp;
        private MetroFramework.Controls.MetroTextBox txtMedName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.ErrorProvider wrng;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox progLoad;
        private MetroFramework.Controls.MetroTextBox txtDrugNo;
        private MetroFramework.Controls.MetroButton btnDeleteDetails;
        private MetroFramework.Controls.MetroCheckBox toggleMultipleDelete;
        private MetroFramework.Controls.MetroGrid gridData;
    }
}