using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class OrderModel
    {
        private readonly ISqlAdapter _sqlQueryAdapter = new MicrosoftSqlServerAdapter();

        public List<Customer> GetCustomers()
        {
            return _sqlQueryAdapter.GetCustomers();
        }

        public List<Order> GetOrdersByCustomer(string customer = "")
        {
            return _sqlQueryAdapter.GetOrdersByCustomer(customer);
        }
    }
}
