using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class MicrosoftSqlServerAdapter: ISqlAdapter
    {

        private string _connectionString;
        public MicrosoftSqlServerAdapter()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            string sqlQuery = QueryText.GetCustomers();

            try
            {
                var rows = GetRowsByQuery(sqlQuery);

                foreach (DataRow row in rows)
                {
                    var customer = new Customer()
                    {
                        Name = row["name"].ToString(),
                        Address = row["address"].ToString()
                    };
                    customers.Add(customer);
                }
            }
            catch (SqlException ex)
            {
                //Log ex
            }
            
            return customers;
        }

        public List<Order> GetOrdersByCustomer(string customer = "")
        {
            var orders = new List<Order>();
            string sqlQuery = QueryText.GetOrdersByCustomer(customer);
            try
            {
                var rows = GetRowsByQuery(sqlQuery);

                foreach (DataRow row in rows)
                {
                    var order = new Order()
                    {
                        Service = row["Service"].ToString(),
                        Price = int.Parse(row["Price"].ToString()),
                        CustomerName = row["Name"].ToString()
                    };
                    orders.Add(order);
                }
            }
            catch (SqlException ex)
            {
                //Log ex
            }
            return orders;
        }

        private DataRowCollection GetRowsByQuery(string sqlQuery)
        {
            DataRowCollection rows;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                adapter.Fill(dt);
                rows = dt.Rows;
            }
            return rows;
        }
    }
}

