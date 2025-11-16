// BusinessLogic/CurrentUserManager.cs
using System;

namespace CashOnlySupermarketApp.BusinessLogic
{
    /// <summary>
    /// Manages the current user's session data, including user ID, username, role, and full name.
    /// This is a static class, so its members can be accessed from anywhere in the application.
    /// </summary>
    public static class CurrentUserManager
    {
        /// <summary>
        /// Gets the ID of the currently logged-in user.
        /// </summary>
        public static int UserID { get; private set; }

        /// <summary>
        /// Gets the username of the currently logged-in user.
        /// </summary>
        public static string Username { get; private set; }

        /// <summary>
        /// Gets the role of the currently logged-in user (e.g., Admin, Manager, Cashier).
        /// </summary>
        public static string Role { get; private set; }

        /// <summary>
        /// Gets the full name of the currently logged-in user.
        /// </summary>
        public static string FullName { get; private set; }

        /// <summary>
        /// Gets the employee ID of the currently logged-in user.
        /// </summary>
        public static int EmployeeID { get; private set; }

        /// <summary>
        /// Sets the current user's data upon successful login.
        /// </summary>
        /// <param name="userId">The user's ID.</param>
        /// <param name="username">The user's username.</param>
        /// <param name="role">The user's role.</param>
        /// <param name="fullName">The user's full name.</param>
        /// <param name="employeeId">The user's employee ID.</param>
        public static void Login(int userId, string username, string role, string fullName, int employeeId)
        {
            UserID = userId;
            Username = username;
            Role = role;
            FullName = fullName;
            EmployeeID = employeeId;
        }

        /// <summary>
        /// Clears the current user's data upon logout.
        /// </summary>
        public static void Logout()
        {
            UserID = -1;
            Username = null;
            Role = null;
            FullName = null;
        }

        /// <summary>
        /// Checks if the current user has the 'Admin' role.
        /// </summary>
        /// <returns>True if the user is an Admin, otherwise false.</returns>
        public static bool IsAdmin() => Role == "Admin";

        /// <summary>
        /// Checks if the current user has the 'Manager' or 'Admin' role.
        /// </summary>
        /// <returns>True if the user is a Manager or Admin, otherwise false.</returns>
        public static bool IsManager() => Role == "Manager" || Role == "Admin";

        /// <summary>
        /// Checks if the current user has the 'Cashier', 'Manager', or 'Admin' role.
        /// </summary>
        /// <returns>True if the user is a Cashier, Manager, or Admin, otherwise false.</returns>
        public static bool IsCashier() => Role == "Cashier" || Role == "Manager" || Role == "Admin";
    }
}