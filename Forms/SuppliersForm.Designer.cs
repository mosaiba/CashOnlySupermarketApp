namespace CashOnlySupermarketApp.Forms
{
    partial class SuppliersForm
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
            dgvSuppliers = new DataGridView();
            txtSupplierName = new TextBox();
            txtPhone = new TextBox();
            lblSupplierName = new Label();
            lblPhone = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            panelMainCard.SuspendLayout();
            panelActions.SuspendLayout();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuppliers.ColumnHeadersHeight = 40;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSuppliers.EnableHeadersVisualStyles = false;
            dgvSuppliers.GridColor = Color.FromArgb(70, 70, 70);
            dgvSuppliers.Location = new Point(15, 45);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RightToLeft = RightToLeft.Yes;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 30;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(450, 398);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierName.BackColor = Color.FromArgb(70, 70, 70);
            txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierName.Font = new Font("Segoe UI", 11F);
            txtSupplierName.ForeColor = Color.White;
            txtSupplierName.Location = new Point(14, 71);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "اكتب اسم المورد هنا...";
            txtSupplierName.RightToLeft = RightToLeft.Yes;
            txtSupplierName.Size = new Size(266, 32);
            txtSupplierName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.BackColor = Color.FromArgb(70, 70, 70);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(15, 132);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "اكتب رقم الهاتف هنا...";
            txtPhone.RightToLeft = RightToLeft.Yes;
            txtPhone.Size = new Size(266, 32);
            txtPhone.TabIndex = 2;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 10F);
            lblSupplierName.ForeColor = Color.FromArgb(170, 170, 170);
            lblSupplierName.Location = new Point(188, 45);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.RightToLeft = RightToLeft.Yes;
            lblSupplierName.Size = new Size(87, 23);
            lblSupplierName.TabIndex = 3;
            lblSupplierName.Text = "اسم المورد";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.FromArgb(170, 170, 170);
            lblPhone.Location = new Point(188, 106);
            lblPhone.Name = "lblPhone";
            lblPhone.RightToLeft = RightToLeft.Yes;
            lblPhone.Size = new Size(86, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "رقم الهاتف";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(0, 120, 215);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(266, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "إضافة مورد جديد";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(104, 104, 104);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(15, 216);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(266, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "تعديل المورد المحدد";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(196, 43, 28);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(14, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(266, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "تعطيل المورد المحدد";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(86, 86, 86);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(14, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(266, 40);
            btnClear.TabIndex = 10;
            btnClear.Text = "مسح الحقول";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(86, 86, 86);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(15, 354);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(266, 40);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "تحديث القائمة";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnShowDisabled
            // 
            btnShowDisabled.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowDisabled.BackColor = Color.FromArgb(142, 68, 173);
            btnShowDisabled.Cursor = Cursors.Hand;
            btnShowDisabled.FlatAppearance.BorderSize = 0;
            btnShowDisabled.FlatStyle = FlatStyle.Flat;
            btnShowDisabled.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShowDisabled.ForeColor = Color.White;
            btnShowDisabled.Location = new Point(15, 308);
            btnShowDisabled.Name = "btnShowDisabled";
            btnShowDisabled.Size = new Size(266, 40);
            btnShowDisabled.TabIndex = 8;
            btnShowDisabled.Text = "عرض الموردين المعطلين";
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
            panelMainCard.Size = new Size(840, 488);
            panelMainCard.TabIndex = 11;
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
            panelActions.Controls.Add(lblPhone);
            panelActions.Controls.Add(txtPhone);
            panelActions.Controls.Add(lblSupplierName);
            panelActions.Controls.Add(txtSupplierName);
            panelActions.Location = new Point(531, 15);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(0, 0, 7, 0);
            panelActions.Size = new Size(293, 458);
            panelActions.TabIndex = 1;
            // 
            // lblActionsTitle
            // 
            lblActionsTitle.AutoSize = true;
            lblActionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblActionsTitle.ForeColor = Color.White;
            lblActionsTitle.Location = new Point(180, 0);
            lblActionsTitle.Name = "lblActionsTitle";
            lblActionsTitle.RightToLeft = RightToLeft.Yes;
            lblActionsTitle.Size = new Size(100, 32);
            lblActionsTitle.TabIndex = 11;
            lblActionsTitle.Text = "الإجراءات";
            // 
            // panelData
            // 
            panelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelData.BackColor = Color.FromArgb(45, 45, 48);
            panelData.Controls.Add(lblDataTitle);
            panelData.Controls.Add(dgvSuppliers);
            panelData.Location = new Point(15, 15);
            panelData.Name = "panelData";
            panelData.Size = new Size(480, 458);
            panelData.TabIndex = 0;
            // 
            // lblDataTitle
            // 
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(363, 10);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.RightToLeft = RightToLeft.Yes;
            lblDataTitle.Size = new Size(102, 32);
            lblDataTitle.TabIndex = 1;
            lblDataTitle.Text = "الموردون";
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(900, 530);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 500);
            Name = "SuppliersForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الموردين";
            Load += SuppliersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            panelMainCard.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblPhone;
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