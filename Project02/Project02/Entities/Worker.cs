using System.Collections.Generic;
using Project02.Entities.Enums;

namespace Project02.Entities {
   internal class Worker {

      public string Name { get; set; }
      public double BaseSalary { get; set; }
      public Department Department { get; set; }
      public List<HourContract> Contracts { get; set; } = new List<HourContract>();
      public WorkerLevel Level { get; set; }


      public Worker() {
      }
      public Worker( string _name, WorkerLevel _level, double _baseSalary, Department _department ) {

         Name = _name;
         Level = _level;
         BaseSalary = _baseSalary;
         Department = _department;
      }


      public void AddContract( HourContract _contract ) {

         Contracts.Add( _contract );
      }
      public void RemoveContract( HourContract _contract ) {

         Contracts.Remove( _contract );
      }


      public double Income( int _month, int _year ) {

         double sum = BaseSalary;

         foreach ( HourContract contract in Contracts ) {
            if ( contract.Date.Year == _year && contract.Date.Month == _month )
               sum += contract.TotalValue();
         }

         return sum;
      }
   }
}
