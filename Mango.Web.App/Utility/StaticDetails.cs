﻿namespace Mango.Web.App.Utility
{
    /// <summary>
    /// Static details class for project.
    /// </summary>
    public class SD
    {
        /// <summary>
        /// Get and set the base url address for Coupon Service.
        /// </summary>
        public static string CouponAPIBase { get; set; }

        /// <summary>
        /// Get and set the base url address for Auth Service.
        /// </summary>
        public static string AuthAPIBase { get; set; }

        /// <summary>
        /// Get and set the base url address for Product Service.
        /// </summary>
        public static string ProductAPIBase { get; set; }

        /// <summary>
        /// Get and set the base url address for Shopping cart Service.
        /// </summary>
        public static string ShoppingCartAPIBase { get; set; }

        /// <summary>
        /// Get and set the base url address for Order Service.
        /// </summary>
        public static string OrderAPIBase { get; set; }

        /// <summary>
        /// Const admin role variable.
        /// </summary>
        public const string RoleAdmin = "ADMIN";

        /// <summary>
        /// Const customer role variable.
        /// </summary>
        public const string RoleCustomer = "CUSTOMER";

        /// <summary>
        /// Const token cookie variable.
        /// </summary>
        public const string TokenCookie = "JWTTOKEN";

        /// <summary>
        /// Api method types for a service.
        /// </summary>
        public enum ApiType {
            GET,
            POST, 
            PUT, 
            DELETE
        }
    }
}
