namespace CashOnlySupermarketApp.Forms
{
    partial class LoginForm
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
            panelMainCard = new Panel();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            panelMainCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainCard
            // 
            panelMainCard.Anchor = AnchorStyles.None;
            panelMainCard.BackColor = Color.FromArgb(45, 45, 48);
            panelMainCard.Controls.Add(lblTitle);
            panelMainCard.Controls.Add(lblUsername);
            panelMainCard.Controls.Add(txtUsername);
            panelMainCard.Controls.Add(lblPassword);
            panelMainCard.Controls.Add(txtPassword);
            panelMainCard.Controls.Add(btnLogin);
            panelMainCard.Controls.Add(lblError);
            panelMainCard.Location = new Point(50, 50);
            panelMainCard.Name = "panelMainCard";
            panelMainCard.Size = new Size(350, 400);
            panelMainCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(65, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.Yes;
            lblTitle.Size = new Size(254, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "نظام إدارة المتجر";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.FromArgb(170, 170, 170);
            lblUsername.Location = new Point(207, 109);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(112, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "اسم المستخدم";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(70, 70, 70);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(30, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "أدخل اسم المستخدم";
            txtUsername.RightToLeft = RightToLeft.Yes;
            txtUsername.Size = new Size(290, 34);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.FromArgb(170, 170, 170);
            lblPassword.Location = new Point(228, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.RightToLeft = RightToLeft.Yes;
            lblPassword.Size = new Size(91, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "كلمة المرور";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(70, 70, 70);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(30, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "أدخل كلمة المرور";
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Size = new Size(290, 34);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "دخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(231, 76, 60);
            lblError.Location = new Point(30, 330);
            lblError.Name = "lblError";
            lblError.RightToLeft = RightToLeft.Yes;
            lblError.Size = new Size(290, 30);
            lblError.TabIndex = 6;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(450, 500);
            Controls.Add(panelMainCard);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            Load += LoginForm_Load;
            panelMainCard.ResumeLayout(false);
            panelMainCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
    }
}