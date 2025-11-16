namespace CashOnlySupermarketApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelDashboard = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanelCards = new TableLayoutPanel();
            cardProducts = new Panel();
            lblProductsTitle = new Label();
            cardCategories = new Panel();
            lblCategoriesTitle = new Label();
            cardSuppliers = new Panel();
            lblSuppliersTitle = new Label();
            cardUnits = new Panel();
            lblUnitsTitle = new Label();
            cardEmployees = new Panel();
            lblEmployeesTitle = new Label();
            cardPOS = new Panel();
            lblPOSTitle = new Label();
            cardPurchases = new Panel();
            lblPurchasesTitle = new Label();
            statusStripMain = new StatusStrip();
            lblUserRole = new ToolStripStatusLabel();
            lblCurrentUser = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            panelDashboard.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            cardProducts.SuspendLayout();
            cardCategories.SuspendLayout();
            cardSuppliers.SuspendLayout();
            cardUnits.SuspendLayout();
            cardEmployees.SuspendLayout();
            cardPOS.SuspendLayout();
            cardPurchases.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(32, 32, 32);
            panelDashboard.Controls.Add(panel1);
            panelDashboard.Controls.Add(tableLayoutPanelCards);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1200, 750);
            panelDashboard.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 135);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(230, 230, 230);
            label1.Location = new Point(731, 43);
            label1.Name = "label1";
            label1.Size = new Size(419, 54);
            label1.TabIndex = 0;
            label1.Text = "نظام ادارة السوبر ماركت";
            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCards.AutoScroll = true;
            tableLayoutPanelCards.ColumnCount = 3;
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.Controls.Add(cardProducts, 0, 0);
            tableLayoutPanelCards.Controls.Add(cardCategories, 1, 0);
            tableLayoutPanelCards.Controls.Add(cardSuppliers, 2, 0);
            tableLayoutPanelCards.Controls.Add(cardUnits, 0, 1);
            tableLayoutPanelCards.Controls.Add(cardEmployees, 1, 1);
            tableLayoutPanelCards.Controls.Add(cardPOS, 2, 1);
            tableLayoutPanelCards.Controls.Add(cardPurchases, 0, 2);
            tableLayoutPanelCards.Location = new Point(50, 178);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.Padding = new Padding(20);
            tableLayoutPanelCards.RowCount = 3;
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.Size = new Size(1100, 522);
            tableLayoutPanelCards.TabIndex = 0;
            // 
            // cardProducts
            // 
            cardProducts.BackColor = Color.FromArgb(0, 120, 215);
            cardProducts.Controls.Add(lblProductsTitle);
            cardProducts.Cursor = Cursors.Hand;
            cardProducts.Dock = DockStyle.Fill;
            cardProducts.Location = new Point(730, 23);
            cardProducts.Name = "cardProducts";
            cardProducts.Size = new Size(347, 154);
            cardProducts.TabIndex = 0;
            cardProducts.Click += cardProducts_Click;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.Dock = DockStyle.Fill;
            lblProductsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProductsTitle.ForeColor = Color.White;
            lblProductsTitle.Location = new Point(0, 0);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(347, 154);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "📦 إدارة المنتجات\n\nإضافة، تعديل، وحذف المنتجات";
            lblProductsTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblProductsTitle.Click += cardProducts_Click;
            // 
            // cardCategories
            // 
            cardCategories.BackColor = Color.FromArgb(46, 204, 113);
            cardCategories.Controls.Add(lblCategoriesTitle);
            cardCategories.Cursor = Cursors.Hand;
            cardCategories.Dock = DockStyle.Fill;
            cardCategories.Location = new Point(377, 23);
            cardCategories.Name = "cardCategories";
            cardCategories.Size = new Size(347, 154);
            cardCategories.TabIndex = 1;
            cardCategories.Click += cardCategories_Click;
            // 
            // lblCategoriesTitle
            // 
            lblCategoriesTitle.Dock = DockStyle.Fill;
            lblCategoriesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCategoriesTitle.ForeColor = Color.White;
            lblCategoriesTitle.Location = new Point(0, 0);
            lblCategoriesTitle.Name = "lblCategoriesTitle";
            lblCategoriesTitle.Size = new Size(347, 154);
            lblCategoriesTitle.TabIndex = 0;
            lblCategoriesTitle.Text = "🏷️ إدارة الفئات\n\nتنظيم المنتجات ضمن فئات";
            lblCategoriesTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblCategoriesTitle.Click += cardPurchases_Click;
            // 
            // cardSuppliers
            // 
            cardSuppliers.BackColor = Color.FromArgb(155, 89, 182);
            cardSuppliers.Controls.Add(lblSuppliersTitle);
            cardSuppliers.Cursor = Cursors.Hand;
            cardSuppliers.Dock = DockStyle.Fill;
            cardSuppliers.Location = new Point(23, 23);
            cardSuppliers.Name = "cardSuppliers";
            cardSuppliers.Size = new Size(348, 154);
            cardSuppliers.TabIndex = 2;
            cardSuppliers.Click += cardSuppliers_Click;
            // 
            // lblSuppliersTitle
            // 
            lblSuppliersTitle.Dock = DockStyle.Fill;
            lblSuppliersTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSuppliersTitle.ForeColor = Color.White;
            lblSuppliersTitle.Location = new Point(0, 0);
            lblSuppliersTitle.Name = "lblSuppliersTitle";
            lblSuppliersTitle.Size = new Size(348, 154);
            lblSuppliersTitle.TabIndex = 0;
            lblSuppliersTitle.Text = "🚚 إدارة الموردين\n\nإضافة وتعديل بيانات الموردين";
            lblSuppliersTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSuppliersTitle.Click += cardSuppliers_Click;
            // 
            // cardUnits
            // 
            cardUnits.BackColor = Color.FromArgb(241, 196, 15);
            cardUnits.Controls.Add(lblUnitsTitle);
            cardUnits.Cursor = Cursors.Hand;
            cardUnits.Dock = DockStyle.Fill;
            cardUnits.Location = new Point(730, 183);
            cardUnits.Name = "cardUnits";
            cardUnits.Size = new Size(347, 154);
            cardUnits.TabIndex = 3;
            cardUnits.Click += cardUnits_Click;
            // 
            // lblUnitsTitle
            // 
            lblUnitsTitle.Dock = DockStyle.Fill;
            lblUnitsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUnitsTitle.ForeColor = Color.White;
            lblUnitsTitle.Location = new Point(0, 0);
            lblUnitsTitle.Name = "lblUnitsTitle";
            lblUnitsTitle.Size = new Size(347, 154);
            lblUnitsTitle.TabIndex = 0;
            lblUnitsTitle.Text = "⚖️ إدارة الوحدات\n\nتحديد وحدات القياس (كجم، علبة، إلخ)";
            lblUnitsTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblUnitsTitle.Click += cardUnits_Click;
            // 
            // cardEmployees
            // 
            cardEmployees.BackColor = Color.FromArgb(231, 76, 60);
            cardEmployees.Controls.Add(lblEmployeesTitle);
            cardEmployees.Cursor = Cursors.Hand;
            cardEmployees.Dock = DockStyle.Fill;
            cardEmployees.Location = new Point(377, 183);
            cardEmployees.Name = "cardEmployees";
            cardEmployees.Size = new Size(347, 154);
            cardEmployees.TabIndex = 4;
            cardEmployees.Click += cardEmployees_Click;
            // 
            // lblEmployeesTitle
            // 
            lblEmployeesTitle.Dock = DockStyle.Fill;
            lblEmployeesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEmployeesTitle.ForeColor = Color.White;
            lblEmployeesTitle.Location = new Point(0, 0);
            lblEmployeesTitle.Name = "lblEmployeesTitle";
            lblEmployeesTitle.Size = new Size(347, 154);
            lblEmployeesTitle.TabIndex = 0;
            lblEmployeesTitle.Text = "👥 إدارة الموظفين\n\nإدارة حسابات الموظفين وصلاحياتهم";
            lblEmployeesTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblEmployeesTitle.Click += cardEmployees_Click;
            // 
            // cardPOS
            // 
            cardPOS.BackColor = Color.FromArgb(26, 188, 156);
            cardPOS.Controls.Add(lblPOSTitle);
            cardPOS.Cursor = Cursors.Hand;
            cardPOS.Dock = DockStyle.Fill;
            cardPOS.Location = new Point(23, 183);
            cardPOS.Name = "cardPOS";
            cardPOS.Size = new Size(348, 154);
            cardPOS.TabIndex = 5;
            cardPOS.Click += cardPOS_Click;
            // 
            // lblPOSTitle
            // 
            lblPOSTitle.Dock = DockStyle.Fill;
            lblPOSTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPOSTitle.ForeColor = Color.White;
            lblPOSTitle.Location = new Point(0, 0);
            lblPOSTitle.Name = "lblPOSTitle";
            lblPOSTitle.Size = new Size(348, 154);
            lblPOSTitle.TabIndex = 0;
            lblPOSTitle.Text = "💰 نقطة البيع\n\nإجراء عمليات البيع للمستخدمين";
            lblPOSTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblPOSTitle.Click += cardPOS_Click;
            // 
            // cardPurchases
            // 
            cardPurchases.BackColor = Color.FromArgb(142, 68, 173);
            cardPurchases.Controls.Add(lblPurchasesTitle);
            cardPurchases.Cursor = Cursors.Hand;
            cardPurchases.Dock = DockStyle.Fill;
            cardPurchases.Location = new Point(730, 343);
            cardPurchases.Name = "cardPurchases";
            cardPurchases.Size = new Size(347, 156);
            cardPurchases.TabIndex = 6;
            cardPurchases.Click += cardPurchases_Click;
            // 
            // lblPurchasesTitle
            // 
            lblPurchasesTitle.Dock = DockStyle.Fill;
            lblPurchasesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPurchasesTitle.ForeColor = Color.White;
            lblPurchasesTitle.Location = new Point(0, 0);
            lblPurchasesTitle.Name = "lblPurchasesTitle";
            lblPurchasesTitle.Size = new Size(347, 156);
            lblPurchasesTitle.TabIndex = 0;
            lblPurchasesTitle.Text = "📋 فواتير الشراء\n\nإنشاء فواتير شراء من الموردين";
            lblPurchasesTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblPurchasesTitle.Click += cardPurchases_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = Color.FromArgb(45, 45, 48);
            statusStripMain.Font = new Font("Segoe UI", 10F);
            statusStripMain.GripMargin = new Padding(10);
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { lblUserRole, lblCurrentUser, toolStripSplitButton1 });
            statusStripMain.Location = new Point(0, 703);
            statusStripMain.Margin = new Padding(10);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new Padding(1, 0, 19, 0);
            statusStripMain.Size = new Size(1200, 47);
            statusStripMain.TabIndex = 1;
            statusStripMain.Text = "statusStripMain";
            // 
            // lblUserRole
            // 
            lblUserRole.ForeColor = Color.FromArgb(230, 230, 230);
            lblUserRole.Margin = new Padding(10);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(81, 27);
            lblUserRole.Text = "الصلاحية: ";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.ForeColor = Color.FromArgb(230, 230, 230);
            lblCurrentUser.Margin = new Padding(10);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(88, 27);
            lblCurrentUser.Text = "المستخدم: ";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.ForeColor = Color.FromArgb(230, 230, 230);
            toolStripSplitButton1.Image = Properties.Resources.icons8_system_100;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Margin = new Padding(10);
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.RightToLeft = RightToLeft.Yes;
            toolStripSplitButton1.Size = new Size(147, 27);
            toolStripSplitButton1.Text = "تسجيل الخروج";
            toolStripSplitButton1.Click += toolStripSplitButton1_Click;
            toolStripSplitButton1.MouseEnter += toolStripSplitButton1_MouseEnter;
            toolStripSplitButton1.MouseLeave += toolStripSplitButton1_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1200, 750);
            Controls.Add(statusStripMain);
            Controls.Add(panelDashboard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة التحكم - نظام إدارة المتجر";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panelDashboard.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanelCards.ResumeLayout(false);
            cardProducts.ResumeLayout(false);
            cardCategories.ResumeLayout(false);
            cardSuppliers.ResumeLayout(false);
            cardUnits.ResumeLayout(false);
            cardEmployees.ResumeLayout(false);
            cardPOS.ResumeLayout(false);
            cardPurchases.ResumeLayout(false);
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private System.Windows.Forms.Panel cardProducts;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Panel cardCategories;
        private System.Windows.Forms.Label lblCategoriesTitle;
        private System.Windows.Forms.Panel cardSuppliers;
        private System.Windows.Forms.Label lblSuppliersTitle;
        private System.Windows.Forms.Panel cardUnits;
        private System.Windows.Forms.Label lblUnitsTitle;
        private System.Windows.Forms.Panel cardEmployees;
        private System.Windows.Forms.Label lblEmployeesTitle;
        private System.Windows.Forms.Panel cardPOS;
        private System.Windows.Forms.Label lblPOSTitle;
        private System.Windows.Forms.Panel cardPurchases;
        private System.Windows.Forms.Label lblPurchasesTitle;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private ToolStripSplitButton toolStripSplitButton1;
        private Panel panel1;
        private Label label1;
    }

    #region Custom Renderer for Dark Theme

    public class CustomToolStripRenderer : System.Windows.Forms.ToolStripProfessionalRenderer
    {
        public CustomToolStripRenderer() : base(new CustomProfessionalColorTable()) { }
    }

    public class CustomProfessionalColorTable : System.Windows.Forms.ProfessionalColorTable
    {
        private readonly Color _backgroundColor = Color.FromArgb(45, 45, 48);
        private readonly Color _highlightColor = Color.FromArgb(0, 120, 215);
        private readonly Color _foregroundColor = Color.FromArgb(230, 230, 230);
        private readonly Color _separatorColor = Color.FromArgb(70, 70, 70);

        public override Color MenuItemSelectedGradientBegin => _highlightColor;
        public override Color MenuItemSelectedGradientEnd => _highlightColor;
        public override Color MenuStripGradientBegin => _backgroundColor;
        public override Color MenuStripGradientEnd => _backgroundColor;
        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(104, 104, 104);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(104, 104, 104);
        public override Color ImageMarginGradientBegin => _backgroundColor;
        public override Color ImageMarginGradientEnd => _backgroundColor;
        public override Color ImageMarginRevealedGradientBegin => Color.FromArgb(37, 37, 38);
        public override Color ImageMarginRevealedGradientEnd => Color.FromArgb(37, 37, 38);
        public override Color SeparatorDark => _separatorColor;
        public override Color SeparatorLight => _separatorColor;
        public override Color StatusStripGradientBegin => _backgroundColor;
        public override Color StatusStripGradientEnd => _backgroundColor;
        public override Color ToolStripBorder => Color.Transparent;
    }
    #endregion
}