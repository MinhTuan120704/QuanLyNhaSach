﻿using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IOrderService
    {
        bool AddOrder(Order order);
        bool DeleteOrder(Order order);
        bool UpdateOrder(Order order);  
        bool UpdateOrder(int orderID, DateTime date, int consumerID, int total, int paid, int remaining);  
        List<Order> GetAllOrder();
    }
}
