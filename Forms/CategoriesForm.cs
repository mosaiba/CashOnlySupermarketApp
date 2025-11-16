// Forms/CategoriesForm.cs
using System;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;
using Microsoft.Data.SqlClient;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for managing product categories.
    /// </summary>
    public partial class CategoriesForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesForm"/> class.
        /// </summary>
        public CategoriesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the CategoriesForm.
        /// </summary>
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        /// <summary>
        /// Loads the list of categories into the DataGridView.
        /// </summary>
        private void LoadCategories()
        {
            try
            {
                dgvCategories.DataSource = CategoryManager.GetAllCategories();
                dgvCategories.Columns["CategoryID"].HeaderText = "Category ID";
                dgvCategories.Columns["CategoryName"].HeaderText = "Category Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Add button.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter the category name.");
                return;
            }

            try
            {
                if (CategoryManager.AddCategory(txtCategoryName.Text))
                {
                    MessageBox.Show("Added successfully.");
                    txtCategoryName.Clear();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to add category.");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error: This category already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the Update button.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the category you want to update.");
                return;
            }

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter the new category name.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
            string newName = txtCategoryName.Text;
            string currentName = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();

            if (newName == currentName)
            {
                MessageBox.Show("No changes were made.");
                return;
            }

            if (CategoryManager.IsCategoryExists(newName))
            {
                MessageBox.Show("Error: This category name is already in use.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CategoryManager.UpdateCategory(categoryId, newName))
            {
                MessageBox.Show("Updated successfully.");
                txtCategoryName.Clear();
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Failed to update category for an unexpected reason.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete button.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the category you want to delete.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);

            if (CategoryManager.IsCategoryUsed(categoryId))
            {
                MessageBox.Show("This category cannot be deleted because it is associated with one or more products. Please move or delete the products first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (CategoryManager.DeleteCategory(categoryId))
                {
                    MessageBox.Show("Deleted successfully.");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to delete category.");
                }
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the categories DataGridView.
        /// </summary>
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                txtCategoryName.Text = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear button.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
        }

        /// <summary>
        /// Handles the Click event of the Refresh button.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}