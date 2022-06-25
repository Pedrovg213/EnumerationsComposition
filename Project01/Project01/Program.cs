using System;
using Project01.Entities;
using Project01.Entities.Enums;

namespace Project01 {
   internal class Program {
      static void Main( string[] args ) {
         Order _order = new Order {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
         };

         Console.WriteLine( _order );
      }
   }
}
