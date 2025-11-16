// Forms/LoginForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// The login form for the application.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the LoginForm.
        /// Clears the error label and sets focus to the username textbox.
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblError.Text = ""; // Hide the error message on startup
            txtUsername.Focus(); // Set focus to the username field
        }

        /// <summary>
        /// Handles the Click event of the login button.
        /// Validates user credentials and logs the user in if successful.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = ""; // Clear any old error messages

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = "Please enter username and password.";
                return;
            }

            try
            {
                DataTable userTable = UserManager.ValidateUser(txtUsername.Text, txtPassword.Text);

                if (userTable != null && userTable.Rows.Count > 0)
                {
                    DataRow user = userTable.Rows[0];
                    bool isActive = Convert.ToBoolean(user["IsActive"]);

                    if (!isActive)
                    {
                        // The account exists but is disabled
                        lblError.Text = "Your account is disabled. Please contact the system administrator.";
                        return;
                    }

                    // The account is active, login successful
                    CurrentUserManager.Login(
                        Convert.ToInt32(user["UserID"]),
                        user["Username"].ToString(),
                        user["Role"].ToString(),
                        user["FullName"].ToString(),
                        Convert.ToInt32(user["EmployeeID"])
                    );

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    // Login failed (incorrect username or password)
                    lblError.Text = "Incorrect username or password.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblError.Text = "A database connection error occurred.";
            }
        }
    }
}