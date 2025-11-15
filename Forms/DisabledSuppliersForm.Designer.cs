namespace CashOnlySupermarketApp.Forms
{
    partial class DisabledSuppliersForm
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
            dgvDisabledSuppliers = new DataGridView();
            btnRestore = new Button();
            btnClose = new Button();
            panelMainCard = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDisabledSuppliers).BeginInit();
            panelMainCard.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDisabledSuppliers
            // 
            dgvDisabledSuppliers.AllowUserToAddRows = false;
            dgvDisabledSuppliers.AllowUserToDeleteRows = false;
            dgvDisabledSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisabledSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisabledSuppliers.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvDisabledSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDisabledSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDisabledSuppliers.ColumnHeadersHeight = 40;
            dgvDisabledSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDisabledSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDisabledSuppliers.EnableHeadersVisualStyles = false;
            dgvDisabledSuppliers.GridColor = Color.FromArgb(70, 70, 70);
            dgvDisabledSuppliers.Location = new Point(15, 15);
            dgvDisabledSuppliers.Name = "dgvDisabledSuppliers";
            dgvDisabledSuppliers.ReadOnly = true;
            dgvDisabledSuppliers.RightToLeft = RightToLeft.Yes;
            dgvDisabledSuppliers.RowHeadersVisible = false;
            dgvDisabledSuppliers.RowHeadersWidth = 51;
            dgvDisabledSuppliers.RowTemplate.Height = 30;
            dgvDisabledSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisabledSuppliers.Size = new Size(780, 470);
            dgvDisabledSuppliers.TabIndex = 0;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.BackColor = Color.FromArgb(0, 120, 215);
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(502, 3);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(144, 56);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "استعادة المورد";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
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
            btnClose.Location = new Point(652, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(155, 56);
            btnClose.TabIndex = 2;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(dgvDisabledSuppliers);
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
            panelButtons.Controls.Add(btnRestore);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 485);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(810, 65);
            panelButtons.TabIndex = 1;
            // 
            // DisabledSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(870, 610);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(700, 500);
            Name = "DisabledSuppliersForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الموردون المعطلون";
            Load += DisabledSuppliersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisabledSuppliers).EndInit();
            panelMainCard.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisabledSuppliers;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelButtons;
    }
}