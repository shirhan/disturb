using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Disturb.Models
{
    public class Delivery
    {
        public Delivery()
        {
            DeliviryDate = DateTime.Now;
            Provider = new Provider();
        }
        public int DeliveryId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DeliviryDate { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
        public List<DeliveryDetail> DeliveryDetails { get; set; }
    }
}