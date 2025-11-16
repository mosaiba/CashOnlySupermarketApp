// BusinessLogic/ProductManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages product-related operations such as adding, updating, deleting, and retrieving products.
    /// </summary>
    public static class ProductManager
    {
        /// <summary>
        /// Gets all active products with their details (Category, Supplier, Unit).
        /// </summary>
        /// <returns>A DataTable containing the active products and their details.</returns>
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
                WHERE p.IsActive = 1";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Checks if a product with the specified barcode already exists.
        /// </summary>
        /// <param name="barcode">The barcode to check.</param>
        /// <returns>True if a product with the given barcode exists, otherwise false.</returns>
        public static bool IsProductExists(string barcode)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE Barcode = @Barcode";
            SqlParameter[] parameters = {
                new SqlParameter("@Barcode", (object)barcode ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);

            if (result != null && result != DBNull.Value)
            {
                int count = Convert.ToInt32(result);
                return count > 0;
            }

            return false;
        }

        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        /// <param name="name">The name of the product.</param>
        /// <param name="barcode">The barcode of the product.</param>
        /// <param name="categoryId">The ID of the product's category.</param>
        /// <param name="unitId">The ID of the product's unit.</param>
        /// <param name="salePrice">The sale price of the product.</param>
        /// <returns>True if the product was added successfully, otherwise false.</returns>
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

        /// <summary>
        /// Updates an existing product's information.
        /// </summary>
        /// <param name="productId">The ID of the product to update.</param>
        /// <param name="name">The new name of the product.</param>
        /// <param name="barcode">The new barcode of the product.</param>
        /// <param name="categoryId">The new category ID of the product.</param>
        /// <param name="unitId">The new unit ID of the product.</param>
        /// <param name="salePrice">The new sale price of the product.</param>
        /// <returns>True if the product was updated successfully, otherwise false.</returns>
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

        /// <summary>
        /// Deactivates a product (soft delete).
        /// </summary>
        /// <param name="productId">The ID of the product to deactivate.</param>
        /// <returns>True if the product was deactivated successfully, otherwise false.</returns>
        public static bool DeleteProduct(int productId)
        {
            string query = "UPDATE Products SET IsActive = 0 WHERE ProductID = @ProductID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", productId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Gets all categories to populate a ComboBox.
        /// </summary>
        /// <returns>A DataTable containing CategoryID and CategoryName.</returns>
        public static DataTable GetCategoriesForCombo()
        {
            return DatabaseHelper.ExecuteQuery("SELECT CategoryID, CategoryName FROM Categories");
        }

        /// <summary>
        /// Gets all units to populate a ComboBox.
        /// </summary>
        /// <returns>A DataTable containing UnitID and UnitName.</returns>
        public static DataTable GetUnitsForCombo()
        {
            return DatabaseHelper.ExecuteQuery("SELECT UnitID, UnitName FROM Units");
        }

        /// <summary>
        /// Gets all disabled products with their details.
        /// </summary>
        /// <returns>A DataTable containing disabled products and their details.</returns>
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
                WHERE p.IsActive = 0";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Restores a disabled product, making it active again.
        /// </summary>
        /// <param name="productId">The ID of the product to restore.</param>
        /// <returns>True if the product was restored successfully, otherwise false.</returns>
        public static bool RestoreProduct(int productId)
        {
            string query = "UPDATE Products SET IsActive = 1 WHERE ProductID = @ProductID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", productId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Gets the purchase price of a specific product.
        /// </summary>
        /// <param name="productId">The ID of the product.</param>
        /// <returns>The purchase price of the product, or 0 if not found.</returns>
        public static decimal GetProductPurchasePrice(int productId)
        {
            string query = "SELECT PurchasePrice FROM Products WHERE ProductID = @ProductID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", productId)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }

        /// <summary>
        /// Gets a product's data by its name.
        /// </summary>
        /// <param name="productName">The name of the product to find.</param>
        /// <returns>A DataRow containing the product's information if found, otherwise null.</returns>
        public static DataRow GetProductByName(string productName)
        {
            string query = "SELECT ProductID, ProductName FROM Products WHERE ProductName = @Name AND IsActive = 1";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", productName)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }

        /// <summary>
        /// Gets all active products for display in a grid.
        /// </summary>
        /// <returns>A DataTable with basic product information.</returns>
        public static DataTable GetAllActiveProductsForGrid()
        {
            string query = @"
                SELECT 
                    p.ProductID, 
                    p.ProductName, 
                    p.Barcode, 
                    p.QuantityInStock, 
                    u.UnitName
                FROM 
                    Products p
                LEFT JOIN 
                    Units u ON p.UnitID = u.UnitID
                WHERE 
                    p.IsActive = 1";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}