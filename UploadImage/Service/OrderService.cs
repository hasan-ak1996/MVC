using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadImage.Context;
using UploadImage.IService;
using UploadImage.Models;

namespace UploadImage.Service
{
    public class OrderService : IOrderService
    {
        private readonly DatabaseContext _context;
        public OrderService(DatabaseContext context)
        {
            _context = context;
        }
        public OrderTest GetSavedOrder()
        {
            return _context.OrderTest.SingleOrDefault();
        }

        public OrderTest save(OrderTest order)
        {
            _context.OrderTest.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}
