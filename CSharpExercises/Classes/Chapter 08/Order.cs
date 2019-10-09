using System.Collections.Generic;
using System.Linq;

namespace CSharpExercises.Classes.Chapter_08
{
    public class Order
    {
        public int Id { get; } = default;
        public string Customer { get; } = string.Empty;
        public string Address { get; } = string.Empty;
        public List<LineItem> Items { get; } = new List<LineItem>();
        private int MaxId => Items.Count.Equals(0) ? 0 : Items.Max(m => m.Id);
        private int CurrentId => MaxId + 1;

        public Order()
        {
        }

        public Order(int id, string customer, string address)
        {
            Id = id;
            Customer = customer;
            Address = address;
        }

        //public void AddLineItem(LineItem item) => Items.Add(item);
        public void AddLineItem(string product, int quantity, double price, double vat) => Items.Add(new LineItem(CurrentId, product, quantity, price, vat));

        public void GetOrderTotalAndVat(out double total, out double vat)
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
