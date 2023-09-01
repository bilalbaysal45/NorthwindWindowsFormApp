using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Forms.ViewModels
{
    public class OrderDetailInputModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public decimal GrossAmount
        {
            get
            {
                return UnitPrice * Quantity;
            }
        }
        public decimal NetAmount
        {
            get
            {
                return GrossAmount * (1 - (decimal)Discount);
            }
        }
    }
}
