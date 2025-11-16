// BusinessLogic/CategoryManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages category-related operations such as adding, updating, deleting, and retrieving categories.
    /// </summary>
    public static class CategoryManager
    {
        /// <summary>
        /// Gets all categories from the database.
        /// </summary>
        /// <returns>A DataTable containing all categories.</returns>
        public static DataTable GetAllCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Adds a new category to the database.
        /// </summary>
        /// <param name="categoryName">The name of the category to add.</param>
        /// <returns>True if the category was added successfully, otherwise false.</returns>
        public static bool AddCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                return false;

            string query = "INSERT INTO Categories (CategoryName) VALUES (@Name)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", categoryName)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Updates an existing category in the database.
        /// </summary>
        /// <param name="categoryId">The ID of the category to update.</param>
        /// <param name="categoryName">The new name of the category.</param>
        /// <returns>True if the category was updated successfully, otherwise false.</returns>
        public static bool UpdateCategory(int categoryId, string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                return false;

            string query = "UPDATE Categories SET CategoryName = @Name WHERE CategoryID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", categoryId),
                new SqlParameter("@Name", categoryName)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Deletes a category from the database.
        /// </summary>
        /// <param name="categoryId">The ID of the category to delete.</param>
        /// <returns>True if the category was deleted successfully, otherwise false.</returns>
        public static bool DeleteCategory(int categoryId)
        {
            string query = "DELETE FROM Categories WHERE CategoryID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", categoryId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Checks if a category with the specified name already exists.
        /// </summary>
        /// <param name="categoryName">The name of the category to check.</param>
        /// <returns>True if the category exists, otherwise false.</returns>
        public static bool IsCategoryExists(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                return false;

            string query = "SELECT COUNT(*) FROM Categories WHERE CategoryName = @Name";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", categoryName)
            };

            // ExecuteScalar is more appropriate here than ExecuteNonQuery
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
        /// Checks if a category is being used by any products.
        /// </summary>
        /// <param name="categoryId">The ID of the category to check.</param>
        /// <returns>True if the category is used by at least one product, otherwise false.</returns>
        public static bool IsCategoryUsed(int categoryId)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE CategoryID = @CategoryID";
            SqlParameter[] parameters = {
                new SqlParameter("@CategoryID", categoryId)
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