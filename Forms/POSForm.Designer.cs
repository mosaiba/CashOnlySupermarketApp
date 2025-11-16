namespace CashOnlySupermarketApp.Forms
{
    partial class POSForm
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
            btnRefreshProducts = new Button();
            dgvAllProducts = new DataGridView();
            lblSearchByBarcode = new Label();
            txtSearchByBarcode = new TextBox();
            lblSearchByName = new Label();
            txtSearchByName = new TextBox();
            panelBottom = new Panel();
            btnDeleteFromSale = new Button();
            btnClearSale = new Button();
            dgvSaleDetails = new DataGridView();
            lblSaleCart = new Label();
            panelFooter = new Panel();
            lblTotalAmount = new Label();
            lblTotalAmountValue = new Label();
            btnCancel = new Button();
            btnFinalizeSale = new Button();
            panelMainCard.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).BeginInit();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(panelTop);
            panelMainCard.Controls.Add(panelBottom);
            panelMainCard.Controls.Add(panelFooter);
            panelMainCard.Location = new Point(20, 20);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(1389, 860);
            panelMainCard.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(37, 37, 38);
            panelTop.Controls.Add(btnRefreshProducts);
            panelTop.Controls.Add(dgvAllProducts);
            panelTop.Controls.Add(lblSearchByBarcode);
            panelTop.Controls.Add(txtSearchByBarcode);
            panelTop.Controls.Add(lblSearchByName);
            panelTop.Controls.Add(txtSearchByName);
            panelTop.Location = new Point(15, 15);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1359, 357);
            panelTop.TabIndex = 1;
            // 
            // btnRefreshProducts
            // 
            btnRefreshProducts.BackColor = Color.FromArgb(86, 86, 86);
            btnRefreshProducts.Cursor = Cursors.Hand;
            btnRefreshProducts.FlatAppearance.BorderSize = 0;
            btnRefreshProducts.FlatStyle = FlatStyle.Flat;
            btnRefreshProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefreshProducts.ForeColor = Color.White;
            btnRefreshProducts.Location = new Point(15, 14);
            btnRefreshProducts.Name = "btnRefreshProducts";
            btnRefreshProducts.Size = new Size(120, 35);
            btnRefreshProducts.TabIndex = 5;
            btnRefreshProducts.Text = "تحديث المنتجات";
            btnRefreshProducts.UseVisualStyleBackColor = false;
            btnRefreshProducts.Click += btnRefreshProducts_Click;
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
            dgvAllProducts.Location = new Point(15, 60);
            dgvAllProducts.Name = "dgvAllProducts";
            dgvAllProducts.ReadOnly = true;
            dgvAllProducts.RightToLeft = RightToLeft.Yes;
            dgvAllProducts.RowHeadersVisible = false;
            dgvAllProducts.RowHeadersWidth = 51;
            dgvAllProducts.RowTemplate.Height = 30;
            dgvAllProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProducts.Size = new Size(1329, 270);
            dgvAllProducts.TabIndex = 4;
            // 
            // lblSearchByBarcode
            // 
            lblSearchByBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchByBarcode.AutoSize = true;
            lblSearchByBarcode.Font = new Font("Segoe UI", 10F);
            lblSearchByBarcode.ForeColor = Color.FromArgb(170, 170, 170);
            lblSearchByBarcode.Location = new Point(786, 22);
            lblSearchByBarcode.Name = "lblSearchByBarcode";
            lblSearchByBarcode.RightToLeft = RightToLeft.Yes;
            lblSearchByBarcode.Size = new Size(106, 23);
            lblSearchByBarcode.TabIndex = 2;
            lblSearchByBarcode.Text = "بحث بالباركود";
            // 
            // txtSearchByBarcode
            // 
            txtSearchByBarcode.BackColor = Color.FromArgb(70, 70, 70);
            txtSearchByBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtSearchByBarcode.Font = new Font("Segoe UI", 12F);
            txtSearchByBarcode.ForeColor = Color.White;
            txtSearchByBarcode.Location = new Point(557, 15);
            txtSearchByBarcode.Name = "txtSearchByBarcode";
            txtSearchByBarcode.PlaceholderText = "امسح باركود المنتج...";
            txtSearchByBarcode.RightToLeft = RightToLeft.Yes;
            txtSearchByBarcode.Size = new Size(223, 34);
            txtSearchByBarcode.TabIndex = 3;
            txtSearchByBarcode.TextChanged += txtSearchByBarcode_TextChanged;
            // 
            // lblSearchByName
            // 
            lblSearchByName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchByName.AutoSize = true;
            lblSearchByName.Font = new Font("Segoe UI", 10F);
            lblSearchByName.ForeColor = Color.FromArgb(170, 170, 170);
            lblSearchByName.Location = new Point(1234, 20);
            lblSearchByName.Name = "lblSearchByName";
            lblSearchByName.RightToLeft = RightToLeft.Yes;
            lblSearchByName.Size = new Size(91, 23);
            lblSearchByName.TabIndex = 0;
            lblSearchByName.Text = "بحث بالاسم";
            // 
            // txtSearchByName
            // 
            txtSearchByName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchByName.BackColor = Color.FromArgb(70, 70, 70);
            txtSearchByName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchByName.Font = new Font("Segoe UI", 12F);
            txtSearchByName.ForeColor = Color.White;
            txtSearchByName.Location = new Point(978, 15);
            txtSearchByName.Name = "txtSearchByName";
            txtSearchByName.PlaceholderText = "اكتب اسم المنتج...";
            txtSearchByName.RightToLeft = RightToLeft.Yes;
            txtSearchByName.Size = new Size(250, 34);
            txtSearchByName.TabIndex = 1;
            txtSearchByName.TextChanged += txtSearchByName_TextChanged;
            // 
            // panelBottom
            // 
            panelBottom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBottom.BackColor = Color.FromArgb(37, 37, 38);
            panelBottom.Controls.Add(btnDeleteFromSale);
            panelBottom.Controls.Add(btnClearSale);
            panelBottom.Controls.Add(dgvSaleDetails);
            panelBottom.Controls.Add(lblSaleCart);
            panelBottom.Location = new Point(15, 395);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1359, 365);
            panelBottom.TabIndex = 2;
            // 
            // btnDeleteFromSale
            // 
            btnDeleteFromSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteFromSale.BackColor = Color.FromArgb(196, 43, 28);
            btnDeleteFromSale.Cursor = Cursors.Hand;
            btnDeleteFromSale.FlatAppearance.BorderSize = 0;
            btnDeleteFromSale.FlatStyle = FlatStyle.Flat;
            btnDeleteFromSale.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteFromSale.ForeColor = Color.White;
            btnDeleteFromSale.Location = new Point(15, 9);
            btnDeleteFromSale.Name = "btnDeleteFromSale";
            btnDeleteFromSale.Size = new Size(120, 42);
            btnDeleteFromSale.TabIndex = 8;
            btnDeleteFromSale.Text = "حذف بند";
            btnDeleteFromSale.UseVisualStyleBackColor = false;
            btnDeleteFromSale.Click += btnDeleteFromSale_Click;
            // 
            // btnClearSale
            // 
            btnClearSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearSale.BackColor = Color.FromArgb(196, 43, 28);
            btnClearSale.Cursor = Cursors.Hand;
            btnClearSale.FlatAppearance.BorderSize = 0;
            btnClearSale.FlatStyle = FlatStyle.Flat;
            btnClearSale.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearSale.ForeColor = Color.White;
            btnClearSale.Location = new Point(153, 9);
            btnClearSale.Name = "btnClearSale";
            btnClearSale.Size = new Size(110, 42);
            btnClearSale.TabIndex = 9;
            btnClearSale.Text = "إفراغ السلة";
            btnClearSale.UseVisualStyleBackColor = false;
            btnClearSale.Click += btnClearSale_Click;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.AllowUserToAddRows = false;
            dgvSaleDetails.AllowUserToDeleteRows = false;
            dgvSaleDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleDetails.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvSaleDetails.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSaleDetails.ColumnHeadersHeight = 40;
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSaleDetails.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSaleDetails.EnableHeadersVisualStyles = false;
            dgvSaleDetails.GridColor = Color.FromArgb(70, 70, 70);
            dgvSaleDetails.Location = new Point(15, 50);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.RightToLeft = RightToLeft.Yes;
            dgvSaleDetails.RowHeadersVisible = false;
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.RowTemplate.Height = 30;
            dgvSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetails.Size = new Size(1329, 297);
            dgvSaleDetails.TabIndex = 7;
            // 
            // lblSaleCart
            // 
            lblSaleCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSaleCart.AutoSize = true;
            lblSaleCart.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSaleCart.ForeColor = Color.White;
            lblSaleCart.Location = new Point(1160, 8);
            lblSaleCart.Name = "lblSaleCart";
            lblSaleCart.RightToLeft = RightToLeft.Yes;
            lblSaleCart.Size = new Size(165, 32);
            lblSaleCart.TabIndex = 6;
            lblSaleCart.Text = "سلة المشتريات";
            // 
            // panelFooter
            // 
            panelFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFooter.BackColor = Color.FromArgb(37, 37, 38);
            panelFooter.Controls.Add(lblTotalAmount);
            panelFooter.Controls.Add(lblTotalAmountValue);
            panelFooter.Controls.Add(btnCancel);
            panelFooter.Controls.Add(btnFinalizeSale);
            panelFooter.Location = new Point(15, 770);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1359, 70);
            panelFooter.TabIndex = 3;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Left;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(332, 20);
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
            lblTotalAmountValue.Location = new Point(121, 20);
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
            btnCancel.Location = new Point(969, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "إغلاق";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFinalizeSale
            // 
            btnFinalizeSale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinalizeSale.BackColor = Color.FromArgb(0, 120, 215);
            btnFinalizeSale.Cursor = Cursors.Hand;
            btnFinalizeSale.FlatAppearance.BorderSize = 0;
            btnFinalizeSale.FlatStyle = FlatStyle.Flat;
            btnFinalizeSale.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnFinalizeSale.ForeColor = Color.White;
            btnFinalizeSale.Location = new Point(1109, 12);
            btnFinalizeSale.Name = "btnFinalizeSale";
            btnFinalizeSale.Size = new Size(230, 50);
            btnFinalizeSale.TabIndex = 12;
            btnFinalizeSale.Text = "إنهاء البيع";
            btnFinalizeSale.UseVisualStyleBackColor = false;
            btnFinalizeSale.Click += btnFinalizeSale_Click;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1429, 900);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImeMode = ImeMode.Hiragana;
            MinimumSize = new Size(1000, 700);
            Name = "POSForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نقطة البيع";
            Load += POSForm_Load;
            panelMainCard.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label lblSearchByBarcode;
        private System.Windows.Forms.TextBox txtSearchByBarcode;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.Label lblSaleCart;
        private System.Windows.Forms.DataGridView dgvSaleDetails;
        private System.Windows.Forms.Button btnDeleteFromSale;
        private System.Windows.Forms.Button btnClearSale;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Button btnFinalizeSale;
        private System.Windows.Forms.Button btnCancel;
    }
}