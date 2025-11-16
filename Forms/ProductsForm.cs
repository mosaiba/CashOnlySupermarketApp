// Forms/ProductsForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;
using Microsoft.Data.SqlClient;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for managing products.
    /// </summary>
    public partial class ProductsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsForm"/> class.
        /// </summary>
        public ProductsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the ProductsForm.
        /// </summary>
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadComboBoxes();
        }

        /// <summary>
        /// Loads the list of products into the DataGridView.
        /// </summary>
        private void LoadProducts()
        {
            try
            {
                dgvProducts.DataSource = ProductManager.GetAllProductsWithDetails();
                if (dgvProducts.Columns["CategoryName"] != null) dgvProducts.Columns["CategoryName"].HeaderText = "Category";
                if (dgvProducts.Columns["SupplierName"] != null) dgvProducts.Columns["SupplierName"].HeaderText = "Supplier";
                if (dgvProducts.Columns["UnitName"] != null) dgvProducts.Columns["UnitName"].HeaderText = "Unit";
                if (dgvProducts.Columns["ProductID"] != null) dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
                if (dgvProducts.Columns["ProductName"] != null) dgvProducts.Columns["ProductName"].HeaderText = "Product Name";
                if (dgvProducts.Columns["Barcode"] != null) dgvProducts.Columns["Barcode"].HeaderText = "Barcode";
                if (dgvProducts.Columns["PurchasePrice"] != null) dgvProducts.Columns["PurchasePrice"].HeaderText = "Purchase Price";
                if (dgvProducts.Columns["SalePrice"] != null) dgvProducts.Columns["SalePrice"].HeaderText = "Sale Price";
                if (dgvProducts.Columns["QuantityInStock"] != null) dgvProducts.Columns["QuantityInStock"].HeaderText = "Quantity";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading products: " + ex.Message);
            }
        }

        /// <summary>
        /// Loads the data for the category and unit ComboBoxes.
        /// </summary>
        private void LoadComboBoxes()
        {
            try
            {
                cmbCategory.DataSource = ProductManager.GetCategoriesForCombo();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";

                cmbUnit.DataSource = ProductManager.GetUnitsForCombo();
                cmbUnit.DisplayMember = "UnitName";
                cmbUnit.ValueMember = "UnitID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading lists: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the products DataGridView.
        /// </summary>
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value?.ToString() ?? "";

                cmbCategory.SelectedValue = GetIdFromDisplayMember(cmbCategory, "CategoryName", row.Cells["CategoryName"].Value.ToString());
                cmbUnit.SelectedValue = GetIdFromDisplayMember(cmbUnit, "UnitName", row.Cells["UnitName"].Value.ToString());
                numSalePrice.Value = Convert.ToDecimal(row.Cells["SalePrice"].Value);
            }
        }

        /// <summary>
        /// Gets the ID from a ComboBox based on the display text.
        /// </summary>
        /// <param name="cmb">The ComboBox to search in.</param>
        /// <param name="displayMember">The display member of the ComboBox.</param>
        /// <param name="displayText">The display text to find.</param>
        /// <returns>The ID of the item, or -1 if not found.</returns>
        private int GetIdFromDisplayMember(ComboBox cmb, string displayMember, string displayText)
        {
            foreach (DataRowView item in cmb.Items)
            {
                if (item[displayMember].ToString() == displayText)
                {
                    return Convert.ToInt32(item[cmb.ValueMember]);
                }
            }
            return -1;
        }

        /// <summary>
        /// Handles the Click event of the Add button.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || cmbCategory.SelectedValue == null || cmbUnit.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all essential fields.");
                return;
            }

            if (ProductManager.IsProductExists(txtBarcode.Text))
            {
                MessageBox.Show("Error: A product with the same name or barcode already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId, unitId;
            if (!int.TryParse(cmbCategory.SelectedValue.ToString(), out categoryId)) return;
            if (!int.TryParse(cmbUnit.SelectedValue.ToString(), out unitId)) return;

            if (ProductManager.AddProduct(txtProductName.Text, txtBarcode.Text, categoryId, unitId, numSalePrice.Value))
            {
                MessageBox.Show("Product added successfully. The current quantity is 0.");
                ClearFields();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to add product.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Update button.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the product you want to update.");
                return;
            }

            if (string.IsNullOrEmpty(txtProductName.Text) || cmbCategory.SelectedValue == null || cmbUnit.SelectedValue == null)
            {
                MessageBox.Show("Please fill in the essential fields.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            int unitId = Convert.ToInt32(cmbUnit.SelectedValue);

            try
            {
                if (ProductManager.UpdateProduct(productId, txtProductName.Text, txtBarcode.Text, categoryId, unitId, numSalePrice.Value))
                {
                    MessageBox.Show("Updated successfully.");
                    ClearFields();
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error: The barcode already exists for another product.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete button.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the product you want to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);

                if (ProductManager.DeleteProduct(productId))
                {
                    MessageBox.Show("Deleted successfully.");
                    ClearFields();
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Failed to delete product.");
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear button.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Clears the input fields on the form.
        /// </summary>
        private void ClearFields()
        {
            txtProductName.Clear();
            txtBarcode.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;
            numSalePrice.Value = 0;
        }

        /// <summary>
        /// Handles the Click event of the Refresh button.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        /// <summary>
        /// Handles the Click event of the Show Disabled button.
        /// </summary>
        private void btnShowDisabled_Click(object sender, EventArgs e)
        {
            DisabledProductsForm disabledForm = new DisabledProductsForm();
            disabledForm.ShowDialog();
        }
    }
}