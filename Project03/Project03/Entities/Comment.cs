namespace Project03.Entities {
   internal class Comment {

      public string Text { get; set; }


      public Comment( string _text ) {
         Text = _text;
      }


      public override string ToString( ) {
         return Text;
      }
   }
}
