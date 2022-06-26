using System;
using System.Globalization;
using Project02.Entities;
using Project02.Entities.Enums;

namespace Project02 {
   internal class Program {
      static void Main( string[] args ) {

         // Inputing variables
         // Department's name
         Console.Write( "Enter department's name: " );
         string _deptName = Console.ReadLine();

         // Worker data
         Console.WriteLine( "Enter worker data: " );
         // name
         Console.Write( "Name: " );
         string _workerName = Console.ReadLine();
         // level
         Console.Write( "Level (Junior / MidLevel / Senior): " );
         WorkerLevel _workerLevel = (WorkerLevel)Enum.Parse(typeof (WorkerLevel), Console.ReadLine());
         // base salary
         Console.Write( "Base Salary: " );
         double _workerBSlry = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         // Instantiating
         // department
         Department _dp = new Department(_deptName);
         // worker
         Worker _worker = new Worker(_workerName, _workerLevel, _workerBSlry, _dp);
         // contracts
         Console.Write( "How many contracts to this worker? " );
         int _contNum = int.Parse(Console.ReadLine());
         for ( int i = 1; i <= _contNum; i++ ) {
            // Inputing contract data
            Console.Write( $"Enter #{i} contract data: " );
            // date
            Console.Write( "Date (DD/MM/YYYY): " );
            DateTime _date = DateTime.Parse(Console.ReadLine());
            // value per hour
            Console.Write( "Value per hour: " );
            double _vpHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // duration
            Console.Write( "Duration (hours): " );
            int _hours = int.Parse(Console.ReadLine());

            // Instantiating contract
            HourContract _contract = new HourContract(_date, _vpHour, _hours);
            _worker.AddContract( _contract );

            Console.WriteLine();
         }

         // Output
         Console.Write( "Enter month and year to calculate income (MM/YYYY): " );
         string _monthYear = Console.ReadLine();
         int _month = int.Parse(_monthYear.Substring(0, 2));
         int _year = int.Parse(_monthYear.Substring(3));

         Console.WriteLine();
         Console.WriteLine( "Name: " + _worker.Name );
         Console.WriteLine( "Department: " + _worker.Department.Name );
         Console.WriteLine($"Income for {_monthYear}: {_worker.Income(_month, _year).ToString("F2", CultureInfo.InvariantCulture)} ");
      }
   }
}
