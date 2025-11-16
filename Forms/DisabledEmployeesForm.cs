// Forms/DisabledEmployeesForm.cs
using System;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for viewing and managing disabled employees.
    /// </summary>
    public partial class DisabledEmployeesForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledEmployeesForm"/> class.
        /// </summary>
        public DisabledEmployeesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the DisabledEmployeesForm.
        /// </summary>
        private void DisabledEmployeesForm_Load(object sender, EventArgs e)
        {
            LoadDisabledEmployees();
        }

        /// <summary>
        /// Loads the list of disabled employees into the DataGridView.
        /// </summary>
        private void LoadDisabledEmployees()
        {
            try
            {
                dgvDisabledEmployees.DataSource = EmployeeManager.GetAllDisabledEmployees();
                dgvDisabledEmployees.Columns["EmployeeID"].HeaderText = "ID";
                dgvDisabledEmployees.Columns["FullName"].HeaderText = "Full Name";
                dgvDisabledEmployees.Columns["Position"].HeaderText = "Position";
                dgvDisabledEmployees.Columns["HasUser"].HeaderText = "Has User Account";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading disabled employees: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Activate button.
        /// </summary>
        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dgvDisabledEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the employee you want to restore.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to restore this employee? They will become active in the system again.", "Confirm Restoration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int employeeId = Convert.ToInt32(dgvDisabledEmployees.SelectedRows[0].Cells["EmployeeID"].Value);

                if (EmployeeManager.ActivateEmployee(employeeId))
                {
                    MessageBox.Show("Employee restored successfully.");
                    LoadDisabledEmployees();
                }
                else
                {
                    MessageBox.Show("Failed to restore employee.");
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Close button.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}