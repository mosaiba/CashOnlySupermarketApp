// Forms/DisabledProductsForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    public partial class DisabledProductsForm : Form
    {
        public DisabledProductsForm()
        {
            InitializeComponent();
        }

        private void DisabledProductsForm_Load(object sender, EventArgs e)
        {
            LoadDisabledProducts();
        }

        // Fixing the CS0103 error by replacing 'dgvProducts' with 'dgvDisabledProducts' in the relevant lines.
        // The error occurs because 'dgvProducts' is not defined in the current context, but 'dgvDisabledProducts' is.

        private void LoadDisabledProducts()
        {
            try
            {
                dgvDisabledProducts.DataSource = ProductManager.GetAllDisabledProductsWithDetails();
                if (dgvDisabledProducts.Columns["CategoryName"] != null) dgvDisabledProducts.Columns["CategoryName"].HeaderText = "الفئة";
                if (dgvDisabledProducts.Columns["SupplierName"] != null) dgvDisabledProducts.Columns["SupplierName"].HeaderText = "المورد";
                if (dgvDisabledProducts.Columns["UnitName"] != null) dgvDisabledProducts.Columns["UnitName"].HeaderText = "الوحدة";
                if (dgvDisabledProducts.Columns["ProductID"] != null) dgvDisabledProducts.Columns["ProductID"].HeaderText = "رقم المنتج";
                if (dgvDisabledProducts.Columns["ProductName"] != null) dgvDisabledProducts.Columns["ProductName"].HeaderText = "اسم المنتج";
                if (dgvDisabledProducts.Columns["Barcode"] != null) dgvDisabledProducts.Columns["Barcode"].HeaderText = "الباركود";
                if (dgvDisabledProducts.Columns["PurchasePrice"] != null) dgvDisabledProducts.Columns["PurchasePrice"].HeaderText = "سعر الشراء";
                if (dgvDisabledProducts.Columns["SalePrice"] != null) dgvDisabledProducts.Columns["SalePrice"].HeaderText = "سعر البيع";
                if (dgvDisabledProducts.Columns["QuantityInStock"] != null) dgvDisabledProducts.Columns["QuantityInStock"].HeaderText = "الكمية";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المنتجات المعطلة: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDisabledProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار المنتج الذي تريد استعادته.");
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من استعادة هذا المنتج؟ سيصبح متاحًا للبيع مرة أخرى.", "تأكيد الاستعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dgvDisabledProducts.SelectedRows[0].Cells["ProductID"].Value);

                if (ProductManager.RestoreProduct(productId))
                {
                    MessageBox.Show("تم استعادة المنتج بنجاح.");
                    LoadDisabledProducts(); // تحديث القائمة
                }
                else
                {
                    MessageBox.Show("فشلت عملية الاستعادة.");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}