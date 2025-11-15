namespace CashOnlySupermarketApp.Forms
{
    partial class UnitsForm
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
            dgvUnits = new DataGridView();
            txtUnitName = new TextBox();
            lblUnitName = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            panelMainCard = new Panel();
            panelActions = new Panel();
            lblActionsTitle = new Label();
            panelData = new Panel();
            lblDataTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            panelMainCard.SuspendLayout();
            panelActions.SuspendLayout();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUnits
            // 
            dgvUnits.AllowUserToAddRows = false;
            dgvUnits.AllowUserToDeleteRows = false;
            dgvUnits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnits.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvUnits.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUnits.ColumnHeadersHeight = 40;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUnits.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUnits.EnableHeadersVisualStyles = false;
            dgvUnits.GridColor = Color.FromArgb(70, 70, 70);
            dgvUnits.Location = new Point(15, 45);
            dgvUnits.Name = "dgvUnits";
            dgvUnits.ReadOnly = true;
            dgvUnits.RightToLeft = RightToLeft.Yes;
            dgvUnits.RowHeadersVisible = false;
            dgvUnits.RowHeadersWidth = 51;
            dgvUnits.RowTemplate.Height = 30;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnits.Size = new Size(450, 384);
            dgvUnits.TabIndex = 0;
            dgvUnits.SelectionChanged += dgvUnits_SelectionChanged;
            // 
            // txtUnitName
            // 
            txtUnitName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitName.BackColor = Color.FromArgb(70, 70, 70);
            txtUnitName.BorderStyle = BorderStyle.FixedSingle;
            txtUnitName.Font = new Font("Segoe UI", 11F);
            txtUnitName.ForeColor = Color.White;
            txtUnitName.Location = new Point(15, 80);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.PlaceholderText = "اكتب اسم الوحدة هنا...";
            txtUnitName.RightToLeft = RightToLeft.Yes;
            txtUnitName.Size = new Size(260, 32);
            txtUnitName.TabIndex = 1;
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Font = new Font("Segoe UI", 10F);
            lblUnitName.ForeColor = Color.FromArgb(170, 170, 170);
            lblUnitName.Location = new Point(185, 54);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.RightToLeft = RightToLeft.Yes;
            lblUnitName.Size = new Size(90, 23);
            lblUnitName.TabIndex = 2;
            lblUnitName.Text = "اسم الوحدة";
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
            btnAdd.Text = "إضافة وحدة جديدة";
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
            btnUpdate.Text = "تعديل الوحدة المحددة";
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
            btnDelete.Text = "حذف الوحدة المحددة";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(panelActions);
            panelMainCard.Controls.Add(panelData);
            panelMainCard.Location = new Point(30, 30);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(840, 474);
            panelMainCard.TabIndex = 7;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelActions.BackColor = Color.FromArgb(37, 37, 38);
            panelActions.Controls.Add(lblActionsTitle);
            panelActions.Controls.Add(btnRefresh);
            panelActions.Controls.Add(btnDelete);
            panelActions.Controls.Add(btnUpdate);
            panelActions.Controls.Add(btnAdd);
            panelActions.Controls.Add(lblUnitName);
            panelActions.Controls.Add(txtUnitName);
            panelActions.Location = new Point(545, 15);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(280, 444);
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
            lblActionsTitle.TabIndex = 8;
            lblActionsTitle.Text = "الإجراءات";
            // 
            // panelData
            // 
            panelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelData.BackColor = Color.FromArgb(45, 45, 48);
            panelData.Controls.Add(lblDataTitle);
            panelData.Controls.Add(dgvUnits);
            panelData.Location = new Point(15, 15);
            panelData.Name = "panelData";
            panelData.Size = new Size(480, 444);
            panelData.TabIndex = 0;
            // 
            // lblDataTitle
            // 
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(371, 10);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.RightToLeft = RightToLeft.Yes;
            lblDataTitle.Size = new Size(94, 32);
            lblDataTitle.TabIndex = 1;
            lblDataTitle.Text = "الوحدات";
            // 
            // UnitsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(900, 534);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 500);
            Name = "UnitsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الوحدات";
            Load += UnitsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            panelMainCard.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Label lblDataTitle;
    }
}