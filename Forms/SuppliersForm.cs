// Forms/SuppliersForm.cs (نسخة محدثة)
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            try
            {
                dgvSuppliers.DataSource = SupplierManager.GetAllSuppliers();
                dgvSuppliers.Columns["SupplierID"].HeaderText = "رقم المورد";
                dgvSuppliers.Columns["SupplierName"].HeaderText = "اسم المورد";
                dgvSuppliers.Columns["Phone"].HeaderText = "رقم الهاتف";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المورد.");
                return;
            }

            if (SupplierManager.IsSupplierExists(txtSupplierName.Text))
            {
                MessageBox.Show("خطأ: هذا المورد موجود بالفعل.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SupplierManager.AddSupplier(txtSupplierName.Text, txtPhone.Text))
            {
                MessageBox.Show("تمت الإضافة بنجاح.");
                txtSupplierName.Clear();
                txtPhone.Clear();
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("فشلت عملية الإضافة.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار المورد الذي تريد تعديله.");
                return;
            }

            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المورد الجديد.");
                return;
            }

            int supplierId = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);
            string newName = txtSupplierName.Text;
            string currentName = dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString();

            if (newName == currentName && txtPhone.Text == dgvSuppliers.SelectedRows[0].Cells["Phone"].Value?.ToString())
            {
                MessageBox.Show("لم يتم إجراء أي تغيير.");
                return;
            }

            if (SupplierManager.UpdateSupplier(supplierId, newName, txtPhone.Text))
            {
                MessageBox.Show("تم التعديل بنجاح.");
                txtSupplierName.Clear();
                txtPhone.Clear();
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("فشلت عملية التعديل.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار المورد الذي تريد تعطيله.");
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من تعطيل هذا المورد؟ لن يظهر في قوائم الشراء بعد الآن.", "تأكيد التعطيل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int supplierId = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

                if (SupplierManager.DeleteSupplier(supplierId))
                {
                    MessageBox.Show("تم تعطيل المورد بنجاح.");
                    LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("فشلت عملية التعطيل.");
                }
            }
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                txtSupplierName.Text = dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString();
                txtPhone.Text = dgvSuppliers.SelectedRows[0].Cells["Phone"].Value?.ToString() ?? "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();
            txtPhone.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        // Forms/SuppliersForm.cs
        private void btnShowDisabled_Click(object sender, EventArgs e)
        {
            DisabledSuppliersForm disabledForm = new DisabledSuppliersForm();
            disabledForm.ShowDialog(); // ShowDialog() يجعل النافذة تظهر كنافذة منبثقة
        }
    }
}