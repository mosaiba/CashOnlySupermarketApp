// Forms/CategoriesForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;
using Microsoft.Data.SqlClient;

namespace CashOnlySupermarketApp.Forms
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                dgvCategories.DataSource = CategoryManager.GetAllCategories();
                dgvCategories.Columns["CategoryID"].HeaderText = "رقم الفئة";
                dgvCategories.Columns["CategoryName"].HeaderText = "اسم الفئة";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }


        // Forms/CategoriesForm.cs
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الفئة.");
                return;
            }

            try
            {
                if (CategoryManager.AddCategory(txtCategoryName.Text))
                {
                    MessageBox.Show("تمت الإضافة بنجاح.");
                    txtCategoryName.Clear();
                    LoadCategories(); // تحديث القائمة
                }
                else
                {
                    MessageBox.Show("فشلت عملية الإضافة.");
                }
            }
            catch (SqlException ex)
            {
                 MessageBox.Show("خطأ: هذه الفئة موجودة بالفعل.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message, "خطأ عام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار الفئة التي تريد تعديلها.");
                return;
            }

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الفئة الجديد.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
            string newName = txtCategoryName.Text;
            string currentName = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();

            // إذا لم يتغير الاسم، لا داعي للتعديل
            if (newName == currentName)
            {
                MessageBox.Show("لم يتم إجراء أي تغيير.");
                return;
            }

            // التحقق إذا كان الاسم الجديد مستخدمًا من قبل فئة أخرى
            if (CategoryManager.IsCategoryExists(newName))
            {
                MessageBox.Show("خطأ: اسم الفئة هذا مستخدم بالفعل.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // إيقاف العملية
            }

            // إذا كان الاسم الجديد متاحًا، تابع التعديل
            if (CategoryManager.UpdateCategory(categoryId, newName))
            {
                MessageBox.Show("تم التعديل بنجاح.");
                txtCategoryName.Clear();
                LoadCategories(); // تحديث القائمة
            }
            else
            {
                MessageBox.Show("فشلت عملية التعديل لسبب غير متوقع.");
            }
        }

        // Forms/CategoriesForm.cs
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار الفئة التي تريد حذفها.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);

            // --- التحقق الذكي قبل الحذف ---
            if (CategoryManager.IsCategoryUsed(categoryId))
            {
                MessageBox.Show("لا يمكن حذف هذه الفئة لأنها مرتبطة بمنتجات واحدة أو أكثر. قم بنقل أو حذف المنتجات أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // إيقاف عملية الحذف
            }

            // إذا لم تكن الفئة مستخدمة، نستمر في عملية الحذف
            DialogResult result = MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (CategoryManager.DeleteCategory(categoryId))
                {
                    MessageBox.Show("تم الحذف بنجاح.");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف.");
                }
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            // عند اختيار صف، يتم عرض اسم الفئة في مربع النص لتسهيل التعديل
            if (dgvCategories.SelectedRows.Count > 0)
            {
                txtCategoryName.Text = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}