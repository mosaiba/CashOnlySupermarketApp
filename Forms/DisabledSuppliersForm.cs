// Forms/DisabledSuppliersForm.cs
using System;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for viewing and managing disabled suppliers.
    /// </summary>
    public partial class DisabledSuppliersForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledSuppliersForm"/> class.
        /// </summary>
        public DisabledSuppliersForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the DisabledSuppliersForm.
        /// </summary>
        private void DisabledSuppliersForm_Load(object sender, EventArgs e)
        {
            LoadDisabledSuppliers();
        }

        /// <summary>
        /// Loads the list of disabled suppliers into the DataGridView.
        /// </summary>
        private void LoadDisabledSuppliers()
        {
            try
            {
                dgvDisabledSuppliers.DataSource = SupplierManager.GetAllDisabledSuppliers();
                dgvDisabledSuppliers.Columns["SupplierID"].HeaderText = "Supplier ID";
                dgvDisabledSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
                dgvDisabledSuppliers.Columns["Phone"].HeaderText = "Phone Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading disabled suppliers: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Restore button.
        /// </summary>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDisabledSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the supplier you want to restore.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to restore this supplier? It will be available in purchase lists again.", "Confirm Restoration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int supplierId = Convert.ToInt32(dgvDisabledSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

                if (SupplierManager.RestoreSupplier(supplierId))
                {
                    MessageBox.Show("Supplier restored successfully.");
                    LoadDisabledSuppliers();
                }
                else
                {
                    MessageBox.Show("Failed to restore supplier.");
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