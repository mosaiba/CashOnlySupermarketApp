// BusinessLogic/UnitManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    public static class UnitManager
    {
        // دالة لجلب كل الوحدات
        public static DataTable GetAllUnits()
        {
            string query = "SELECT UnitID, UnitName FROM Units";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // دالة للتحقق من وجود وحدة بالاسم
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

        // دالة لإضافة وحدة جديدة
        public static bool AddUnit(string unitName)
        {
            if (string.IsNullOrEmpty(unitName))
                return false;

            if (IsUnitExists(unitName))
                return false;

            string query = "INSERT INTO Units (UnitName) VALUES (@Name)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", unitName)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة لتعديل وحدة موجودة
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

        // دالة لحذف وحدة
        public static bool DeleteUnit(int unitId)
        {
            string query = "DELETE FROM Units WHERE UnitID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", unitId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public static bool IsUnitUsed(int UnitID)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE UnitID = @UnitID";
            SqlParameter[] parameters = {
        new SqlParameter("@UnitID", UnitID)
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