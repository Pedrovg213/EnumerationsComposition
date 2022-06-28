using System;

namespace Project04.Entities {
   internal class Client {
      public string Name {
         get; set;
      }
      public string Email {
         get; set;
      }
      public DateTime BirthDate {
         get; set;
      }


      public Client( string _name , DateTime _birthDate ) {
         
         Name = _name;
         BirthDate = _birthDate;
      }
      public Client(string _name, DateTime _birthDate, string _email) : 
         this(_name, _birthDate ) {

         Email = _email;
      }


      public override string ToString( ) {
         return $"{Name} ({BirthDate.ToString( "dd/MM/yyyy" )}) - {Email}.";
      }
   }
}
