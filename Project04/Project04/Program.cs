using System;
using System.Globalization;
using Project04.Entities;
using Project04.Entities.Enums;

namespace Project04 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Cliente Datas
         Console.WriteLine( "Enter cliente data:" );
         // name client
         Console.Write( "Name: " );
         string nameClient = Console.ReadLine();
         // email
         Console.Write( "Email: " );
         string email = Console.ReadLine();
         // birth date
         Console.Write( "Birth Date (DD/MM/YYYY): " );
         DateTime brithDate = DateTime.Parse(Console.ReadLine());
         Console.WriteLine();

         // Cliente instantiation
         Client client = new Client(nameClient, brithDate, email);

         // Order Datas
         Console.WriteLine( "Enter order data:" );
         // status
         Console.Write( "Status (PendingPayment/Processing/Shipped/Delivered): " );
         OrderStatus status = (OrderStatus)Enum.Parse(typeof (OrderStatus), Console.ReadLine());
         // quantity
         Console.Write( "How many items to this order? " );
         int orderQuant = int.Parse(Console.ReadLine());
         Console.WriteLine();

         // Order instantiation
         Order order = new Order(status, client);

         // Orders Datas
         for ( int i = 1; i <= orderQuant; i++ ) {
            // Item Datas
            Console.WriteLine( $"Enter #{i} item datas:" );
            // name
            Console.Write( "Product name: " );
            string nameItem = Console.ReadLine();
            // price
            Console.Write( "Product price: " );
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Item instantiation
            Product product = new Product(nameItem, price);

            // Order Item Datas
            // quantity
            Console.Write( "Product quantity: " );
            int intemQuant = int.Parse(Console.ReadLine());

            // Add intem to order
            order.AddItems( new OrderItem( intemQuant , price , product ) );

            Console.WriteLine();
         }

         // Output
         Console.WriteLine(order.ToString());
      }
   }
}
