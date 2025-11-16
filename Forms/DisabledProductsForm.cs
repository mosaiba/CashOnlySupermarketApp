// Forms/DisabledProductsForm.cs
using System;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for viewing and managing disabled products.
    /// </summary>
    public partial class DisabledProductsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledProductsForm"/> class.
        /// </summary>
        public DisabledProductsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the DisabledProductsForm.
        /// </summary>
        private void DisabledProductsForm_Load(object sender, EventArgs e)
        {
            LoadDisabledProducts();
        }

        /// <summary>
        /// Loads the list of disabled products into the DataGridView.
        /// </summary>
        private void LoadDisabledProducts()
        {
            try
            {
                dgvDisabledProducts.DataSource = ProductManager.GetAllDisabledProductsWithDetails();
                if (dgvDisabledProducts.Columns["CategoryName"] != null) dgvDisabledProducts.Columns["CategoryName"].HeaderText = "Category";
                if (dgvDisabledProducts.Columns["SupplierName"] != null) dgvDisabledProducts.Columns["SupplierName"].HeaderText = "Supplier";
                if (dgvDisabledProducts.Columns["UnitName"] != null) dgvDisabledProducts.Columns["UnitName"].HeaderText = "Unit";
                if (dgvDisabledProducts.Columns["ProductID"] != null) dgvDisabledProducts.Columns["ProductID"].HeaderText = "Product ID";
                if (dgvDisabledProducts.Columns["ProductName"] != null) dgvDisabledProducts.Columns["ProductName"].HeaderText = "Product Name";
                if (dgvDisabledProducts.Columns["Barcode"] != null) dgvDisabledProducts.Columns["Barcode"].HeaderText = "Barcode";
                if (dgvDisabledProducts.Columns["PurchasePrice"] != null) dgvDisabledProducts.Columns["PurchasePrice"].HeaderText = "Purchase Price";
                if (dgvDisabledProducts.Columns["SalePrice"] != null) dgvDisabledProducts.Columns["SalePrice"].HeaderText = "Sale Price";
                if (dgvDisabledProducts.Columns["QuantityInStock"] != null) dgvDisabledProducts.Columns["QuantityInStock"].HeaderText = "Quantity";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading disabled products: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Restore button.
        /// </summary>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDisabledProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the product you want to restore.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to restore this product? It will be available for sale again.", "Confirm Restoration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dgvDisabledProducts.SelectedRows[0].Cells["ProductID"].Value);

                if (ProductManager.RestoreProduct(productId))
                {
                    MessageBox.Show("Product restored successfully.");
                    LoadDisabledProducts();
                }
                else
                {
                    MessageBox.Show("Failed to restore product.");
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