// BusinessLogic/SaleManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages sales-related operations, including creating sales and updating stock.
    /// </summary>
    public static class SaleManager
    {
        /// <summary>
        /// Creates a new sale, adds its details, and decreases the stock quantity of the sold products.
        /// This operation is performed within a single transaction to ensure data integrity.
        /// </summary>
        /// <param name="employeeId">The ID of the employee who made the sale.</param>
        /// <param name="totalAmount">The total amount of the sale.</param>
        /// <param name="saleDetails">A DataTable containing the details of the products sold (ProductID, Quantity, UnitPrice, LineTotal, ProductName).</param>
        /// <returns>True if the sale was created and stock was updated successfully, otherwise false.</returns>
        /// <exception cref="Exception">Throws an exception if the sale fails, with a detailed message.</exception>
        public static bool CreateSaleAndDecreaseStock(int employeeId, decimal totalAmount, DataTable saleDetails)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int saleId;

                    // 1. Create the sale header
                    string headerQuery = @"
                        INSERT INTO Sales (EmployeeID, SaleDate, TotalAmount) 
                        VALUES (@EmployeeID, GETDATE(), @TotalAmount);
                        SELECT CAST(scope_identity() AS int);";

                    using (SqlCommand cmd = new SqlCommand(headerQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        saleId = (int)cmd.ExecuteScalar();
                    }

                    // 2. Add sale details and decrease stock for each product
                    foreach (DataRow row in saleDetails.Rows)
                    {
                        int productId = (int)row["ProductID"];
                        int quantitySold = (int)row["Quantity"];

                        // Add sale detail item
                        string detailQuery = @"
                            INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice, LineTotal) 
                            VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice, @LineTotal)";

                        using (SqlCommand cmd = new SqlCommand(detailQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@SaleID", saleId);
                            cmd.Parameters.AddWithValue("@ProductID", productId);
                            cmd.Parameters.AddWithValue("@Quantity", quantitySold);
                            cmd.Parameters.AddWithValue("@UnitPrice", row["UnitPrice"]);
                            cmd.Parameters.AddWithValue("@LineTotal", row["LineTotal"]);
                            cmd.ExecuteNonQuery();
                        }

                        // Decrease product quantity in stock
                        string updateStockQuery = @"
                            UPDATE Products 
                            SET QuantityInStock = QuantityInStock - @QuantitySold
                            WHERE ProductID = @ProductID AND QuantityInStock >= @QuantitySold"; // Check for sufficient quantity

                        using (SqlCommand cmd = new SqlCommand(updateStockQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
                            cmd.Parameters.AddWithValue("@ProductID", productId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                // This means the stock quantity was insufficient
                                throw new Exception($"The available quantity of product '{row["ProductName"]}' is insufficient.");
                            }
                        }
                    }

                    // If all operations succeed, commit the transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // If any error occurs, roll back all operations
                    transaction.Rollback();
                    throw new Exception("The sale operation failed. All changes have been rolled back.", ex);
                }
            }
        }

        /// <summary>
        /// Gets all active products for the Point of Sale (POS) system.
        /// </summary>
        /// <returns>A DataTable containing the ProductID, ProductName, Barcode, SalePrice, and QuantityInStock of active products.</returns>
        public static DataTable GetProductsForPOS()
        {
            string query = "SELECT ProductID, ProductName, Barcode, SalePrice, QuantityInStock FROM Products WHERE IsActive = 1";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}