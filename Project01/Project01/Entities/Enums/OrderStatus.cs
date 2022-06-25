using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.Entities.Enums {
   enum OrderStatus : int {
      PendingPayment,
      Processing,
      Shipped,
      Delivered
   }
}
