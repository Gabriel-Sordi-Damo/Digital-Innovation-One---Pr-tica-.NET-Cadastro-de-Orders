using System.Collections.Generic;
using Order;
namespace MemoryDB.OrderMemoryDB
{


    static class OrderMemoryDB
    {
        private static List<Order.Order> orders = new List<Order.Order>();

        public static void Add(Order.Order order)
        {
            orders.Add(order);
        }

        public static void Delete(int id)
        {
            foreach (Order.Order order in orders)
                if (order.id == id)
                    order.DeleteOrder();
        }

        public static List<Order.Order> GetAll()
        {
            List<Order.Order> copyOrders = new List<Order.Order>();
            foreach (Order.Order order in orders)
                if (order.excluded == false)
                    copyOrders.Add(order.Copy());
            return copyOrders;
        }

        public static Order.Order GetById(int id)
        {
            foreach (Order.Order order in orders)
                if (order.id == id && order.excluded == false)
                    return order.Copy();
            return Order.Order.GenerateNullOrder();
        }
        public static void Update(Order.Order order)
        {
            for (int i = 0; i < orders.Count; i++)
                if (order.id == orders[i].id)
                {
                    orders[i] = order;
                    break;
                }

        }
    }

}