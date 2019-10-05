using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_08
{
    public class Order
    {
        public int Id { get; } = default;
        public string Customer { get; } = string.Empty;
        public string Address { get; } = string.Empty;
        public List<LineItem> Items { get; } = new List<LineItem>();

        public Order(int id, string customer, string address)
        {
            Id = id;
            Customer = customer;
            Address = address;
        }

        public void AddLineItem(LineItem item) => Items.Add(item);

        public void GetTotalAndVat(out double total, out double vat)
        {
            double totalPrice = default, totalVat = default;
            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items.ElementAt(i);
                totalPrice += item.Total;
                totalVat += item.VatCost;
            }

            total = totalPrice;
            vat = totalVat;
        }
    }
}
