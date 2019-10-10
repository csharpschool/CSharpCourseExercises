using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_09
{
    public class OrderFactory
    {
        List<Order> Orders { get; } = new List<Order>();
        private int MaxId => Orders.Count.Equals(0) ? 0 : Orders.Max(m => m.Id);
        private int CurrentId => MaxId + 1;

        public void Add(string customer, string address)
        {
            try
            {
                Orders.Add(new Order(CurrentId, customer, address));
            }
            catch
            {
                throw;
            }
        }
        public List<Order> Get() => Orders;
        public Order Latest() => Orders.Find(o => o.Id.Equals(MaxId));

    }
}
