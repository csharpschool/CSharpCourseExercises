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
        public int Count { get; } = default;
        public double Price { get; } = default;
        private double _vat = default;
        public double Vat
        {
            get => this switch
            {
                var (vat) when vat == 0 => 1,
                var (vat) when vat > 0 && vat < 1 => vat + 1,
                var (vat) when vat > 1 && vat < 2 => vat,
                _ => 1
            };
        }
        public double Total => Count * Price * Vat;
        public double VatCost => Count * Price * (Vat - 1);

        public LineItem(int id, string product, int count, double price, double vat)
        {
            Id = id;
            Product = product;
            Count = count;
            Price = price;
            _vat = vat;
        }
        
        public void Deconstruct(out double vat) => (vat) = (_vat);
    }
}
