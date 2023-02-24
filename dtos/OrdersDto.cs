using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG_Mart.dtos
{
    internal class OrdersDto
    {
        public int orderId { get; set; }
        public int Qty { get; set; }
        public string OrderPlace { get; set; }
        public int Rate { get; set; }

        public double Total()
        {
            return Qty * Rate;
        }
    }
}
