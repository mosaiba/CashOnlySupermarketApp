using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for managing employees, including adding, updating, and deactivating them.
    /// It also allows for managing user accounts associated with employees.
    /// </summary>
    public partial class EmployeesForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeesForm"/> class.
        /// </summary>
        public EmployeesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the EmployeesForm.
        /// </summary>
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        /// <summary>
        /// Loads the list of active employees into the DataGridView.
        /// </summary>
        private void LoadEmployees()
        {
            try
            {
                dgvEmployees.DataSource = EmployeeManager.GetAllActiveEmployeesWithUserStatus();
                if (dgvEmployees.Columns["EmployeeID"] != null) dgvEmployees.Columns["EmployeeID"].HeaderText = "ID";
                if (dgvEmployees.Columns["FullName"] != null) dgvEmployees.Columns["FullName"].HeaderText = "Full Name";
                if (dgvEmployees.Columns["Position"] != null) dgvEmployees.Columns["Position"].HeaderText = "Position";
                if (dgvEmployees.Columns["UserStatus"] != null) dgvEmployees.Columns["UserStatus"].HeaderText = "User Account Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading employees: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Add button.
        /// Adds a new employee to the database.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (EmployeeManager.AddEmployee(txtFullName.Text, txtPosition.Text))
            {
                MessageBox.Show("Employee added successfully.");
                ClearFields();
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Failed to add employee.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Update button.
        /// Updates the selected employee's information.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update.");
                return;
            }

            int employeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value);

            if (EmployeeManager.UpdateEmployee(employeeId, txtFullName.Text, txtPosition.Text))
            {
                MessageBox.Show("Employee updated successfully.");
                ClearFields();
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Failed to update employee.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete button.
        /// Deactivates the selected employee (soft delete).
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to deactivate.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to deactivate this employee? They will no longer appear in the lists.", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int employeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value);

                if (EmployeeManager.DeactivateEmployee(employeeId))
                {
                    MessageBox.Show("Employee deactivated successfully.");
                    ClearFields();
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("Failed to deactivate employee.");
                }
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the DataGridView.
        /// Updates the form fields with the selected employee's data and manages the state of user-related buttons.
        /// </summary>
        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            btnCreateUser.Enabled = false;
            btnDisableUser.Enabled = false;
            btnEnableUser.Enabled = false;

            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployees.SelectedRows[0];
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPosition.Text = row.Cells["Position"].Value.ToString();

                string userStatus = row.Cells["UserStatus"].Value.ToString();

                switch (userStatus)
                {
                    case "No Account":
                        btnCreateUser.Enabled = true;
                        break;
                    case "Active":
                        btnDisableUser.Enabled = true;
                        break;
                    case "Inactive":
                        btnEnableUser.Enabled = true;
                        break;
                }
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Handles the Click event of the Create User button.
        /// Creates a new user account for the selected employee.
        /// </summary>
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            DataGridViewRow row = dgvEmployees.SelectedRows[0];
            int employeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
            string fullName = row.Cells["FullName"].Value.ToString();

            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter username:", "Create User Account", fullName.Replace(" ", "").ToLower());
            if (string.IsNullOrEmpty(username)) return;

            string password = Microsoft.VisualBasic.Interaction.InputBox("Enter password:", "Create User Account", "123");
            if (string.IsNullOrEmpty(password)) return;

            string role = Microsoft.VisualBasic.Interaction.InputBox("Enter role: (Admin, Cashier, Manager)", "Create User Account", "Cashier");
            if (string.IsNullOrEmpty(role)) return;

            try
            {
                if (UserManager.CreateUser(username, password, role, employeeId))
                {
                    MessageBox.Show("User account created successfully.");
                    LoadEmployees();
                    dgvEmployees_SelectionChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to create user account.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Disable User button.
        /// Deactivates the user account of the selected employee.
        /// </summary>
        private void btnDisableUser_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            DataGridViewRow row = dgvEmployees.SelectedRows[0];
            int employeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
            string fullName = row.Cells["FullName"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to disable the user account for {fullName}?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (UserManager.DeactivateUserByEmployeeId(employeeId))
                    {
                        MessageBox.Show("User account deactivated successfully.");
                        LoadEmployees();
                        dgvEmployees_SelectionChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Failed to deactivate user account.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Enable User button.
        /// Activates the user account of the selected employee.
        /// </summary>
        private void btnEnableUser_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            DataGridViewRow row = dgvEmployees.SelectedRows[0];
            int employeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
            string fullName = row.Cells["FullName"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to activate the user account for {fullName}?", "Confirm Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (UserManager.ActivateUserByEmployeeId(employeeId))
                    {
                        MessageBox.Show("User account activated successfully.");
                        LoadEmployees();
                        dgvEmployees_SelectionChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Failed to activate user account.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Refresh button.
        /// Reloads the list of employees.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        /// <summary>
        /// Handles the Click event of the Show Disabled button.
        /// Opens a form to view and manage disabled employees.
        /// </summary>
        private void btnShowDisabled_Click(object sender, EventArgs e)
        {
            DisabledEmployeesForm disabledForm = new DisabledEmployeesForm();
            disabledForm.ShowDialog();
        }

        /// <summary>
        /// Clears the input fields on the form.
        /// </summary>
        private void ClearFields()
        {
            txtFullName.Clear();
            txtPosition.Clear();
        }
    }
}