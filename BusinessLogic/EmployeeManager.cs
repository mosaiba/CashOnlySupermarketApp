// BusinessLogic/EmployeeManager.cs
using System.Data;
using Microsoft.Data.SqlClient;
using CashOnlySupermarketApp.DataAccess;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages employee-related operations such as adding, updating, and deactivating employees.
    /// </summary>
    public static class EmployeeManager
    {
        /// <summary>
        /// Gets all active employees with their user account status.
        /// </summary>
        /// <returns>A DataTable containing the active employees and their user status.</returns>
        public static DataTable GetAllActiveEmployeesWithUserStatus()
        {
            string query = @"
                SELECT e.EmployeeID, e.FullName, e.Position, 
                       CASE
                           WHEN u.UserID IS NULL THEN 'No Account'
                           WHEN u.IsActive = 1 THEN 'Active'
                           ELSE 'Inactive'
                       END AS UserStatus
                FROM Employees e
                LEFT JOIN Users u ON e.EmployeeID = u.EmployeeID
                WHERE e.IsActive = 1";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Adds a new employee to the database.
        /// </summary>
        /// <param name="fullName">The full name of the employee.</param>
        /// <param name="position">The position of the employee.</param>
        /// <returns>True if the employee was added successfully, otherwise false.</returns>
        public static bool AddEmployee(string fullName, string position)
        {
            if (string.IsNullOrEmpty(fullName))
                return false;

            string query = "INSERT INTO Employees (FullName, Position) VALUES (@FullName, @Position)";
            SqlParameter[] parameters = {
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@Position", position)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Updates an active employee's information.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to update.</param>
        /// <param name="fullName">The new full name of the employee.</param>
        /// <param name="position">The new position of the employee.</param>
        /// <returns>True if the employee was updated successfully, otherwise false.</returns>
        public static bool UpdateEmployee(int employeeId, string fullName, string position)
        {
            if (string.IsNullOrEmpty(fullName))
                return false;

            string query = "UPDATE Employees SET FullName = @FullName, Position = @Position WHERE EmployeeID = @ID AND IsActive = 1";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", employeeId),
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@Position", position)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Deactivates an employee (soft delete).
        /// </summary>
        /// <param name="employeeId">The ID of the employee to deactivate.</param>
        /// <returns>True if the employee was deactivated successfully, otherwise false.</returns>
        public static bool DeactivateEmployee(int employeeId)
        {
            string query = "UPDATE Employees SET IsActive = 0 WHERE EmployeeID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", employeeId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Gets all disabled employees.
        /// </summary>
        /// <returns>A DataTable containing the disabled employees.</returns>
        public static DataTable GetAllDisabledEmployees()
        {
            string query = @"
                SELECT e.EmployeeID, e.FullName, e.Position, 
                       CASE WHEN u.UserID IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS HasUser
                FROM Employees e
                LEFT JOIN Users u ON e.EmployeeID = u.EmployeeID
                WHERE e.IsActive = 0";
            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Activates a disabled employee.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to activate.</param>
        /// <returns>True if the employee was activated successfully, otherwise false.</returns>
        public static bool ActivateEmployee(int employeeId)
        {
            string query = "UPDATE Employees SET IsActive = 1 WHERE EmployeeID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", employeeId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}