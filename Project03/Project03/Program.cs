using Project03.Entities;
using System;

namespace Project03 {
   internal class Program {
      static void Main( string[ ] args ) {
         string title = "Traveling to New Zeland.";
         string content = "I'm going to visit this wonderful country!";
         DateTime dateTime = DateTime.Parse("21/03/2018 13:45:51");

         Post post01 = new Post(dateTime, title, content, 12);

         string comment01 = "Have a nice trip!";
         string comment02 = "Wow, that's awesome!";

         post01.AddComment( comment01 , comment02 );

         title = "Good night guys.";
         content = "See you tomorrow";
         dateTime = DateTime.Parse( "28/07/2018 23:14:19" );

         Post post02 = new Post(dateTime, title, content, 5);

         comment01 = "Good night";
         comment02 = "May the Force be with you";

         post02.AddComment( comment01 , comment02 );

         Console.WriteLine( post01 );
         Console.WriteLine( post02 );
      }
   }
}
