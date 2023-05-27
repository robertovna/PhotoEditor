using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    public static class QueryText
    {
        public static string GetCustomers() => "" +
                "SELECT * " +
                "FROM Customers";

        public static string GetOrdersByCustomer(string customer) => "" +
                "SELECT Products.Service, Products.Price, Customers.Name " +
                "FROM Products " +
                "JOIN Orders ON Products.Id = Orders.Product_id " +
                "JOIN Customers ON Customers.Id = Orders.Customer_id " +
                $"WHERE Customers.Name LIKE '%{customer}%'";
    }
}
