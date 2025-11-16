namespace CashOnlySupermarketApp.Forms
{
    partial class PurchasesForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMainCard = new Panel();
            panelTop = new Panel();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            btnRefreshProducts = new Button();
            lblSearchByBarcode = new Label();
            txtSearchByBarcode = new TextBox();
            lblSearchByName = new Label();
            txtSearchByName = new TextBox();
            panelProducts = new Panel();
            dgvAllProducts = new DataGridView();
            panelOrder = new Panel();
            lblOrderDetails = new Label();
            dgvOrderDetails = new DataGridView();
            btnDeleteFromOrder = new Button();
            btnClearOrder = new Button();
            panelFooter = new Panel();
            lblTotalAmount = new Label();
            lblTotalAmountValue = new Label();
            btnCancel = new Button();
            btnSaveOrder = new Button();
            panelMainCard.SuspendLayout();
            panelTop.SuspendLayout();
            panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).BeginInit();
            panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(panelTop);
            panelMainCard.Controls.Add(panelProducts);
            panelMainCard.Controls.Add(panelOrder);
            panelMainCard.Controls.Add(panelFooter);
            panelMainCard.Location = new Point(20, 20);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(1394, 860);
            panelMainCard.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(37, 37, 38);
            panelTop.Controls.Add(lblSupplier);
            panelTop.Controls.Add(cmbSupplier);
            panelTop.Controls.Add(btnRefreshProducts);
            panelTop.Controls.Add(lblSearchByBarcode);
            panelTop.Controls.Add(txtSearchByBarcode);
            panelTop.Controls.Add(lblSearchByName);
            panelTop.Controls.Add(txtSearchByName);
            panelTop.Location = new Point(15, 15);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1364, 70);
            panelTop.TabIndex = 1;
            // 
            // lblSupplier
            // 
            lblSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 10F);
            lblSupplier.ForeColor = Color.FromArgb(170, 170, 170);
            lblSupplier.Location = new Point(1290, 22);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.RightToLeft = RightToLeft.Yes;
            lblSupplier.Size = new Size(54, 23);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "المورد";
            // 
            // cmbSupplier
            // 
            cmbSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSupplier.BackColor = Color.FromArgb(70, 70, 70);
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 11F);
            cmbSupplier.ForeColor = Color.White;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(1084, 17);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.RightToLeft = RightToLeft.Yes;
            cmbSupplier.Size = new Size(200, 33);
            cmbSupplier.TabIndex = 1;
            // 
            // btnRefreshProducts
            // 
            btnRefreshProducts.BackColor = Color.FromArgb(86, 86, 86);
            btnRefreshProducts.Cursor = Cursors.Hand;
            btnRefreshProducts.FlatAppearance.BorderSize = 0;
            btnRefreshProducts.FlatStyle = FlatStyle.Flat;
            btnRefreshProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefreshProducts.ForeColor = Color.White;
            btnRefreshProducts.Location = new Point(15, 15);
            btnRefreshProducts.Name = "btnRefreshProducts";
            btnRefreshProducts.Size = new Size(120, 35);
            btnRefreshProducts.TabIndex = 6;
            btnRefreshProducts.Text = "تحديث المنتجات";
            btnRefreshProducts.UseVisualStyleBackColor = false;
            btnRefreshProducts.Click += btnRefreshProducts_Click;
            // 
            // lblSearchByBarcode
            // 
            lblSearchByBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchByBarcode.AutoSize = true;
            lblSearchByBarcode.Font = new Font("Segoe UI", 10F);
            lblSearchByBarcode.ForeColor = Color.FromArgb(170, 170, 170);
            lblSearchByBarcode.Location = new Point(557, 21);
            lblSearchByBarcode.Name = "lblSearchByBarcode";
            lblSearchByBarcode.RightToLeft = RightToLeft.Yes;
            lblSearchByBarcode.Size = new Size(106, 23);
            lblSearchByBarcode.TabIndex = 2;
            lblSearchByBarcode.Text = "بحث بالباركود";
            // 
            // txtSearchByBarcode
            // 
            txtSearchByBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchByBarcode.BackColor = Color.FromArgb(70, 70, 70);
            txtSearchByBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtSearchByBarcode.Font = new Font("Segoe UI", 12F);
            txtSearchByBarcode.ForeColor = Color.White;
            txtSearchByBarcode.Location = new Point(371, 17);
            txtSearchByBarcode.Name = "txtSearchByBarcode";
            txtSearchByBarcode.PlaceholderText = "امسح باركود المنتج...";
            txtSearchByBarcode.RightToLeft = RightToLeft.Yes;
            txtSearchByBarcode.Size = new Size(180, 34);
            txtSearchByBarcode.TabIndex = 3;
            txtSearchByBarcode.TextChanged += txtSearchByBarcode_TextChanged;
            // 
            // lblSearchByName
            // 
            lblSearchByName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchByName.AutoSize = true;
            lblSearchByName.Font = new Font("Segoe UI", 10F);
            lblSearchByName.ForeColor = Color.FromArgb(170, 170, 170);
            lblSearchByName.Location = new Point(942, 22);
            lblSearchByName.Name = "lblSearchByName";
            lblSearchByName.RightToLeft = RightToLeft.Yes;
            lblSearchByName.Size = new Size(91, 23);
            lblSearchByName.TabIndex = 4;
            lblSearchByName.Text = "بحث بالاسم";
            // 
            // txtSearchByName
            // 
            txtSearchByName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchByName.BackColor = Color.FromArgb(70, 70, 70);
            txtSearchByName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchByName.Font = new Font("Segoe UI", 12F);
            txtSearchByName.ForeColor = Color.White;
            txtSearchByName.Location = new Point(686, 17);
            txtSearchByName.Name = "txtSearchByName";
            txtSearchByName.PlaceholderText = "اكتب اسم المنتج...";
            txtSearchByName.RightToLeft = RightToLeft.Yes;
            txtSearchByName.Size = new Size(250, 34);
            txtSearchByName.TabIndex = 5;
            txtSearchByName.TextChanged += txtSearchByName_TextChanged;
            // 
            // panelProducts
            // 
            panelProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelProducts.BackColor = Color.FromArgb(37, 37, 38);
            panelProducts.Controls.Add(dgvAllProducts);
            panelProducts.Location = new Point(15, 95);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(1364, 250);
            panelProducts.TabIndex = 2;
            // 
            // dgvAllProducts
            // 
            dgvAllProducts.AllowUserToAddRows = false;
            dgvAllProducts.AllowUserToDeleteRows = false;
            dgvAllProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllProducts.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvAllProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAllProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAllProducts.ColumnHeadersHeight = 40;
            dgvAllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAllProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAllProducts.EnableHeadersVisualStyles = false;
            dgvAllProducts.GridColor = Color.FromArgb(70, 70, 70);
            dgvAllProducts.Location = new Point(15, 15);
            dgvAllProducts.Name = "dgvAllProducts";
            dgvAllProducts.ReadOnly = true;
            dgvAllProducts.RightToLeft = RightToLeft.Yes;
            dgvAllProducts.RowHeadersVisible = false;
            dgvAllProducts.RowHeadersWidth = 51;
            dgvAllProducts.RowTemplate.Height = 30;
            dgvAllProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProducts.Size = new Size(1334, 220);
            dgvAllProducts.TabIndex = 0;
            // 
            // panelOrder
            // 
            panelOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOrder.BackColor = Color.FromArgb(37, 37, 38);
            panelOrder.Controls.Add(lblOrderDetails);
            panelOrder.Controls.Add(dgvOrderDetails);
            panelOrder.Controls.Add(btnDeleteFromOrder);
            panelOrder.Controls.Add(btnClearOrder);
            panelOrder.Location = new Point(15, 355);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(1364, 350);
            panelOrder.TabIndex = 3;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrderDetails.ForeColor = Color.White;
            lblOrderDetails.Location = new Point(1080, 15);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.RightToLeft = RightToLeft.Yes;
            lblOrderDetails.Size = new Size(167, 32);
            lblOrderDetails.TabIndex = 6;
            lblOrderDetails.Text = "تفاصيل الفاتورة";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvOrderDetails.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderDetails.ColumnHeadersHeight = 40;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle4;
            dgvOrderDetails.EnableHeadersVisualStyles = false;
            dgvOrderDetails.GridColor = Color.FromArgb(70, 70, 70);
            dgvOrderDetails.Location = new Point(15, 50);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RightToLeft = RightToLeft.Yes;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 30;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(1334, 240);
            dgvOrderDetails.TabIndex = 7;
            // 
            // btnDeleteFromOrder
            // 
            btnDeleteFromOrder.BackColor = Color.FromArgb(196, 43, 28);
            btnDeleteFromOrder.Cursor = Cursors.Hand;
            btnDeleteFromOrder.FlatAppearance.BorderSize = 0;
            btnDeleteFromOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteFromOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteFromOrder.ForeColor = Color.White;
            btnDeleteFromOrder.Location = new Point(15, 10);
            btnDeleteFromOrder.Name = "btnDeleteFromOrder";
            btnDeleteFromOrder.Size = new Size(120, 35);
            btnDeleteFromOrder.TabIndex = 8;
            btnDeleteFromOrder.Text = "حذف بند";
            btnDeleteFromOrder.UseVisualStyleBackColor = false;
            btnDeleteFromOrder.Click += btnDeleteFromOrder_Click;
            // 
            // btnClearOrder
            // 
            btnClearOrder.BackColor = Color.FromArgb(196, 43, 28);
            btnClearOrder.Cursor = Cursors.Hand;
            btnClearOrder.FlatAppearance.BorderSize = 0;
            btnClearOrder.FlatStyle = FlatStyle.Flat;
            btnClearOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearOrder.ForeColor = Color.White;
            btnClearOrder.Location = new Point(145, 10);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(140, 35);
            btnClearOrder.TabIndex = 9;
            btnClearOrder.Text = "إفراغ الفاتورة";
            btnClearOrder.UseVisualStyleBackColor = false;
            btnClearOrder.Click += btnClearOrder_Click;
            // 
            // panelFooter
            // 
            panelFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFooter.BackColor = Color.FromArgb(37, 37, 38);
            panelFooter.Controls.Add(lblTotalAmount);
            panelFooter.Controls.Add(lblTotalAmountValue);
            panelFooter.Controls.Add(btnCancel);
            panelFooter.Controls.Add(btnSaveOrder);
            panelFooter.Location = new Point(15, 715);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1364, 120);
            panelFooter.TabIndex = 4;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Left;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(253, 44);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.RightToLeft = RightToLeft.Yes;
            lblTotalAmount.Size = new Size(187, 37);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "الإجمالي الكلي:";
            // 
            // lblTotalAmountValue
            // 
            lblTotalAmountValue.Anchor = AnchorStyles.Left;
            lblTotalAmountValue.AutoSize = true;
            lblTotalAmountValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalAmountValue.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotalAmountValue.Location = new Point(67, 35);
            lblTotalAmountValue.Name = "lblTotalAmountValue";
            lblTotalAmountValue.RightToLeft = RightToLeft.Yes;
            lblTotalAmountValue.Size = new Size(89, 46);
            lblTotalAmountValue.TabIndex = 11;
            lblTotalAmountValue.Text = "0.00";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(86, 86, 86);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(974, 40);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "إغلاق";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveOrder.BackColor = Color.FromArgb(0, 120, 215);
            btnSaveOrder.Cursor = Cursors.Hand;
            btnSaveOrder.FlatAppearance.BorderSize = 0;
            btnSaveOrder.FlatStyle = FlatStyle.Flat;
            btnSaveOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSaveOrder.ForeColor = Color.White;
            btnSaveOrder.Location = new Point(1114, 35);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(230, 50);
            btnSaveOrder.TabIndex = 12;
            btnSaveOrder.Text = "حفظ واستلام الفاتورة";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // PurchasesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1434, 900);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 700);
            Name = "PurchasesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إنشاء فاتورة شراء";
            Load += PurchasesForm_Load;
            panelMainCard.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).EndInit();
            panelOrder.ResumeLayout(false);
            panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label lblSearchByBarcode;
        private System.Windows.Forms.TextBox txtSearchByBarcode;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnDeleteFromOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnCancel;
    }
}