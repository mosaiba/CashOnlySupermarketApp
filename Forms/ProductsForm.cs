// Forms/ProductsForm.cs (نسخة مصححة)
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;
using Microsoft.Data.SqlClient;

namespace CashOnlySupermarketApp.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadComboBoxes();
        }

        private void LoadProducts()
        {
            try
            {
                dgvProducts.DataSource = ProductManager.GetAllProductsWithDetails();
                if (dgvProducts.Columns["CategoryName"] != null) dgvProducts.Columns["CategoryName"].HeaderText = "الفئة";
                if (dgvProducts.Columns["SupplierName"] != null) dgvProducts.Columns["SupplierName"].HeaderText = "المورد";
                if (dgvProducts.Columns["UnitName"] != null) dgvProducts.Columns["UnitName"].HeaderText = "الوحدة";
                if (dgvProducts.Columns["ProductID"] != null) dgvProducts.Columns["ProductID"].HeaderText = "رقم المنتج";
                if (dgvProducts.Columns["ProductName"] != null) dgvProducts.Columns["ProductName"].HeaderText = "اسم المنتج";
                if (dgvProducts.Columns["Barcode"] != null) dgvProducts.Columns["Barcode"].HeaderText = "الباركود";
                if (dgvProducts.Columns["PurchasePrice"] != null) dgvProducts.Columns["PurchasePrice"].HeaderText = "سعر الشراء";
                if (dgvProducts.Columns["SalePrice"] != null) dgvProducts.Columns["SalePrice"].HeaderText = "سعر البيع";
                if (dgvProducts.Columns["QuantityInStock"] != null) dgvProducts.Columns["QuantityInStock"].HeaderText = "الكمية";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المنتجات: " + ex.Message);
            }
        }

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
                MessageBox.Show("حدث خطأ أثناء تحميل القوائم: " + ex.Message);
            }
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || cmbCategory.SelectedValue == null || cmbUnit.SelectedValue == null)
            {
                MessageBox.Show("يرجى ملء جميع الحقول الأساسية.");
                return;
            }

            if (ProductManager.IsProductExists(txtBarcode.Text))
            {
                MessageBox.Show("خطأ: منتج بنفس الاسم أو الباركود موجود بالفعل.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId, unitId;
            if (!int.TryParse(cmbCategory.SelectedValue.ToString(), out categoryId)) return;
            if (!int.TryParse(cmbUnit.SelectedValue.ToString(), out unitId)) return;

            if (ProductManager.AddProduct(txtProductName.Text, txtBarcode.Text, categoryId, unitId, numSalePrice.Value))
            {
                MessageBox.Show("تمت إضافة المنتج بنجاح. الكمية الحالية هي 0.");
                ClearFields();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("فشلت عملية الإضافة.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار منتج
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار المنتج الذي تريد تعديله.");
                return;
            }

            // 2. التحقق من الحقول الأساسية
            if (string.IsNullOrEmpty(txtProductName.Text) || cmbCategory.SelectedValue == null || cmbUnit.SelectedValue == null)
            {
                MessageBox.Show("يرجى ملء الحقول الأساسية.");
                return;
            }

            // 3. جلب البيانات
            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            int unitId = Convert.ToInt32(cmbUnit.SelectedValue);

            // 4. شبكة الأمان البسيطة
            try
            {
                // محاولة التعديل مباشرة
                if (ProductManager.UpdateProduct(productId, txtProductName.Text, txtBarcode.Text, categoryId, unitId, numSalePrice.Value))
                {
                    MessageBox.Show("تم التعديل بنجاح.");
                    ClearFields();
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("فشلت عملية التعديل.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("خطأ: الباركود موجود مسبقًا لمنتج آخر.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // لأي خطأ آخر غير متوقع
                MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار المنتج الذي تريد حذفه.");
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);

                if (ProductManager.DeleteProduct(productId))
                {
                    MessageBox.Show("تم الحذف بنجاح.");
                    ClearFields();
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtBarcode.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;
            numSalePrice.Value = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // Forms/ProductsForm.cs
        private void btnShowDisabled_Click(object sender, EventArgs e)
        {
            DisabledProductsForm disabledForm = new DisabledProductsForm();
            disabledForm.ShowDialog(); // ShowDialog() يجعل النافذة تظهر كنافذة منبثقة
        }
    }
}