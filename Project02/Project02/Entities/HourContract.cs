using System;

namespace Project02.Entities {
   internal class HourContract {
      
      public DateTime Date { get; set; }
      public double HourValue { get; set; }
      public double HoursWorked { get; set; }


      public HourContract() {
      }

      public HourContract( DateTime _date, double _hourValue, double _hoursWorked ) {
         
         Date = _date;
         HourValue = _hourValue;
         HoursWorked = _hoursWorked;
      }


      public double TotalValue() {

         return HourValue * HoursWorked;
      }
   }
}
