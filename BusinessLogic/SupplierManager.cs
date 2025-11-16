// BusinessLogic/SupplierManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages supplier-related operations such as adding, updating, deactivating, and retrieving suppliers.
    /// </summary>
    public static class SupplierManager
    {
        /// <summary>
        /// Gets all active suppliers from the database.
        /// </summary>
        /// <returns>A DataTable containing all active suppliers.</returns>
        public static DataTable GetAllSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName, Phone FROM Suppliers WHERE IsActive = 1";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Checks if a supplier with the specified name already exists.
        /// </summary>
        /// <param name="supplierName">The name of the supplier to check.</param>
        /// <returns>True if an active supplier with the same name exists, otherwise false.</returns>
        public static bool IsSupplierExists(string supplierName)
        {
            if (string.IsNullOrEmpty(supplierName))
                return false;

            string query = "SELECT COUNT(*) FROM Suppliers WHERE SupplierName = @Name AND IsActive = 1";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", supplierName)
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
        /// Adds a new supplier to the database.
        /// </summary>
        /// <param name="supplierName">The name of the supplier.</param>
        /// <param name="phone">The phone number of the supplier.</param>
        /// <returns>True if the supplier was added successfully, otherwise false.</returns>
        public static bool AddSupplier(string supplierName, string phone)
        {
            if (string.IsNullOrEmpty(supplierName) || IsSupplierExists(supplierName))
                return false;

            string query = "INSERT INTO Suppliers (SupplierName, Phone) VALUES (@Name, @Phone)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", supplierName),
                new SqlParameter("@Phone", (object)phone ?? DBNull.Value)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Updates an existing supplier's information.
        /// </summary>
        /// <param name="supplierId">The ID of the supplier to update.</param>
        /// <param name="supplierName">The new name of the supplier.</param>
        /// <param name="phone">The new phone number of the supplier.</param>
        /// <returns>True if the supplier was updated successfully, otherwise false.</returns>
        public static bool UpdateSupplier(int supplierId, string supplierName, string phone)
        {
            if (string.IsNullOrEmpty(supplierName))
                return false;

            string query = "UPDATE Suppliers SET SupplierName = @Name, Phone = @Phone WHERE SupplierID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", supplierId),
                new SqlParameter("@Name", supplierName),
                new SqlParameter("@Phone", (object)phone ?? DBNull.Value)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Deactivates a supplier (soft delete).
        /// </summary>
        /// <param name="supplierId">The ID of the supplier to deactivate.</param>
        /// <returns>True if the supplier was deactivated successfully, otherwise false.</returns>
        public static bool DeleteSupplier(int supplierId)
        {
            string query = "UPDATE Suppliers SET IsActive = 0 WHERE SupplierID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", supplierId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Gets all disabled suppliers from the database.
        /// </summary>
        /// <returns>A DataTable containing all disabled suppliers.</returns>
        public static DataTable GetAllDisabledSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName, Phone FROM Suppliers WHERE IsActive = 0";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Restores a deactivated supplier, making them active again.
        /// </summary>
        /// <param name="supplierId">The ID of the supplier to restore.</param>
        /// <returns>True if the supplier was restored successfully, otherwise false.</returns>
        public static bool RestoreSupplier(int supplierId)
        {
            string query = "UPDATE Suppliers SET IsActive = 1 WHERE SupplierID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", supplierId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}