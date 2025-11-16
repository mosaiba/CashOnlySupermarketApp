// Forms/UnitsForm.cs
using System;
using System.Windows.Forms;
using CashOnlySupermarketApp.BusinessLogic;

namespace CashOnlySupermarketApp.Forms
{
    /// <summary>
    /// Form for managing measurement units.
    /// </summary>
    public partial class UnitsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitsForm"/> class.
        /// </summary>
        public UnitsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the UnitsForm.
        /// </summary>
        private void UnitsForm_Load(object sender, EventArgs e)
        {
            LoadUnits();
        }

        /// <summary>
        /// Loads the list of units into the DataGridView.
        /// </summary>
        private void LoadUnits()
        {
            try
            {
                dgvUnits.DataSource = UnitManager.GetAllUnits();
                dgvUnits.Columns["UnitID"].HeaderText = "Unit ID";
                dgvUnits.Columns["UnitName"].HeaderText = "Unit Name";
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
            if (string.IsNullOrEmpty(txtUnitName.Text))
            {
                MessageBox.Show("Please enter the unit name.");
                return;
            }

            if (UnitManager.IsUnitExists(txtUnitName.Text))
            {
                MessageBox.Show("Error: This unit already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UnitManager.AddUnit(txtUnitName.Text))
            {
                MessageBox.Show("Added successfully.");
                txtUnitName.Clear();
                LoadUnits();
            }
            else
            {
                MessageBox.Show("Failed to add unit.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Update button.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the unit you want to update.");
                return;
            }

            if (string.IsNullOrEmpty(txtUnitName.Text))
            {
                MessageBox.Show("Please enter the new unit name.");
                return;
            }

            int unitId = Convert.ToInt32(dgvUnits.SelectedRows[0].Cells["UnitID"].Value);
            string newName = txtUnitName.Text;
            string currentName = dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString();

            if (newName == currentName)
            {
                MessageBox.Show("No changes were made.");
                return;
            }

            if (UnitManager.IsUnitExists(newName))
            {
                MessageBox.Show("Error: This unit name is already in use.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UnitManager.UpdateUnit(unitId, newName))
            {
                MessageBox.Show("Updated successfully.");
                txtUnitName.Clear();
                LoadUnits();
            }
            else
            {
                MessageBox.Show("Failed to update unit.");
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete button.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the unit you want to delete.");
                return;
            }
            int unitId = Convert.ToInt32(dgvUnits.SelectedRows[0].Cells["UnitID"].Value);

            if (UnitManager.IsUnitUsed(unitId))
            {
                MessageBox.Show("This unit cannot be deleted because it is associated with one or more products. Please move or delete the products first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this unit?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (UnitManager.DeleteUnit(unitId))
                {
                    MessageBox.Show("Deleted successfully.");
                    LoadUnits();
                }
                else
                {
                    MessageBox.Show("Failed to delete unit.");
                }
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the units DataGridView.
        /// </summary>
        private void dgvUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count > 0)
            {
                txtUnitName.Text = dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the Refresh button.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUnits();
        }
    }
}