namespace CashOnlySupermarketApp.Forms
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvProducts = new DataGridView();
            txtProductName = new TextBox();
            txtBarcode = new TextBox();
            cmbCategory = new ComboBox();
            cmbUnit = new ComboBox();
            numSalePrice = new NumericUpDown();
            lblProductName = new Label();
            lblBarcode = new Label();
            lblCategory = new Label();
            lblUnit = new Label();
            lblSalePrice = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            btnShowDisabled = new Button();
            panelMainCard = new Panel();
            panelActions = new Panel();
            lblActionsTitle = new Label();
            panelData = new Panel();
            lblDataTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalePrice).BeginInit();
            panelMainCard.SuspendLayout();
            panelActions.SuspendLayout();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(70, 70, 70);
            dgvProducts.Location = new Point(15, 45);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RightToLeft = RightToLeft.Yes;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 30;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1091, 480);
            dgvProducts.TabIndex = 0;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(70, 70, 70);
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 11F);
            txtProductName.ForeColor = Color.White;
            txtProductName.Location = new Point(15, 99);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "اسم المنتج...";
            txtProductName.RightToLeft = RightToLeft.Yes;
            txtProductName.Size = new Size(200, 32);
            txtProductName.TabIndex = 1;
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = Color.FromArgb(70, 70, 70);
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Font = new Font("Segoe UI", 11F);
            txtBarcode.ForeColor = Color.White;
            txtBarcode.Location = new Point(225, 99);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "الباركود...";
            txtBarcode.RightToLeft = RightToLeft.Yes;
            txtBarcode.Size = new Size(200, 32);
            txtBarcode.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(70, 70, 70);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11F);
            cmbCategory.ForeColor = Color.White;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(15, 160);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.RightToLeft = RightToLeft.Yes;
            cmbCategory.Size = new Size(200, 33);
            cmbCategory.TabIndex = 3;
            // 
            // cmbUnit
            // 
            cmbUnit.BackColor = Color.FromArgb(70, 70, 70);
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.Font = new Font("Segoe UI", 11F);
            cmbUnit.ForeColor = Color.White;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(225, 160);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.RightToLeft = RightToLeft.Yes;
            cmbUnit.Size = new Size(200, 33);
            cmbUnit.TabIndex = 4;
            // 
            // numSalePrice
            // 
            numSalePrice.BackColor = Color.FromArgb(70, 70, 70);
            numSalePrice.BorderStyle = BorderStyle.FixedSingle;
            numSalePrice.DecimalPlaces = 2;
            numSalePrice.Font = new Font("Segoe UI", 11F);
            numSalePrice.ForeColor = Color.White;
            numSalePrice.Location = new Point(15, 222);
            numSalePrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numSalePrice.Name = "numSalePrice";
            numSalePrice.RightToLeft = RightToLeft.Yes;
            numSalePrice.Size = new Size(200, 32);
            numSalePrice.TabIndex = 5;
            numSalePrice.ThousandsSeparator = true;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F);
            lblProductName.ForeColor = Color.FromArgb(170, 170, 170);
            lblProductName.Location = new Point(130, 73);
            lblProductName.Name = "lblProductName";
            lblProductName.RightToLeft = RightToLeft.Yes;
            lblProductName.Size = new Size(85, 23);
            lblProductName.TabIndex = 6;
            lblProductName.Text = "اسم المنتج";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI", 10F);
            lblBarcode.ForeColor = Color.FromArgb(170, 170, 170);
            lblBarcode.Location = new Point(362, 73);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.RightToLeft = RightToLeft.Yes;
            lblBarcode.Size = new Size(63, 23);
            lblBarcode.TabIndex = 7;
            lblBarcode.Text = "الباركود";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.ForeColor = Color.FromArgb(170, 170, 170);
            lblCategory.Location = new Point(171, 134);
            lblCategory.Name = "lblCategory";
            lblCategory.RightToLeft = RightToLeft.Yes;
            lblCategory.Size = new Size(44, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "الفئة";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 10F);
            lblUnit.ForeColor = Color.FromArgb(170, 170, 170);
            lblUnit.Location = new Point(368, 134);
            lblUnit.Name = "lblUnit";
            lblUnit.RightToLeft = RightToLeft.Yes;
            lblUnit.Size = new Size(57, 23);
            lblUnit.TabIndex = 9;
            lblUnit.Text = "الوحدة";
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Font = new Font("Segoe UI", 10F);
            lblSalePrice.ForeColor = Color.FromArgb(170, 170, 170);
            lblSalePrice.Location = new Point(137, 196);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.RightToLeft = RightToLeft.Yes;
            lblSalePrice.Size = new Size(78, 23);
            lblSalePrice.TabIndex = 10;
            lblSalePrice.Text = "سعر البيع";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 120, 215);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(410, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "إضافة منتج جديد";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(104, 104, 104);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(15, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(410, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "تعديل المنتج المحدد";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(196, 43, 28);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(15, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(410, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "تعطيل المنتج المحدد";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(86, 86, 86);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(15, 457);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 40);
            btnClear.TabIndex = 16;
            btnClear.Text = "مسح الحقول";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(86, 86, 86);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(225, 457);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 40);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "تحديث القائمة";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnShowDisabled
            // 
            btnShowDisabled.BackColor = Color.FromArgb(142, 68, 173);
            btnShowDisabled.Cursor = Cursors.Hand;
            btnShowDisabled.FlatAppearance.BorderSize = 0;
            btnShowDisabled.FlatStyle = FlatStyle.Flat;
            btnShowDisabled.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShowDisabled.ForeColor = Color.White;
            btnShowDisabled.Location = new Point(15, 411);
            btnShowDisabled.Name = "btnShowDisabled";
            btnShowDisabled.Size = new Size(410, 40);
            btnShowDisabled.TabIndex = 14;
            btnShowDisabled.Text = "عرض المنتجات المعطلة";
            btnShowDisabled.UseVisualStyleBackColor = false;
            btnShowDisabled.Click += btnShowDisabled_Click;
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(panelActions);
            panelMainCard.Controls.Add(panelData);
            panelMainCard.Location = new Point(30, 30);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(1622, 550);
            panelMainCard.TabIndex = 17;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelActions.BackColor = Color.FromArgb(37, 37, 38);
            panelActions.Controls.Add(lblActionsTitle);
            panelActions.Controls.Add(btnClear);
            panelActions.Controls.Add(btnRefresh);
            panelActions.Controls.Add(btnShowDisabled);
            panelActions.Controls.Add(btnDelete);
            panelActions.Controls.Add(btnUpdate);
            panelActions.Controls.Add(btnAdd);
            panelActions.Controls.Add(lblSalePrice);
            panelActions.Controls.Add(numSalePrice);
            panelActions.Controls.Add(lblUnit);
            panelActions.Controls.Add(cmbUnit);
            panelActions.Controls.Add(lblCategory);
            panelActions.Controls.Add(cmbCategory);
            panelActions.Controls.Add(lblBarcode);
            panelActions.Controls.Add(txtBarcode);
            panelActions.Controls.Add(lblProductName);
            panelActions.Controls.Add(txtProductName);
            panelActions.Location = new Point(1152, 15);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(450, 520);
            panelActions.TabIndex = 1;
            // 
            // lblActionsTitle
            // 
            lblActionsTitle.AutoSize = true;
            lblActionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblActionsTitle.ForeColor = Color.White;
            lblActionsTitle.Location = new Point(347, 0);
            lblActionsTitle.Name = "lblActionsTitle";
            lblActionsTitle.RightToLeft = RightToLeft.Yes;
            lblActionsTitle.Size = new Size(100, 32);
            lblActionsTitle.TabIndex = 18;
            lblActionsTitle.Text = "الإجراءات";
            // 
            // panelData
            // 
            panelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelData.BackColor = Color.FromArgb(45, 45, 48);
            panelData.Controls.Add(lblDataTitle);
            panelData.Controls.Add(dgvProducts);
            panelData.Location = new Point(15, 15);
            panelData.Name = "panelData";
            panelData.Size = new Size(1122, 520);
            panelData.TabIndex = 0;
            // 
            // lblDataTitle
            // 
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(484, 10);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.RightToLeft = RightToLeft.Yes;
            lblDataTitle.Size = new Size(100, 32);
            lblDataTitle.TabIndex = 1;
            lblDataTitle.Text = "المنتجات";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1682, 610);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 500);
            Name = "ProductsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة المنتجات";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalePrice).EndInit();
            panelMainCard.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.NumericUpDown numSalePrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowDisabled;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Label lblDataTitle;
    }
}