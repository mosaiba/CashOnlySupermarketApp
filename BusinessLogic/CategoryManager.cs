// BusinessLogic/CategoryManager.cs
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    public static class CategoryManager
    {
        // دالة لجلب كل الفئات
        public static DataTable GetAllCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // دالة لإضافة فئة جديدة
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

        // دالة لتعديل فئة موجودة
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

        // دالة لحذف فئة
        public static bool DeleteCategory(int categoryId)
        {
            string query = "DELETE FROM Categories WHERE CategoryID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", categoryId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة للتحقق من وجود فئة معينة
        public static bool IsCategoryExists(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                return false;

            string query = "SELECT COUNT(*) FROM Categories WHERE CategoryName = @Name";
            SqlParameter[] parameters = {
            new SqlParameter("@Name", categoryName)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة جديدة للتحقق مما إذا كانت الفئة مستخدمة في منتجات
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
                    return count > 0; // إذا كان هناك منتجات واحدة أو أكثر، فهي مستخدمة
                }
            }
        }

    }
}