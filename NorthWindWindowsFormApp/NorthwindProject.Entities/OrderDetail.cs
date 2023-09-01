using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entities
{
    public class OrderDetail
    {
        [Browsable(false)]
        public int OrderID { get; set; }

        [Browsable(false)]
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
