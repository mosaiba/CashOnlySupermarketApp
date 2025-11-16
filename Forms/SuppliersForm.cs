// Forms/SuppliersForm.cs
using System;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for managing suppliers.
    /// </summary>
    public partial class SuppliersForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuppliersForm"/> class.
        /// </summary>
        public SuppliersForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the SuppliersForm.
        /// </summary>
        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        /// <summary>
        /// Loads the list of active suppliers into the DataGridView.
        /// </summary>
        private void LoadSuppliers()
        {
            try
            {
                dgvSuppliers.DataSource = SupplierManager.GetAllSuppliers();
                dgvSuppliers.Columns["SupplierID"].HeaderText = "Supplier ID";
                dgvSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
                dgvSuppliers.Columns["Phone"].HeaderText = "Phone Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Add button.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter the supplier name.");
                return;
            }

            if (SupplierManager.IsSupplierExists(txtSupplierName.Text))
            {
                MessageBox.Show("Error: This supplier already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SupplierManager.AddSupplier(txtSupplierName.Text, txtPhone.Text))
            {
                MessageBox.Show("Added successfully.");
                txtSupplierName.Clear();
                txtPhone.Clear();
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to add supplier.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Update button.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the supplier you want to update.");
                return;
            }

            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter the new supplier name.");
                return;
            }

            int supplierId = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);
            string newName = txtSupplierName.Text;
            string currentName = dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString();

            if (newName == currentName && txtPhone.Text == dgvSuppliers.SelectedRows[0].Cells["Phone"].Value?.ToString())
            {
                MessageBox.Show("No changes were made.");
                return;
            }

            if (SupplierManager.UpdateSupplier(supplierId, newName, txtPhone.Text))
            {
                MessageBox.Show("Updated successfully.");
                txtSupplierName.Clear();
                txtPhone.Clear();
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to update supplier.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete button.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the supplier you want to deactivate.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to deactivate this supplier? It will no longer appear in purchase lists.", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int supplierId = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

                if (SupplierManager.DeleteSupplier(supplierId))
                {
                    MessageBox.Show("Supplier deactivated successfully.");
                    LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("Failed to deactivate supplier.");
                }
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the suppliers DataGridView.
        /// </summary>
        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                txtSupplierName.Text = dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString();
                txtPhone.Text = dgvSuppliers.SelectedRows[0].Cells["Phone"].Value?.ToString() ?? "";
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear button.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();
            txtPhone.Clear();
        }

        /// <summary>
        /// Handles the Click event of the Refresh button.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        /// <summary>
        /// Handles the Click event of the Show Disabled button.
        /// </summary>
        private void btnShowDisabled_Click(object sender, EventArgs e)
        {
            DisabledSuppliersForm disabledForm = new DisabledSuppliersForm();
            disabledForm.ShowDialog();
        }
    }
}