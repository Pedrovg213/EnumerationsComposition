using System.Globalization;

namespace Project04.Entities {
   internal class OrderItem {
      public int Quantity {
         get; set;
      }
      public double Price {
         get; set;
      }
      public Product Product {
         get; set;
      }


      public OrderItem( int _quantity, double _price , Product product ) {

         Quantity = _quantity;
         Price = _price;
         Product = product;
      }


      public double SubTotal( ) {

         return Price * Quantity;
      }


      public override string ToString( ) {
         return $"{Product}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
      }
   }
}
