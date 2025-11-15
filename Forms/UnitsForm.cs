// Forms/UnitsForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    public partial class UnitsForm : Form
    {
        public UnitsForm()
        {
            // هذا السطر يستدعي الكود الذي وضعناه في ملف Designer.cs
            InitializeComponent();
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            LoadUnits();
        }

        private void LoadUnits()
        {
            try
            {
                dgvUnits.DataSource = UnitManager.GetAllUnits();
                dgvUnits.Columns["UnitID"].HeaderText = "رقم الوحدة";
                dgvUnits.Columns["UnitName"].HeaderText = "أسم الوحدة";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الوحدة.");
                return;
            }

            if (UnitManager.IsUnitExists(txtUnitName.Text))
            {
                MessageBox.Show("خطأ: هذه الوحدة موجودة بالفعل.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UnitManager.AddUnit(txtUnitName.Text))
            {
                MessageBox.Show("تمت الإضافة بنجاح.");
                txtUnitName.Clear();
                LoadUnits();
            }
            else
            {
                MessageBox.Show("فشلت عملية الإضافة.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار الوحدة التي تريد تعديلها.");
                return;
            }

            if (string.IsNullOrEmpty(txtUnitName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الوحدة الجديد.");
                return;
            }

            int unitId = Convert.ToInt32(dgvUnits.SelectedRows[0].Cells["UnitID"].Value);
            string newName = txtUnitName.Text;
            string currentName = dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString();

            if (newName == currentName)
            {
                MessageBox.Show("لم يتم إجراء أي تغيير.");
                return;
            }

            if (UnitManager.IsUnitExists(newName))
            {
                MessageBox.Show("خطأ: اسم الوحدة هذا مستخدم بالفعل.", "تكرار في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UnitManager.UpdateUnit(unitId, newName))
            {
                MessageBox.Show("تم التعديل بنجاح.");
                txtUnitName.Clear();
                LoadUnits();
            }
            else
            {
                MessageBox.Show("فشلت عملية التعديل.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار الوحدة التي تريد حذفها.");
                return;
            }
            int unitId = Convert.ToInt32(dgvUnits.SelectedRows[0].Cells["UnitID"].Value);

            if (UnitManager.IsUnitUsed(unitId))
            {
                MessageBox.Show("لا يمكن حذف هذه الفئة لأنها مرتبطة بمنتجات واحدة أو أكثر. قم بنقل أو حذف المنتجات أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // إيقاف عملية الحذف
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (UnitManager.DeleteUnit(unitId))
                {
                    MessageBox.Show("تم الحذف بنجاح.");
                    LoadUnits();
                }
                else
                {
                    MessageBox.Show("فشلت عملية الحذف.");
                }
            }
        }

        private void dgvUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count > 0)
            {
                txtUnitName.Text = dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUnits();
        }
    }
}