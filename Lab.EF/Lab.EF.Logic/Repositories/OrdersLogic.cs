using Lab.EF.Entities;
using Lab.EF.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class OrdersLogic : BaseLogic<Orders>
    {
        public override void Add(Orders entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Orders> GetAll()
        {

            return _context.Orders.ToList();
        }

        public override Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Orders entity)
        {
            throw new NotImplementedException();
        }

        public List<OrdersViewModel> GetWhereCustomersRegionWA()
        {
            var query = (from orders in _context.Orders
                         join customers in _context.Customers
                         on orders.CustomerID equals customers.CustomerID
                         where customers.Region == "WA" && orders.OrderDate > new DateTime(1997,1, 1)
                         orderby orders.OrderDate descending, customers.CustomerID descending
                         select new OrdersViewModel
                         {
                              OrderId = orders.OrderID,
                              OrderDate = orders.OrderDate,
                              CustomerId = customers.CustomerID,
                              CompanyName = customers.CompanyName,
                              Region = customers.Region 
                         }).ToList();

            return query;
        }
    }
}
