// Forms/POSForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Represents the Point of Sale (POS) form where sales are made.
    /// </summary>
    public partial class POSForm : Form
    {
        private DataTable saleDetailsTable;
        private DataView allProductsView;
        private bool isCalculating = false;
        private int currentEmployeeId = CurrentUserManager.EmployeeID;

        /// <summary>
        /// Initializes a new instance of the <see cref="POSForm"/> class.
        /// </summary>
        public POSForm()
        {
            InitializeComponent();
            SetupSaleDetailsTable();
        }

        /// <summary>
        /// Sets up the DataTable for sale details and configures the DataGridView.
        /// </summary>
        private void SetupSaleDetailsTable()
        {
            saleDetailsTable = new DataTable();
            saleDetailsTable.Columns.Add("ProductID", typeof(int));
            saleDetailsTable.Columns.Add("ProductName", typeof(string));
            saleDetailsTable.Columns.Add("Quantity", typeof(int));
            saleDetailsTable.Columns.Add("UnitPrice", typeof(decimal));
            saleDetailsTable.Columns.Add("LineTotal", typeof(decimal));

            dgvSaleDetails.DataSource = saleDetailsTable;

            dgvSaleDetails.Columns["ProductID"].HeaderText = "Product ID";
            dgvSaleDetails.Columns["ProductName"].HeaderText = "Product";
            dgvSaleDetails.Columns["Quantity"].HeaderText = "Quantity";
            dgvSaleDetails.Columns["UnitPrice"].HeaderText = "Unit Price";
            dgvSaleDetails.Columns["LineTotal"].HeaderText = "Total";

            dgvSaleDetails.ReadOnly = false;
            dgvSaleDetails.Columns["ProductID"].ReadOnly = true;
            dgvSaleDetails.Columns["ProductName"].ReadOnly = true;
            dgvSaleDetails.Columns["UnitPrice"].ReadOnly = true;
            dgvSaleDetails.Columns["LineTotal"].ReadOnly = true;
        }

        /// <summary>
        /// Handles the Load event of the POSForm.
        /// </summary>
        private void POSForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAndDisplayProducts();
                dgvAllProducts.CellDoubleClick += dgvAllProducts_CellDoubleClick;
                dgvSaleDetails.CellValueChanged += dgvSaleDetails_CellValueChanged;
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
                DataTable allProducts = SaleManager.GetProductsForPOS();
                allProductsView = new DataView(allProducts);
                dgvAllProducts.DataSource = allProductsView;

                if (dgvAllProducts.Columns.Contains("ProductID"))
                    dgvAllProducts.Columns["ProductID"].Visible = false;

                if (dgvAllProducts.Columns.Contains("ProductName"))
                    dgvAllProducts.Columns["ProductName"].HeaderText = "Product";

                if (dgvAllProducts.Columns.Contains("Barcode"))
                    dgvAllProducts.Columns["Barcode"].HeaderText = "Barcode";

                if (dgvAllProducts.Columns.Contains("QuantityInStock"))
                    dgvAllProducts.Columns["QuantityInStock"].HeaderText = "Stock";

                if (dgvAllProducts.Columns.Contains("SalePrice"))
                    dgvAllProducts.Columns["SalePrice"].HeaderText = "Price";

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
                    AddOrUpdateProductInSale(productID, productRowView);
                    txtSearchByBarcode.Clear();
                }
            }
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the products DataGridView.
        /// </summary>
        private void dgvAllProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvAllProducts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvAllProducts.SelectedRows[0];
                    int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                    DataRowView productRowView = (selectedRow.DataBoundItem as DataRowView);
                    AddOrUpdateProductInSale(productID, productRowView);
                    txtSearchByBarcode.Clear();
                    txtSearchByName.Clear();
                    txtSearchByBarcode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adds a new product to the sale or updates the quantity if it already exists.
        /// </summary>
        /// <param name="productID">The ID of the product to add.</param>
        /// <param name="productData">The DataRowView containing the product's data.</param>
        private void AddOrUpdateProductInSale(int productID, DataRowView productData)
        {
            string productName = productData["ProductName"].ToString();
            decimal unitPrice = Convert.ToDecimal(productData["SalePrice"]);
            int stockQuantity = Convert.ToInt32(productData["QuantityInStock"]);

            if (stockQuantity <= 0)
            {
                MessageBox.Show($"Product '{productName}' is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow existingRow = null;
            foreach (DataRow row in saleDetailsTable.Rows)
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
                int currentQuantity = (int)existingRow["Quantity"];
                if (currentQuantity < stockQuantity)
                {
                    existingRow["Quantity"] = currentQuantity + 1;
                    existingRow["LineTotal"] = (int)existingRow["Quantity"] * (decimal)existingRow["UnitPrice"];
                }
                else
                {
                    MessageBox.Show($"Cannot add more of '{productName}'. The available quantity in stock is {stockQuantity}.", "Quantity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                saleDetailsTable.Rows.Add(productID, productName, 1, unitPrice, unitPrice);
            }

            isCalculating = false;
            UpdateTotalAmount();
        }

        /// <summary>
        /// Handles the CellValueChanged event of the sale details DataGridView.
        /// Updates the line total when the quantity is changed and validates against stock.
        /// </summary>
        private void dgvSaleDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isCalculating || e.RowIndex < 0) return;

            if (dgvSaleDetails.Columns["Quantity"] != null && e.ColumnIndex == dgvSaleDetails.Columns["Quantity"].Index)
            {
                isCalculating = true;

                DataGridViewRow row = dgvSaleDetails.Rows[e.RowIndex];

                if (row.Cells["ProductID"].Value == null || row.Cells["ProductID"].Value == DBNull.Value)
                {
                    isCalculating = false;
                    return;
                }
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);

                int stockQuantity = 0;
                foreach (DataRowView prod in allProductsView)
                {
                    if (Convert.ToInt32(prod["ProductID"]) == productId)
                    {
                        stockQuantity = Convert.ToInt32(prod["QuantityInStock"]);
                        break;
                    }
                }

                int newQuantity = 0;
                if (row.Cells["Quantity"].Value != null && row.Cells["Quantity"].Value != DBNull.Value)
                {
                    int.TryParse(row.Cells["Quantity"].Value.ToString(), out newQuantity);
                }

                if (newQuantity <= 0)
                {
                    dgvSaleDetails.Rows.RemoveAt(e.RowIndex);
                    isCalculating = false;
                    UpdateTotalAmount();
                    return;
                }

                if (newQuantity > stockQuantity)
                {
                    MessageBox.Show($"The entered quantity ({newQuantity}) exceeds the available stock ({stockQuantity}).", "Quantity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["Quantity"].Value = stockQuantity;
                    newQuantity = stockQuantity;
                }

                decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                decimal lineTotal = newQuantity * unitPrice;
                row.Cells["LineTotal"].Value = lineTotal;

                isCalculating = false;
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Updates the total amount of the sale.
        /// </summary>
        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in saleDetailsTable.Rows)
            {
                total += (decimal)row["LineTotal"];
            }
            lblTotalAmountValue.Text = total.ToString("F2");
        }

        /// <summary>
        /// Handles the Click event of the Delete From Sale button.
        /// </summary>
        private void btnDeleteFromSale_Click(object sender, EventArgs e)
        {
            if (dgvSaleDetails.SelectedRows.Count == 0) return;
            dgvSaleDetails.Rows.RemoveAt(dgvSaleDetails.SelectedRows[0].Index);
            UpdateTotalAmount();
        }

        /// <summary>
        /// Handles the Click event of the Clear Sale button.
        /// </summary>
        private void btnClearSale_Click(object sender, EventArgs e)
        {
            if (saleDetailsTable.Rows.Count == 0) return;
            if (MessageBox.Show("Are you sure you want to clear the cart?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saleDetailsTable.Clear();
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Handles the Click event of the Finalize Sale button.
        /// </summary>
        private void btnFinalizeSale_Click(object sender, EventArgs e)
        {
            if (saleDetailsTable.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty.");
                return;
            }
            decimal totalAmount = decimal.Parse(lblTotalAmountValue.Text);
            try
            {
                if (SaleManager.CreateSaleAndDecreaseStock(currentEmployeeId, totalAmount, saleDetailsTable))
                {
                    MessageBox.Show("Sale completed successfully.");
                    saleDetailsTable.Clear();
                    UpdateTotalAmount();
                    LoadAndDisplayProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the Refresh Products button.
        /// </summary>
        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            LoadAndDisplayProducts();
        }

        /// <summary>
        /// Handles the Click event of the Cancel button.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}