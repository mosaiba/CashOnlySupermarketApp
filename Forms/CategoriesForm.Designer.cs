namespace CashOnlySupermarketApp.Forms
{
    partial class CategoriesForm
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
            dgvCategories = new DataGridView();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            panelMainCard = new Panel();
            panelActions = new Panel();
            lblActionsTitle = new Label();
            panelData = new Panel();
            lblDataTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            panelMainCard.SuspendLayout();
            panelActions.SuspendLayout();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvCategories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeight = 40;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.GridColor = Color.FromArgb(70, 70, 70);
            dgvCategories.Location = new Point(15, 45);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RightToLeft = RightToLeft.Yes;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 30;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(450, 380);
            dgvCategories.TabIndex = 0;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.BackColor = Color.FromArgb(70, 70, 70);
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("Segoe UI", 11F);
            txtCategoryName.ForeColor = Color.White;
            txtCategoryName.Location = new Point(15, 80);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "اكتب اسم الفئة هنا...";
            txtCategoryName.RightToLeft = RightToLeft.Yes;
            txtCategoryName.Size = new Size(260, 32);
            txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 10F);
            lblCategoryName.ForeColor = Color.FromArgb(170, 170, 170);
            lblCategoryName.Location = new Point(198, 54);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.RightToLeft = RightToLeft.Yes;
            lblCategoryName.Size = new Size(77, 23);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "اسم الفئة";
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
            btnAdd.Location = new Point(15, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "إضافة فئة جديدة";
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
            btnUpdate.Location = new Point(15, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(260, 45);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "تعديل الفئة المحددة";
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
            btnDelete.Location = new Point(15, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(260, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "حذف الفئة المحددة";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnRefresh.Location = new Point(15, 325);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(260, 45);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "تحديث القائمة";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(86, 86, 86);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(15, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(260, 45);
            btnClear.TabIndex = 7;
            btnClear.Text = "مسح الحقل";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(panelActions);
            panelMainCard.Controls.Add(panelData);
            panelMainCard.Location = new Point(30, 30);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(840, 470);
            panelMainCard.TabIndex = 8;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelActions.BackColor = Color.FromArgb(37, 37, 38);
            panelActions.Controls.Add(lblActionsTitle);
            panelActions.Controls.Add(btnClear);
            panelActions.Controls.Add(btnRefresh);
            panelActions.Controls.Add(btnDelete);
            panelActions.Controls.Add(btnUpdate);
            panelActions.Controls.Add(btnAdd);
            panelActions.Controls.Add(lblCategoryName);
            panelActions.Controls.Add(txtCategoryName);
            panelActions.Location = new Point(545, 15);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(280, 440);
            panelActions.TabIndex = 1;
            // 
            // lblActionsTitle
            // 
            lblActionsTitle.AutoSize = true;
            lblActionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblActionsTitle.ForeColor = Color.White;
            lblActionsTitle.Location = new Point(175, 0);
            lblActionsTitle.Name = "lblActionsTitle";
            lblActionsTitle.RightToLeft = RightToLeft.Yes;
            lblActionsTitle.Size = new Size(100, 32);
            lblActionsTitle.TabIndex = 8;
            lblActionsTitle.Text = "الإجراءات";
            // 
            // panelData
            // 
            panelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelData.BackColor = Color.FromArgb(45, 45, 48);
            panelData.Controls.Add(lblDataTitle);
            panelData.Controls.Add(dgvCategories);
            panelData.Location = new Point(15, 15);
            panelData.Name = "panelData";
            panelData.Size = new Size(480, 440);
            panelData.TabIndex = 0;
            // 
            // lblDataTitle
            // 
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(389, 10);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.RightToLeft = RightToLeft.Yes;
            lblDataTitle.Size = new Size(76, 32);
            lblDataTitle.TabIndex = 1;
            lblDataTitle.Text = "الفئات";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(900, 530);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 500);
            Name = "CategoriesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الفئات";
            Load += CategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            panelMainCard.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Label lblDataTitle;
    }
}