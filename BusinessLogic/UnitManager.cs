// BusinessLogic/UnitManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages unit-related operations such as adding, updating, deleting, and retrieving units.
    /// </summary>
    public static class UnitManager
    {
        /// <summary>
        /// Gets all units from the database.
        /// </summary>
        /// <returns>A DataTable containing all units.</returns>
        public static DataTable GetAllUnits()
        {
            string query = "SELECT UnitID, UnitName FROM Units";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Checks if a unit with the specified name already exists.
        /// </summary>
        /// <param name="unitName">The name of the unit to check.</param>
        /// <returns>True if a unit with the same name exists, otherwise false.</returns>
        public static bool IsUnitExists(string unitName)
        {
            if (string.IsNullOrEmpty(unitName))
                return false;

            string query = "SELECT COUNT(*) FROM Units WHERE UnitName = @Name";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", unitName)
            };

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Adds a new unit to the database.
        /// </summary>
        /// <param name="unitName">The name of the unit to add.</param>
        /// <returns>True if the unit was added successfully, otherwise false.</returns>
        public static bool AddUnit(string unitName)
        {
            if (string.IsNullOrEmpty(unitName) || IsUnitExists(unitName))
                return false;

            string query = "INSERT INTO Units (UnitName) VALUES (@Name)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", unitName)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Updates an existing unit's information.
        /// </summary>
        /// <param name="unitId">The ID of the unit to update.</param>
        /// <param name="unitName">The new name of the unit.</param>
        /// <returns>True if the unit was updated successfully, otherwise false.</returns>
        public static bool UpdateUnit(int unitId, string unitName)
        {
            if (string.IsNullOrEmpty(unitName))
                return false;

            string query = "UPDATE Units SET UnitName = @Name WHERE UnitID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", unitId),
                new SqlParameter("@Name", unitName)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Deletes a unit from the database.
        /// </summary>
        /// <param name="unitId">The ID of the unit to delete.</param>
        /// <returns>True if the unit was deleted successfully, otherwise false.</returns>
        public static bool DeleteUnit(int unitId)
        {
            string query = "DELETE FROM Units WHERE UnitID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", unitId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Checks if a unit is being used by any products.
        /// </summary>
        /// <param name="unitId">The ID of the unit to check.</param>
        /// <returns>True if the unit is used by at least one product, otherwise false.</returns>
        public static bool IsUnitUsed(int unitId)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE UnitID = @UnitID";
            SqlParameter[] parameters = {
                new SqlParameter("@UnitID", unitId)
            };

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}