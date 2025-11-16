namespace CashOnlySupermarketApp.Forms
{
    partial class EmployeesForm
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
            dgvEmployees = new DataGridView();
            txtFullName = new TextBox();
            txtPosition = new TextBox();
            lblFullName = new Label();
            lblPosition = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreateUser = new Button();
            btnRefresh = new Button();
            btnShowDisabled = new Button();
            panelMainCard = new Panel();
            panelActions = new Panel();
            lblActionsTitle = new Label();
            btnDisableUser = new Button();
            btnEnableUser = new Button();
            panelData = new Panel();
            lblDataTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panelMainCard.SuspendLayout();
            panelActions.SuspendLayout();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvEmployees.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.ColumnHeadersHeight = 40;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.FromArgb(70, 70, 70);
            dgvEmployees.Location = new Point(15, 45);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RightToLeft = RightToLeft.Yes;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 30;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(756, 480);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BackColor = Color.FromArgb(70, 70, 70);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(15, 71);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "اكتب الاسم الكامل هنا...";
            txtFullName.RightToLeft = RightToLeft.Yes;
            txtFullName.Size = new Size(275, 32);
            txtFullName.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPosition.BackColor = Color.FromArgb(70, 70, 70);
            txtPosition.BorderStyle = BorderStyle.FixedSingle;
            txtPosition.Font = new Font("Segoe UI", 11F);
            txtPosition.ForeColor = Color.White;
            txtPosition.Location = new Point(15, 135);
            txtPosition.Name = "txtPosition";
            txtPosition.PlaceholderText = "اكتب المنصب هنا...";
            txtPosition.RightToLeft = RightToLeft.Yes;
            txtPosition.Size = new Size(275, 32);
            txtPosition.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.ForeColor = Color.FromArgb(170, 170, 170);
            lblFullName.Location = new Point(193, 45);
            lblFullName.Name = "lblFullName";
            lblFullName.RightToLeft = RightToLeft.Yes;
            lblFullName.Size = new Size(97, 23);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "الاسم الكامل";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10F);
            lblPosition.ForeColor = Color.FromArgb(170, 170, 170);
            lblPosition.Location = new Point(221, 109);
            lblPosition.Name = "lblPosition";
            lblPosition.RightToLeft = RightToLeft.Yes;
            lblPosition.Size = new Size(69, 23);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "المنصب";
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
            btnAdd.Location = new Point(15, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(275, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "إضافة موظف جديد";
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
            btnUpdate.Location = new Point(15, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(275, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "تعديل الموظف المحدد";
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
            btnDelete.Location = new Point(15, 265);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(275, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "تعطيل الموظف المحدد";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateUser.BackColor = Color.FromArgb(26, 188, 156);
            btnCreateUser.Cursor = Cursors.Hand;
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(15, 310);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(275, 40);
            btnCreateUser.TabIndex = 8;
            btnCreateUser.Text = "إنشاء حساب مستخدم";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
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
            btnShowDisabled.Location = new Point(15, 355);
            btnShowDisabled.Name = "btnShowDisabled";
            btnShowDisabled.Size = new Size(275, 40);
            btnShowDisabled.TabIndex = 9;
            btnShowDisabled.Text = "عرض الموظفين المعطلين";
            btnShowDisabled.UseVisualStyleBackColor = false;
            btnShowDisabled.Click += btnShowDisabled_Click;
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
            btnRefresh.Location = new Point(15, 400);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(275, 40);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "تحديث القائمة";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDisableUser
            // 
            btnDisableUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDisableUser.BackColor = Color.FromArgb(230, 126, 34);
            btnDisableUser.Cursor = Cursors.Hand;
            btnDisableUser.Enabled = false;
            btnDisableUser.FlatAppearance.BorderSize = 0;
            btnDisableUser.FlatStyle = FlatStyle.Flat;
            btnDisableUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDisableUser.ForeColor = Color.White;
            btnDisableUser.Location = new Point(15, 445);
            btnDisableUser.Name = "btnDisableUser";
            btnDisableUser.Size = new Size(275, 40);
            btnDisableUser.TabIndex = 11;
            btnDisableUser.Text = "تعطيل حساب المستخدم";
            btnDisableUser.UseVisualStyleBackColor = false;
            btnDisableUser.Click += btnDisableUser_Click;
            // 
            // btnEnableUser
            // 
            btnEnableUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEnableUser.BackColor = Color.FromArgb(39, 174, 96);
            btnEnableUser.Cursor = Cursors.Hand;
            btnEnableUser.Enabled = false;
            btnEnableUser.FlatAppearance.BorderSize = 0;
            btnEnableUser.FlatStyle = FlatStyle.Flat;
            btnEnableUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEnableUser.ForeColor = Color.White;
            btnEnableUser.Location = new Point(15, 490);
            btnEnableUser.Name = "btnEnableUser";
            btnEnableUser.Size = new Size(275, 40);
            btnEnableUser.TabIndex = 12;
            btnEnableUser.Text = "تفعيل حساب المستخدم";
            btnEnableUser.UseVisualStyleBackColor = false;
            btnEnableUser.Click += btnEnableUser_Click;
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(panelActions);
            panelMainCard.Controls.Add(panelData);
            panelMainCard.Location = new Point(30, 30);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(1122, 595);
            panelMainCard.TabIndex = 11;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelActions.BackColor = Color.FromArgb(37, 37, 38);
            panelActions.Controls.Add(lblActionsTitle);
            panelActions.Controls.Add(btnRefresh);
            panelActions.Controls.Add(btnShowDisabled);
            panelActions.Controls.Add(btnEnableUser);
            panelActions.Controls.Add(btnDisableUser);
            panelActions.Controls.Add(btnCreateUser);
            panelActions.Controls.Add(btnDelete);
            panelActions.Controls.Add(btnUpdate);
            panelActions.Controls.Add(btnAdd);
            panelActions.Controls.Add(lblPosition);
            panelActions.Controls.Add(txtPosition);
            panelActions.Controls.Add(lblFullName);
            panelActions.Controls.Add(txtFullName);
            panelActions.Location = new Point(812, 15);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(0, 5, 5, 5);
            panelActions.Size = new Size(300, 565);
            panelActions.TabIndex = 1;
            // 
            // lblActionsTitle
            // 
            lblActionsTitle.AutoSize = true;
            lblActionsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblActionsTitle.ForeColor = Color.White;
            lblActionsTitle.Location = new Point(200, 5);
            lblActionsTitle.Name = "lblActionsTitle";
            lblActionsTitle.RightToLeft = RightToLeft.Yes;
            lblActionsTitle.Size = new Size(100, 32);
            lblActionsTitle.TabIndex = 12;
            lblActionsTitle.Text = "الإجراءات";
            // 
            // panelData
            // 
            panelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelData.BackColor = Color.FromArgb(45, 45, 48);
            panelData.Controls.Add(lblDataTitle);
            panelData.Controls.Add(dgvEmployees);
            panelData.Location = new Point(15, 15);
            panelData.Name = "panelData";
            panelData.Size = new Size(802, 565);
            panelData.TabIndex = 0;
            // 
            // lblDataTitle
            // 
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(527, 10);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.RightToLeft = RightToLeft.Yes;
            lblDataTitle.Size = new Size(114, 32);
            lblDataTitle.TabIndex = 1;
            lblDataTitle.Text = "الموظفون";
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1182, 655);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 500);
            Name = "EmployeesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الموظفين";
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            panelMainCard.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowDisabled;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Button btnDisableUser;
        private System.Windows.Forms.Button btnEnableUser;
    }
}