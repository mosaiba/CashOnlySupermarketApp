// Forms/PurchasesForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for managing purchase orders.
    /// </summary>
    public partial class PurchasesForm : Form
    {
        private DataTable orderDetailsTable;
        private DataView allProductsView;
        private bool isCalculating = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasesForm"/> class.
        /// </summary>
        public PurchasesForm()
        {
            InitializeComponent();
            SetupOrderDetailsTable();
        }

        /// <summary>
        /// Sets up the DataTable for order details and configures the DataGridView.
        /// </summary>
        private void SetupOrderDetailsTable()
        {
            orderDetailsTable = new DataTable();
            orderDetailsTable.Columns.Add("ProductID", typeof(int));
            orderDetailsTable.Columns.Add("ProductName", typeof(string));
            orderDetailsTable.Columns.Add("Quantity", typeof(int));
            orderDetailsTable.Columns.Add("UnitPrice", typeof(decimal));
            orderDetailsTable.Columns.Add("LineTotal", typeof(decimal));
            orderDetailsTable.Columns.Add("UnitName", typeof(string));

            dgvOrderDetails.DataSource = orderDetailsTable;

            dgvOrderDetails.Columns["ProductID"].HeaderText = "Product ID";
            dgvOrderDetails.Columns["ProductName"].HeaderText = "Product Name";
            dgvOrderDetails.Columns["Quantity"].HeaderText = "Quantity";
            dgvOrderDetails.Columns["UnitPrice"].HeaderText = "Unit Price";
            dgvOrderDetails.Columns["LineTotal"].HeaderText = "Total";
            dgvOrderDetails.Columns["UnitName"].HeaderText = "Unit";

            dgvOrderDetails.ReadOnly = false;
            dgvOrderDetails.Columns["ProductID"].ReadOnly = true;
            dgvOrderDetails.Columns["ProductID"].Visible = false;
            dgvOrderDetails.Columns["ProductName"].ReadOnly = true;
            dgvOrderDetails.Columns["LineTotal"].ReadOnly = true;
        }

        /// <summary>
        /// Handles the Load event of the PurchasesForm.
        /// </summary>
        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSupplier.DataSource = PurchaseManager.GetSuppliersForCombo();
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierID";

                LoadAndDisplayProducts();

                dgvAllProducts.CellDoubleClick += dgvAllProducts_CellDoubleClick;
                dgvOrderDetails.CellValueChanged += dgvOrderDetails_CellValueChanged;
                dgvOrderDetails.CellBeginEdit += (s, ev) => { dgvOrderDetails.Rows[ev.RowIndex].Selected = true; };
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        /// <summary>
        /// Loads and displays the list of available products.
        /// </summary>
        private void LoadAndDisplayProducts()
        {
            try
            {
                DataTable allProducts = ProductManager.GetAllActiveProductsForGrid();
                allProductsView = new DataView(allProducts);
                dgvAllProducts.DataSource = allProductsView;

                if (dgvAllProducts.Columns.Contains("ProductName"))
                    dgvAllProducts.Columns["ProductName"].HeaderText = "Product Name";

                if (dgvAllProducts.Columns.Contains("Barcode"))
                    dgvAllProducts.Columns["Barcode"].HeaderText = "Barcode";

                if (dgvAllProducts.Columns.Contains("QuantityInStock"))
                    dgvAllProducts.Columns["QuantityInStock"].HeaderText = "Current Stock";

                if (dgvAllProducts.Columns.Contains("ProductID"))
                    dgvAllProducts.Columns["ProductID"].Visible = false;

                if (dgvAllProducts.Columns.Contains("UnitName"))
                    dgvAllProducts.Columns["UnitName"].HeaderText = "Unit";

                txtSearchByName.Clear();
                txtSearchByBarcode.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the product list: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the search by name textbox.
        /// </summary>
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Focused)
            {
                txtSearchByBarcode.Clear();
                allProductsView.RowFilter = $"ProductName LIKE '%{txtSearchByName.Text}%'";
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the search by barcode textbox.
        /// </summary>
        private void txtSearchByBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByBarcode.Focused)
            {
                txtSearchByName.Clear();
                string filterText = txtSearchByBarcode.Text.Trim();
                allProductsView.RowFilter = $"Barcode LIKE '%{filterText}%'";

                if (filterText.Length > 8 && allProductsView.Count == 1)
                {
                    DataRowView productRowView = allProductsView[0];
                    int productID = Convert.ToInt32(productRowView["ProductID"]);
                    AddOrUpdateProductInOrder(productID, productRowView);
                    txtSearchByBarcode.Clear();
                }
            }
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the products DataGridView.
        /// </summary>
        private void dgvAllProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAllProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAllProducts.SelectedRows[0];
                int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                DataRowView productRowView = (selectedRow.DataBoundItem as DataRowView);
                AddOrUpdateProductInOrder(productID, productRowView);
                txtSearchByBarcode.Clear();
                txtSearchByName.Clear();
                txtSearchByBarcode.Focus();
            }
        }

        /// <summary>
        /// Adds a new product to the order or updates the quantity if it already exists.
        /// </summary>
        /// <param name="productID">The ID of the product to add.</param>
        /// <param name="productData">The DataRowView containing the product's data.</param>
        private void AddOrUpdateProductInOrder(int productID, DataRowView productData)
        {
            string productName = productData["ProductName"].ToString();
            string unitName = productData["UnitName"].ToString();
            decimal unitPrice = 0;
            if (productData.Row.Table.Columns.Contains("CostPrice") && productData["CostPrice"] != DBNull.Value)
            {
                unitPrice = Convert.ToDecimal(productData["CostPrice"]);
            }

            DataRow existingRow = null;
            foreach (DataRow row in orderDetailsTable.Rows)
            {
                if ((int)row["ProductID"] == productID)
                {
                    existingRow = row;
                    break;
                }
            }

            isCalculating = true;
            if (existingRow != null)
            {
                int newQuantity = (int)existingRow["Quantity"] + 1;
                existingRow["Quantity"] = newQuantity;
                existingRow["LineTotal"] = newQuantity * (decimal)existingRow["UnitPrice"];
            }
            else
            {
                int quantity = 1;
                decimal lineTotal = quantity * unitPrice;
                orderDetailsTable.Rows.Add(productID, productName, quantity, unitPrice, lineTotal, unitName);
            }

            isCalculating = false;
            UpdateTotalAmount();
        }

        /// <summary>
        /// Handles the CellValueChanged event of the order details DataGridView.
        /// Updates the line total when the quantity or unit price is changed.
        /// </summary>
        private void dgvOrderDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isCalculating || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvOrderDetails.Columns["Quantity"].Index ||
                e.ColumnIndex == dgvOrderDetails.Columns["UnitPrice"].Index)
            {
                isCalculating = true;

                DataRow row = (dgvOrderDetails.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;

                int.TryParse(row["Quantity"].ToString(), out int quantity);
                decimal.TryParse(row["UnitPrice"].ToString(), out decimal unitPrice);

                decimal lineTotal = quantity * unitPrice;
                row["LineTotal"] = lineTotal;

                isCalculating = false;

                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Updates the total amount of the order.
        /// </summary>
        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in orderDetailsTable.Rows)
            {
                total += (decimal)row["LineTotal"];
            }
            lblTotalAmountValue.Text = total.ToString("F2");
        }

        /// <summary>
        /// Handles the Click event of the Save Order button.
        /// </summary>
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            if (orderDetailsTable.Rows.Count == 0)
            {
                MessageBox.Show("Cannot save an empty order.");
                return;
            }

            int supplierId = (int)cmbSupplier.SelectedValue;
            decimal totalAmount = decimal.Parse(lblTotalAmountValue.Text);

            try
            {
                if (PurchaseManager.CreatePurchaseOrderAndReceive(supplierId, totalAmount, orderDetailsTable))
                {
                    MessageBox.Show("Purchase order saved and stock updated successfully.");
                    LoadAndDisplayProducts();
                    orderDetailsTable.Clear();
                    UpdateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the Cancel button.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the Refresh Products button.
        /// </summary>
        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            LoadAndDisplayProducts();
        }

        /// <summary>
        /// Handles the Click event of the Delete From Order button.
        /// </summary>
        private void btnDeleteFromOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete from the order.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvOrderDetails.Rows.RemoveAt(dgvOrderDetails.SelectedRows[0].Index);
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear Order button.
        /// </summary>
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            if (orderDetailsTable.Rows.Count == 0)
            {
                MessageBox.Show("The order is already empty.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to clear all items from the order?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                orderDetailsTable.Clear();
                UpdateTotalAmount();
            }
        }
    }
}