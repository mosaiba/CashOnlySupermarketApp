// Forms/DisabledSuppliersForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    public partial class DisabledSuppliersForm : Form
    {
        public DisabledSuppliersForm()
        {
            InitializeComponent();
        }

        private void DisabledSuppliersForm_Load(object sender, EventArgs e)
        {
            LoadDisabledSuppliers();
        }

        private void LoadDisabledSuppliers()
        {
            try
            {
                dgvDisabledSuppliers.DataSource = SupplierManager.GetAllDisabledSuppliers();
                // تسمية الأعمدة
                dgvDisabledSuppliers.Columns["SupplierID"].HeaderText = "رقم المورد";
                dgvDisabledSuppliers.Columns["SupplierName"].HeaderText = "اسم المورد";
                dgvDisabledSuppliers.Columns["Phone"].HeaderText = "رقم الهاتف";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الموردين المعطلين: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDisabledSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار المورد الذي تريد استعادته.");
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من استعادة هذا المورد؟ سيصبح متاحًا في قوائم الشراء مرة أخرى.", "تأكيد الاستعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int supplierId = Convert.ToInt32(dgvDisabledSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

                if (SupplierManager.RestoreSupplier(supplierId))
                {
                    MessageBox.Show("تم استعادة المورد بنجاح.");
                    LoadDisabledSuppliers(); // تحديث القائمة
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