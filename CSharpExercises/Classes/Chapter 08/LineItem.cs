using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_08
{
    public class LineItem
    {
        public int Id { get; } = default;
        public string Product { get; } = string.Empty;
        public int Quantity { get; } = default;
        public double Price { get; } = default;
        private double _vat = default;
        public double Vat =>
            this switch
            {
                var (vat) when vat >= 1 && vat <= 100 => vat / 100,
                var (vat) when vat > 0 && vat < 1 => vat,
                _ => 0
            };
        public double Total => Quantity * Price * (Vat + 1);
        public double VatCost => Quantity * Price * Vat;

        public LineItem(int id, string product, int quantity, double price, double vat)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            Price = price;
            _vat = vat;
        }
        
        private void Deconstruct(out double vat) => (vat) = (_vat);
    }
}
