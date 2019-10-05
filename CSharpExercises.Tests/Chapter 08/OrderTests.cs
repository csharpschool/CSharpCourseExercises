using Xunit;
using CSharpExercises.Classes.Chapter_08;

namespace CSharpExercises.Tests.Chapter_08
{
    public class OrderTests
    {
        [Fact]
        public void CanCreateLineItemInstance()
        {
            var item = new LineItem(1, "Product 1", 2, 10, 50);

            Assert.NotNull(item);
            Assert.Equal(1, item.Id);
            Assert.Equal(2, item.Count);
            Assert.Equal(10, item.Price);
            Assert.Equal(10, item.VatCost);
            Assert.Equal(30, item.Total);
            Assert.Equal("Product 1", item.Product);
        }

        [Fact]
        public void CanCreateOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");

            Assert.NotNull(order);
            Assert.Equal(1, order.Id);
            Assert.Equal("Customer 1", order.Customer);
            Assert.Equal("Address 1", order.Address);
            Assert.Empty(order.Items);
        }

        [Fact]
        public void CanCreateOrderFactoryInstance()
        {
            var orders = new OrderFactory();

            Assert.NotNull(orders);
        }

        [Fact]
        public void CanAddOrderWithFactoryInstance()
        {
            var orders = new OrderFactory();

            orders.Add("Customer 1", "Address 1");

            Assert.NotEmpty(orders.Get());
        }


        [Fact]
        public void CanAddLineItemToOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");
            order.AddLineItem("Product 1", 2, 10, 50);
            var addedItem = order.Items.Find(i => i.Id.Equals(1));

            // Assert Order
            Assert.NotNull(order);
            Assert.Equal(1, order.Id);
            Assert.Equal("Customer 1", order.Customer);
            Assert.Equal("Address 1", order.Address);
            Assert.NotEmpty(order.Items);

            // Assert LineItem
            Assert.Equal(1, addedItem.Id);
            Assert.Equal(2, addedItem.Count);
            Assert.Equal(10, addedItem.Price);
            Assert.Equal(10, addedItem.VatCost);
            Assert.Equal(30, addedItem.Total);
            Assert.Equal("Product 1", addedItem.Product);
        }

        [Fact]
        public void CanGetTotalAndVatInOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");
            
            order.AddLineItem("Product 1", 2, 10, 50);
            order.AddLineItem("Product 2", 1, 100, 0.5);
            order.GetTotalAndVat(out double total, out double vat);

            Assert.NotNull(order);
            Assert.Equal(60, vat);
            Assert.Equal(180, total);
        }

    }
}
