using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Project04.Entities.Enums;

namespace Project04.Entities {
   internal class Order {
      public DateTime Moment {
         get; set;
      }
      public OrderStatus Status {
         get; set;
      }
      public Client Client {
         get; set;
      }
      public List<OrderItem> Items {
         get; set;
      } = new List<OrderItem>();


      public Order( ) {

         Moment = DateTime.Now;
      }
      public Order( OrderStatus _status , Client _client ) : this() {

         Status = _status;
         Client = _client;
      }


      public double TotalPrice( ) {

         double _sum = 0;

         foreach ( OrderItem o in Items )
            _sum += o.SubTotal();

         return _sum;
      }
      public void AddItems( params OrderItem[ ] _items ) {

         foreach ( OrderItem o in _items )
            Items.Add( o );
      }
      public void RemoveIntems( params OrderItem[ ] _items ) {

         foreach ( OrderItem o in _items )
            Items.Remove( o );
      }


      public override string ToString( ) {

         StringBuilder stringBuilder = new StringBuilder();
         stringBuilder.AppendLine( "ORDER SUMMARY:" );
         stringBuilder.AppendLine( "Order moment: " + Moment.ToString( "dd/MM/yyyy HH:mm:ss" ) );
         stringBuilder.AppendLine( "Order status: " + Status );
         stringBuilder.AppendLine( "Cliente: " + Client );
         stringBuilder.AppendLine( "Order items:" );

         foreach ( OrderItem o in Items )
            stringBuilder.AppendLine( o.ToString() );

         stringBuilder.AppendLine( "Total price: $" + TotalPrice().ToString( "F2" , CultureInfo.InvariantCulture ) );

         return stringBuilder.ToString();
      }
   }
}
