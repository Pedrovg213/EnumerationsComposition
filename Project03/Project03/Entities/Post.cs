using System;
using System.Collections.Generic;
using System.Text;

namespace Project03.Entities {
   internal class Post {

      public DateTime Moment {
         get; set;
      }
      public int Likes {
         get; set;
      }
      public string Title {
         get; set;
      }
      public string Content {
         get; set;
      }
      public List<Comment> Comments { 
         get; set; 
      } = new List<Comment>();


      public Post( DateTime _moment , string _title , string _content , int _likes ) {

         Moment = _moment;
         Title = _title;
         Content = _content;
         Likes = _likes;
      }


      public void AddComment( params Comment[ ] _comment ) {

         foreach ( Comment c in _comment )
            Comments.Add( c );
      }
      public void AddComment( params string[ ] _comment ) {

         foreach ( string c in _comment )
            Comments.Add( new Comment( c ) );
      }
      public void RemoveComment( Comment _comment ) {

         Comments.Remove( _comment );
      }


      public override string ToString( ) {

         StringBuilder stringBuilder = new StringBuilder();
         stringBuilder.AppendLine( Title );
         stringBuilder.Append( Likes + " Likes - " );
         stringBuilder.AppendLine( Moment.ToString( "dd/MM/yyyy HH/mm/ss" ) );
         stringBuilder.AppendLine( Content );
         stringBuilder.AppendLine( "Comments:" );
         foreach ( Comment c in Comments )
            stringBuilder.AppendLine( c.ToString() );

         return stringBuilder.ToString();
      }
   }
}
