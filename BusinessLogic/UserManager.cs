// BusinessLogic/UserManager.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using CashOnlySupermarketApp.DataAccess;
using System.Collections.Generic;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages user-related operations such as authentication, creation, and updates.
    /// </summary>
    public static class UserManager
    {
        /// <summary>
        /// Hashes a password using SHA256.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <returns>The hashed password as a string.</returns>
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Validates a user's credentials against the database.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>A DataTable containing the user's data if the credentials are valid, otherwise empty.</returns>
        public static DataTable ValidateUser(string username, string password)
        {
            string passwordHash = HashPassword(password);
            string query = @"
                SELECT u.UserID, u.Username, u.Role, e.FullName, u.IsActive, u.EmployeeID
                FROM Users u 
                INNER JOIN Employees e ON u.EmployeeID = e.EmployeeID 
                WHERE u.Username = @Username AND u.PasswordHash = @PasswordHash";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHash", passwordHash)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        /// <summary>
        /// Creates a new user in the database.
        /// </summary>
        /// <param name="username">The username for the new user.</param>
        /// <param name="password">The password for the new user.</param>
        /// <param name="role">The role assigned to the new user.</param>
        /// <param name="employeeId">The ID of the employee associated with this user.</param>
        /// <returns>True if the user was created successfully, otherwise false.</returns>
        public static bool CreateUser(string username, string password, string role, int employeeId)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            string passwordHash = HashPassword(password);
            string query = "INSERT INTO Users (Username, PasswordHash, Role, EmployeeID) VALUES (@Username, @PasswordHash, @Role, @EmployeeID)";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHash", passwordHash),
                new SqlParameter("@Role", role),
                new SqlParameter("@EmployeeID", employeeId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Deactivates a user account based on the employee ID.
        /// </summary>
        /// <param name="employeeId">The employee ID of the user to deactivate.</param>
        /// <returns>True if the user was deactivated successfully, otherwise false.</returns>
        public static bool DeactivateUserByEmployeeId(int employeeId)
        {
            string query = "UPDATE Users SET IsActive = 0 WHERE EmployeeID = @EmployeeID";
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Activates a user account based on the employee ID.
        /// </summary>
        /// <param name="employeeId">The employee ID of the user to activate.</param>
        /// <returns>True if the user was activated successfully, otherwise false.</returns>
        public static bool ActivateUserByEmployeeId(int employeeId)
        {
            string query = "UPDATE Users SET IsActive = 1 WHERE EmployeeID = @EmployeeID";
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId)
            };
            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        /// <summary>
        /// Updates a user's information in the database.
        /// </summary>
        /// <param name="userId">The ID of the user to update.</param>
        /// <param name="username">The new username.</param>
        /// <param name="newPassword">The new password. If empty, the password will not be changed.</param>
        /// <param name="role">The new role.</param>
        /// <param name="isActive">The new active status.</param>
        /// <returns>True if the user was updated successfully, otherwise false.</returns>
        public static bool UpdateUser(int userId, string username, string newPassword, string role, bool isActive)
        {
            if (userId <= 0 || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
                return false;

            string query = "UPDATE Users SET Username = @Username, Role = @Role, IsActive = @IsActive";

            if (!string.IsNullOrEmpty(newPassword))
            {
                query += ", PasswordHash = @PasswordHash";
            }

            query += " WHERE UserID = @UserID";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userId),
                new SqlParameter("@Username", username),
                new SqlParameter("@Role", role),
                new SqlParameter("@IsActive", isActive)
            };

            if (!string.IsNullOrEmpty(newPassword))
            {
                parameters.Add(new SqlParameter("@PasswordHash", HashPassword(newPassword)));
            }

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());
            return result > 0;
        }
    }
}