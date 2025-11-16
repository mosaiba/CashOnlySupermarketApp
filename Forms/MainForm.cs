using System;
using System.Drawing;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// The main form of the application, providing access to different modules based on user permissions.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MainForm.
        /// Sets the user information in the status bar and applies user permissions.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Update the status bar with user information from CurrentUserManager
            lblCurrentUser.Text = "User: " + CurrentUserManager.FullName;
            lblUserRole.Text = "Role: " + CurrentUserManager.Role;

            // Apply access permissions based on the current user's role
            ApplyUserPermissions();
        }

        /// <summary>
        /// Applies user permissions by enabling or disabling access to different modules (cards).
        /// </summary>
        private void ApplyUserPermissions()
        {
            // Enable all cards by default
            cardProducts.Enabled = true;
            cardCategories.Enabled = true;
            cardSuppliers.Enabled = true;
            cardUnits.Enabled = true;
            cardEmployees.Enabled = true;
            cardPOS.Enabled = true;
            cardPurchases.Enabled = true;

            // Use helper methods from CurrentUserManager to check permissions
            if (CurrentUserManager.IsAdmin())
            {
                // Admin has full permissions, no changes needed
                return;
            }

            if (CurrentUserManager.IsManager())
            {
                // Manager has broad permissions but cannot manage employees
                cardEmployees.Enabled = false;
                return;
            }

            if (CurrentUserManager.IsCashier())
            {
                // Cashier can only sell and view products
                cardCategories.Enabled = false;
                cardSuppliers.Enabled = false;
                cardUnits.Enabled = false;
                cardEmployees.Enabled = false;
                cardPurchases.Enabled = false;
                cardProducts.Enabled = false;
                return;
            }

            // If none of the above roles, the user has no permissions
            cardProducts.Enabled = false;
            cardCategories.Enabled = false;
            cardSuppliers.Enabled = false;
            cardUnits.Enabled = false;
            cardEmployees.Enabled = false;
            cardPOS.Enabled = false;
            cardPurchases.Enabled = false;
            MessageBox.Show("You do not have sufficient permissions to access any module.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Handles the Click event of the Products card. Opens the ProductsForm.
        /// </summary>
        private void cardProducts_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the Categories card. Opens the CategoriesForm.
        /// </summary>
        private void cardCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm();
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the Suppliers card. Opens the SuppliersForm.
        /// </summary>
        private void cardSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm form = new SuppliersForm();
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the Units card. Opens the UnitsForm.
        /// </summary>
        private void cardUnits_Click(object sender, EventArgs e)
        {
            UnitsForm form = new UnitsForm();
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the Employees card. Opens the EmployeesForm.
        /// </summary>
        private void cardEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm();
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the POS card. Opens the POSForm.
        /// </summary>
        private void cardPOS_Click(object sender, EventArgs e)
        {
            POSForm form = new POSForm();
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the Purchases card. Opens the PurchasesForm.
        /// </summary>
        private void cardPurchases_Click(object sender, EventArgs e)
        {
            PurchasesForm form = new PurchasesForm();
            form.Show();
        }

        /// <summary>
        /// Handles the FormClosing event of the MainForm. Exits the application.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the MouseLeave event of the logout button.
        /// </summary>
        private void toolStripSplitButton1_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripSplitButton1.ForeColor = Color.White;
        }

        /// <summary>
        /// Handles the MouseEnter event of the logout button.
        /// </summary>
        private void toolStripSplitButton1_MouseEnter(object sender, EventArgs e)
        {
            this.toolStripSplitButton1.ForeColor = Color.Black;
        }

        /// <summary>
        /// Handles the Click event of the logout button.
        /// Prompts the user for confirmation, then logs out and shows the LoginForm.
        /// </summary>
        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                CurrentUserManager.Logout();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}