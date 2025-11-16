// BusinessLogic/PurchaseManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages purchase-related operations, including creating purchase orders and updating stock.
    /// </summary>
    public static class PurchaseManager
    {
        /// <summary>
        /// Creates a new purchase order, adds its details, and updates the stock for the received products.
        /// This operation is performed within a single transaction to ensure data integrity.
        /// </summary>
        /// <param name="supplierId">The ID of the supplier.</param>
        /// <param name="totalAmount">The total amount of the purchase order.</param>
        /// <param name="orderDetails">A DataTable containing the details of the products purchased (ProductID, Quantity, UnitPrice).</param>
        /// <returns>True if the purchase order was created and stock was updated successfully, otherwise false.</returns>
        /// <exception cref="Exception">Throws an exception if the operation fails, with a detailed message.</exception>
        public static bool CreatePurchaseOrderAndReceive(int supplierId, decimal totalAmount, DataTable orderDetails)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int purchaseOrderId;

                    // 1. Create the purchase order header
                    string headerQuery = @"
                        INSERT INTO PurchaseOrders (SupplierID, OrderDate, TotalAmount, IsReceived) 
                        VALUES (@SupplierID, GETDATE(), @TotalAmount, 1);
                        SELECT CAST(scope_identity() AS int);";

                    using (SqlCommand cmd = new SqlCommand(headerQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        purchaseOrderId = (int)cmd.ExecuteScalar();
                    }

                    // 2. Add purchase order details and update stock for each product
                    foreach (DataRow row in orderDetails.Rows)
                    {
                        // Add purchase order detail item
                        string detailQuery = @"
                            INSERT INTO PurchaseOrderDetails (PurchaseOrderID, ProductID, Quantity, UnitPrice) 
                            VALUES (@PurchaseOrderID, @ProductID, @Quantity, @UnitPrice)";

                        using (SqlCommand cmd = new SqlCommand(detailQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                            cmd.Parameters.AddWithValue("@ProductID", row["ProductID"]);
                            cmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                            cmd.Parameters.AddWithValue("@UnitPrice", row["UnitPrice"]);
                            cmd.ExecuteNonQuery();
                        }

                        // 3. Update product stock and purchase price
                        string updateStockQuery = @"
                            UPDATE Products 
                            SET QuantityInStock = QuantityInStock + @Quantity, PurchasePrice = @UnitPrice
                            WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(updateStockQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                            cmd.Parameters.AddWithValue("@UnitPrice", row["UnitPrice"]);
                            cmd.Parameters.AddWithValue("@ProductID", row["ProductID"]);
                            cmd.ExecuteNonQuery();
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
                    throw new Exception("Failed to create purchase order. All changes have been rolled back.", ex);
                }
            }
        }

        /// <summary>
        /// Gets all active suppliers to populate a ComboBox.
        /// </summary>
        /// <returns>A DataTable containing SupplierID and SupplierName.</returns>
        public static DataTable GetSuppliersForCombo()
        {
            return DatabaseHelper.ExecuteQuery("SELECT SupplierID, SupplierName FROM Suppliers WHERE IsActive = 1");
        }

        /// <summary>
        /// Gets all active products to populate a ComboBox.
        /// </summary>
        /// <returns>A DataTable containing ProductID and ProductName.</returns>
        public static DataTable GetProductsForCombo()
        {
            return DatabaseHelper.ExecuteQuery("SELECT ProductID, ProductName FROM Products WHERE IsActive = 1");
        }
    }
}