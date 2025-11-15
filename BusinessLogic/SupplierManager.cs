// BusinessLogic/SupplierManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    public static class SupplierManager
    {
        // دالة لجلب كل الموردين النشطين فقط
        public static DataTable GetAllSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName, Phone FROM Suppliers WHERE IsActive = 1";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // دالة للتحقق من وجود مورد بالاسم (للإضافة)
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

        // دالة لإضافة مورد جديد
        public static bool AddSupplier(string supplierName, string phone)
        {
            if (string.IsNullOrEmpty(supplierName))
                return false;

            if (IsSupplierExists(supplierName))
                return false;

            string query = "INSERT INTO Suppliers (SupplierName, Phone) VALUES (@Name, @Phone)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", supplierName),
                new SqlParameter("@Phone", (object)phone ?? DBNull.Value)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة لتعديل مورد موجود
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

        // دالة "حذف" مورد (الآن هي تعطيل)
        public static bool DeleteSupplier(int supplierId)
        {
            string query = "UPDATE Suppliers SET IsActive = 0 WHERE SupplierID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", supplierId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // --- دوال جديدة للتعامل مع الموردين المعطلين ---

        // دالة لجلب كل الموردين المعطلين
        public static DataTable GetAllDisabledSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName, Phone FROM Suppliers WHERE IsActive = 0";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // دالة لاستعادة مورد معطل
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