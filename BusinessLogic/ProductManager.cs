// BusinessLogic/ProductManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    public static class ProductManager
    {
        // دالة لجلب كل المنتجات مع أسماء الفئات والموردين والوحدات
        // BusinessLogic/ProductManager.cs
        // BusinessLogic/ProductManager.cs
        public static DataTable GetAllProductsWithDetails()
        {
            string query = @"
        SELECT 
            p.ProductID, p.ProductName, p.Barcode, p.PurchasePrice, p.SalePrice, p.QuantityInStock,
            c.CategoryName, s.SupplierName, u.UnitName
        FROM Products p
        INNER JOIN Categories c ON p.CategoryID = c.CategoryID
        LEFT JOIN Suppliers s ON p.SupplierID = s.SupplierID
        INNER JOIN Units u ON p.UnitID = u.UnitID
        WHERE p.IsActive = 1"; // <-- التعديل هنا: جلب المنتجات النشطة فقط
            return DatabaseHelper.ExecuteQuery(query);
        }
        // دالة للتحقق من وجود منتج بالاسم أو الباركود
        public static bool IsProductExists(string barcode)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE Barcode = @Barcode";
            SqlParameter[] parameters = {
                new SqlParameter("@Barcode", (object)barcode ?? DBNull.Value)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة لإضافة منتج جديد (مبسطة)
        public static bool AddProduct(string name, string barcode, int categoryId, int unitId, decimal salePrice)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            string query = @"
        INSERT INTO Products (ProductName, Barcode, CategoryID, UnitID, SalePrice, QuantityInStock) 
        VALUES (@Name, @Barcode, @CategoryID, @UnitID, @SalePrice, 0)";
        

    SqlParameter[] parameters = {
        new SqlParameter("@Name", name),
        new SqlParameter("@Barcode", (object)barcode ?? DBNull.Value),
        new SqlParameter("@CategoryID", categoryId),
        new SqlParameter("@UnitID", unitId),
        new SqlParameter("@SalePrice", salePrice)
    };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة لتعديل منتج موجود (مبسطة)
        public static bool UpdateProduct(int productId, string name, string barcode, int categoryId, int unitId, decimal salePrice)
        {
            string query = @"
        UPDATE Products 
        SET ProductName = @Name, Barcode = @Barcode, CategoryID = @CategoryID, UnitID = @UnitID, SalePrice = @SalePrice
        WHERE ProductID = @ProductID";

            SqlParameter[] parameters = {
        new SqlParameter("@ProductID", productId),
        new SqlParameter("@Name", name),
        new SqlParameter("@Barcode", (object)barcode ?? DBNull.Value),
        new SqlParameter("@CategoryID", categoryId),
        new SqlParameter("@UnitID", unitId),
        new SqlParameter("@SalePrice", salePrice)
    };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // دالة لحذف منتج
        public static bool DeleteProduct(int productId)
        {
            // لا نحذف، بل نقوم بتعطيل المنتج
            string query = "UPDATE Products SET IsActive = 0 WHERE ProductID = @ProductID";
            SqlParameter[] parameters = {
              new SqlParameter("@ProductID", productId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        // دوال مساعدة لملء الـ ComboBoxes
        public static DataTable GetCategoriesForCombo()
        {
            return DatabaseHelper.ExecuteQuery("SELECT CategoryID, CategoryName FROM Categories");
        }

        public static DataTable GetUnitsForCombo()
        {
            return DatabaseHelper.ExecuteQuery("SELECT UnitID, UnitName FROM Units");
        }

        // BusinessLogic/ProductManager.cs
        // ... داخل كلاس ProductManager ...

        // دالة لجلب كل المنتجات المعطلة مع تفاصيلها
        public static DataTable GetAllDisabledProductsWithDetails()
        {
            string query = @"
        SELECT 
            p.ProductID, p.ProductName, p.Barcode, p.SalePrice, p.QuantityInStock,
            c.CategoryName, s.SupplierName, u.UnitName
        FROM Products p
        INNER JOIN Categories c ON p.CategoryID = c.CategoryID
        LEFT JOIN Suppliers s ON p.SupplierID = s.SupplierID
        INNER JOIN Units u ON p.UnitID = u.UnitID
        WHERE p.IsActive = 0"; // <-- جلب المنتجات المعطلة فقط
            return DatabaseHelper.ExecuteQuery(query);
        }

        // دالة لاستعادة منتج معطل (جعله نشطًا مرة أخرى)
        public static bool RestoreProduct(int productId)
        {
            string query = "UPDATE Products SET IsActive = 1 WHERE ProductID = @ProductID";
            SqlParameter[] parameters = {
        new SqlParameter("@ProductID", productId)
             };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // ... باقي الدوال ...
    }
}