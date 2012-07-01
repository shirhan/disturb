using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disturb.Models
{
    public class DeliveryDetail
    {
        public int DeliveryDetailId { get; set; }
        public int DeliveryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Delivery Delivery { get; set; }
    }
}