namespace CashOnlySupermarketApp.Forms
{
    partial class DisabledEmployeesForm
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
            dgvDisabledEmployees = new DataGridView();
            btnActivate = new Button();
            btnClose = new Button();
            panelMainCard = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDisabledEmployees).BeginInit();
            panelMainCard.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDisabledEmployees
            // 
            dgvDisabledEmployees.AllowUserToAddRows = false;
            dgvDisabledEmployees.AllowUserToDeleteRows = false;
            dgvDisabledEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisabledEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisabledEmployees.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvDisabledEmployees.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDisabledEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDisabledEmployees.ColumnHeadersHeight = 40;
            dgvDisabledEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDisabledEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDisabledEmployees.EnableHeadersVisualStyles = false;
            dgvDisabledEmployees.GridColor = Color.FromArgb(70, 70, 70);
            dgvDisabledEmployees.Location = new Point(15, 15);
            dgvDisabledEmployees.Name = "dgvDisabledEmployees";
            dgvDisabledEmployees.ReadOnly = true;
            dgvDisabledEmployees.RightToLeft = RightToLeft.Yes;
            dgvDisabledEmployees.RowHeadersVisible = false;
            dgvDisabledEmployees.RowHeadersWidth = 51;
            dgvDisabledEmployees.RowTemplate.Height = 30;
            dgvDisabledEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisabledEmployees.Size = new Size(780, 470);
            dgvDisabledEmployees.TabIndex = 0;
            // 
            // btnActivate
            // 
            btnActivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActivate.BackColor = Color.FromArgb(0, 120, 215);
            btnActivate.Cursor = Cursors.Hand;
            btnActivate.FlatAppearance.BorderSize = 0;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnActivate.ForeColor = Color.White;
            btnActivate.Location = new Point(472, 6);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(164, 55);
            btnActivate.TabIndex = 1;
            btnActivate.Text = "استعادة الموظف";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(86, 86, 86);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(642, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 55);
            btnClose.TabIndex = 2;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(dgvDisabledEmployees);
            panelMainCard.Controls.Add(panelButtons);
            panelMainCard.Location = new Point(30, 30);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(810, 550);
            panelMainCard.TabIndex = 3;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(37, 37, 38);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnActivate);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 485);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(810, 65);
            panelButtons.TabIndex = 1;
            // 
            // DisabledEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(870, 610);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(700, 500);
            Name = "DisabledEmployeesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الموظفون المعطلون";
            Load += DisabledEmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisabledEmployees).EndInit();
            panelMainCard.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisabledEmployees;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelButtons;
    }
}